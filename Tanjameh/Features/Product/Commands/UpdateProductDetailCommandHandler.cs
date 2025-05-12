using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Tanjameh.BackgroundServices.Constants;
using Tanjameh.BackgroundServices.ViewModel; // AsosProductDetailtResponse
using Tanjameh.Core.Constants;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Helper; // For InternalProductCodeGenerator
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Core.Dtos.Scraping; // For ProductGrabberDto (if needed for classification)

namespace Tanjameh.Features.Product.Commands;


public record UpdateProductDetailCommand(int ProductId) : IRequest<bool>;
public class UpdateProductDetailCommandHandler : IRequestHandler<UpdateProductDetailCommand, bool>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<UpdateProductDetailCommandHandler> _logger;
    private readonly INotificationService _notificationService;
    private readonly IWeightEstimationService _weightEstimationService;
    private readonly IProductBlacklistService _blacklistService; // Added
    private readonly ICategoryClassificationService _categoryClassificationService; // Added

    private ApplicationDbContext? _dbContext = null;
    private int? _productId;

    private const decimal FreeShippingThreshold = 50.0m;

    public UpdateProductDetailCommandHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory,
             IHttpClientFactory httpClientFactory, ILogger<UpdateProductDetailCommandHandler> logger,
             INotificationService notificationService,
             IWeightEstimationService weightEstimationService,
             IProductBlacklistService blacklistService, // Added
             ICategoryClassificationService categoryClassificationService) // Added
    {
        this._dbContextFactory = dbContextFactory;
        this._httpClientFactory = httpClientFactory;
        this._logger = logger;
        this._notificationService = notificationService;
        this._weightEstimationService = weightEstimationService;
        this._blacklistService = blacklistService; // Added
        this._categoryClassificationService = categoryClassificationService; // Added
    }
    public async Task<bool> Handle(UpdateProductDetailCommand request, CancellationToken cancellationToken)
    {
        _productId = request.ProductId;

        // Use ASOS client for now, needs generalization if handling other sources here
        using HttpClient httpClient = _httpClientFactory.CreateClient(HttpClientNames.AsosRapidApi);
        using (_dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
            try
            {
                Core.Entities.Product? existProduct = await _dbContext.Products
                    .Include(x => x.ProductVariants)
                    .Include(x => x.CatalogBrand)
                    .Include(x => x.ProductCategories)!.ThenInclude(pc => pc.Category)
                    .Include(x => x.LogicalCategories) // Include for classification service
                    // Include tags if stored on Product entity
                    .FirstOrDefaultAsync(x => x.Id == _productId, cancellationToken);

                if (existProduct is null)
                {
                    _logger.LogWarning("Product with ID {ProductId} not found.", _productId);
                    return false;
                }

                // --- Blacklist Check --- 
                bool isBlacklisted = await _blacklistService.IsProductBlacklistedAsync(existProduct);
                if (isBlacklisted)
                {
                    _logger.LogWarning("Product ID {ProductId} is blacklisted. Skipping update and marking as hidden.", _productId);
                    existProduct.Hidden = true; // Mark as hidden
                    existProduct.Exist = false; // Also mark as non-existent in our catalog
                    await _dbContext.SaveChangesAsync(cancellationToken);
                    return false; // Stop processing blacklisted items
                }
                else if (existProduct.Hidden) // Unhide if no longer blacklisted
                {
                    _logger.LogInformation("Product ID {ProductId} is no longer blacklisted. Marking as not hidden.", _productId);
                    existProduct.Hidden = false;
                    // We might need to re-evaluate existProduct.Exist based on API response later
                }
                // --- End Blacklist Check ---

                // Check if update is needed based on DetailsLastCheckedUtc
                var detailsUpdateThreshold = DateTime.UtcNow.AddHours(-1); // Example: Update details every hour
                bool needsDetailFetch = !existProduct.DetailsLastCheckedUtc.HasValue || existProduct.DetailsLastCheckedUtc <= detailsUpdateThreshold;
                AsosProductDetailtResponse? productDetails = null;

                // Only fetch from API if needed and ApiId exists
                if (needsDetailFetch && existProduct.ApiId.HasValue && existProduct.DataSource == "ASOS") // Check DataSource
                {
                    _logger.LogInformation("Fetching updated details for ASOS Product ID {ProductId} (ApiId: {ApiId})", _productId, existProduct.ApiId.Value);
                    var productDetailsResponse = await httpClient.GetStringAsync(BuildApiUrl(existProduct.ApiId.Value), cancellationToken);
                    if (productDetailsResponse is null)
                        return false;

                    if (productDetailsResponse.Contains("\"errorMessage\":\"No available product"))
                    {
                        _logger.LogWarning("Product {ProductId} marked as unavailable by API.", _productId);
                        existProduct.Exist = false;
                        // Mark variants as non-existent too
                        foreach(var v in existProduct.ProductVariants ?? Enumerable.Empty<ProductVariant>())
                        {
                            v.Exist = false;
                            v.IsAvailable = false;
                            v.AvailabilityLastCheckedUtc = DateTime.UtcNow;
                        }
                        await _dbContext.SaveChangesAsync(cancellationToken);
                        return false;
                    }

                    await UpdateRawProductData(productDetailsResponse, cancellationToken);
                    productDetails = DeserializeProductDetails(productDetailsResponse);
                    if (productDetails is null)
                        return false;

                    // --- Update Product Core Details ---
                    // Assign InternalProductCode if missing
                    if (string.IsNullOrEmpty(existProduct.InternalProductCode))
                    {
                         existProduct.InternalProductCode = InternalProductCodeGenerator.GenerateInternalCode(existProduct.DataSource, existProduct.ApiId.Value.ToString());
                    }
                    // Ensure DataSource is set (redundant if checked above, but safe)
                    existProduct.DataSource = "ASOS"; 

                    await UpdateProductType(existProduct, productDetails, cancellationToken);
                    UpdateProductBrand(existProduct, productDetails);
                    if (productDetails.Info?.AboutMe != null)
                    {
                        existProduct.ShortDescription = productDetails.Info.AboutMe;
                        existProduct.FullDescription = JsonSerializer.Serialize(productDetails.Info);
                    }
                    existProduct.SiteLink = productDetails.LocalisedData?.FirstOrDefault(x => x.Locale == "en-GB")?.PdpUrl;
                    existProduct.DetailsLastCheckedUtc = DateTime.UtcNow; // Update timestamp
                    existProduct.Exist = true; // Mark as existing since API call was successful

                    // --- Intelligent Category Classification ---
                    // Create a temporary DTO for the classification service
                    var grabberDtoForClassification = MapToGrabberDto(productDetails, existProduct.ApiId.Value.ToString());
                    await _categoryClassificationService.ClassifyProductAsync(existProduct, grabberDtoForClassification);
                    // --- End Category Classification ---

                    // --- Update Variants --- 
                    await UpdateProductVariantsAsync(existProduct, productDetails, cancellationToken);

                    // --- Weight Estimation --- 
                    if (!existProduct.ActualWeightKg.HasValue || existProduct.ActualWeightKg <= 0)
                    {
                        await _weightEstimationService.UpdateProductWeightAsync(existProduct);
                    }
                    else if (existProduct.WeightSource != Core.Enums.WeightSource.ManualEntry)
                    {
                        // Ensure source is ManualEntry if ActualWeightKg is set
                        existProduct.WeightSource = Core.Enums.WeightSource.ManualEntry;
                    }
                }
                else if (!existProduct.ApiId.HasValue || existProduct.DataSource != "ASOS")
                {
                     _logger.LogWarning("Product ID {ProductId} has no ASOS ApiId or wrong DataSource ({DataSource}). Cannot fetch details.", _productId, existProduct.DataSource);
                     // Still run weight estimation if possible
                     if (!existProduct.ActualWeightKg.HasValue || existProduct.ActualWeightKg <= 0)
                     {
                         await _weightEstimationService.UpdateProductWeightAsync(existProduct);
                     }
                }
                else // Details are fresh, but variants might need update
                {
                    _logger.LogInformation("Product {ProductId} core details checked recently. Checking variants for updates...", _productId);
                    // TODO: Implement selective variant update based on variant timestamps if needed
                    // This would involve calling the IProductUpdater for each stale variant.
                    // For now, we assume the full detail fetch handles variants sufficiently.
                    // If weight estimation hasn't run, run it now.
                     if ((!existProduct.EstimatedWeightKg.HasValue || existProduct.EstimatedWeightKg <= 0) && (!existProduct.ActualWeightKg.HasValue || existProduct.ActualWeightKg <= 0))
                     {
                         await _weightEstimationService.UpdateProductWeightAsync(existProduct);
                     }
                }

                // --- Save All Changes ---
                existProduct.UpdatedOnUtc = DateTime.UtcNow; // Update overall timestamp
                await _dbContext.SaveChangesAsync(cancellationToken);
                _logger.LogInformation("Successfully processed product update for Product ID: {ProductId}", _productId);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating product details for Product ID: {ProductId}", _productId);
                return false;
            }
            finally
            {
                _dbContext = null; // Ensure context is disposed
            }
    }

    // Helper to map AsosProductDetailtResponse to ProductGrabberDto for classification service
    private ProductGrabberDto MapToGrabberDto(AsosProductDetailtResponse source, string sourceProductId)
    {
        return new ProductGrabberDto
        {
            SourceProductId = sourceProductId,
            Name = source.Name,
            BrandName = source.Brand?.Name,
            // Map categories if available in AsosProductDetailtResponse (assuming they are not directly)
            Categories = new List<string> { source.ProductType?.Name ?? "Unknown" }, // Example: Use ProductType as category
            Tags = source.Info?.Badges?.Select(b => b.Label).ToList() ?? new List<string>(), // Use badges as tags
            Variants = source.Variants?.Select(v => new ProductVariantGrabberDto
            {
                SourceVariantId = v.Id.ToString(),
                Price = v.Price?.Current?.Value,
                OldPrice = v.Price?.Previous?.Value, // Pass old price for sale detection
                IsAvailable = v.IsAvailable
                // Map other variant fields if needed by classification rules
            }).ToList() ?? new List<ProductVariantGrabberDto>()
            // Map other fields like Description if needed by classification rules
        };
    }

    // --- UpdateProductVariantsAsync remains largely the same ---
    private async Task UpdateProductVariantsAsync(Product existProduct, AsosProductDetailtResponse productDetails, CancellationToken cancellationToken)
    {
        // ... (Implementation as before) ...
        var now = DateTime.UtcNow;
        var existVariants = existProduct.ProductVariants?.ToList() ?? new List<ProductVariant>();

        foreach (var variantData in productDetails.Variants ?? [])
        {
            var existVariant = existVariants.FirstOrDefault(x => x.ApiId == variantData.Id);
            bool isNewVariant = existVariant == null;

            if (isNewVariant)
            {
                existVariant = new ProductVariant { ProductId = existProduct.Id };
                existProduct.ProductVariants ??= new List<ProductVariant>();
                existProduct.ProductVariants.Add(existVariant);
            }

            var oldPrice = existVariant.PriceCurrentValue;
            var wasAvailable = existVariant.IsAvailable;
            var oldStock = existVariant.StockQuantity;

            existVariant.ApiId = variantData.Id;
            existVariant.Name = variantData.Name;
            existVariant.SizeId = (int?)variantData.SizeId;
            existVariant.BrandSize = variantData.BrandSize;
            existVariant.DisplaySizeText = variantData.DisplaySizeText;
            existVariant.SizeOrder = variantData.SizeOrder;
            existVariant.Sku = variantData.Sku;
            existVariant.Colour = variantData.Colour?.ToLower();
            existVariant.ColourWayId = variantData.ColourWayId;
            existVariant.IsPrimary = variantData.IsPrimary;
            existVariant.IsProp65Risk = variantData.IsProp65Risk;
            existVariant.GenderTypeId = existProduct.GenderTypeId;
            existVariant.Exist = true;

            var newPrice = variantData.Price?.Current?.Value;
            if (existVariant.PriceCurrentValue != newPrice)
            {
                existVariant.PriceCurrentValue = newPrice;
                existVariant.PriceLastCheckedUtc = now;
            }
            var newAvailability = variantData.IsAvailable;
            // Basic stock logic: assume some stock if available, zero if not.
            // Real stock requires better API data or different logic.
            var newStock = variantData.IsInStock ? (existVariant.StockQuantity ?? 1) : 0; 
            if (existVariant.IsAvailable != newAvailability || existVariant.StockQuantity != newStock)
            {
                existVariant.IsAvailable = newAvailability;
                existVariant.StockQuantity = newStock;
                existVariant.AvailabilityLastCheckedUtc = now;
            }

            existVariant.IsEligibleForFreeShipping = (existVariant.PriceCurrentValue ?? 0) >= FreeShippingThreshold;

            if (!isNewVariant)
            {
                if (existVariant.PriceCurrentValue < oldPrice && existVariant.PriceCurrentValue.HasValue && oldPrice.HasValue)
                {
                    await _notificationService.NotifyPriceChangeAsync(existVariant, oldPrice.Value, existVariant.PriceCurrentValue.Value);
                }
                if (wasAvailable == false && existVariant.IsAvailable == true)
                {
                    await _notificationService.NotifyStockChangeAsync(existVariant, 0, existVariant.StockQuantity.GetValueOrDefault(1));
                }
            }
        }

        foreach (var item in existVariants.Where(ev => productDetails.Variants?.All(v => v.Id != ev.ApiId) ?? true))
        {
            if (item.Exist != false)
            {
                 item.Exist = false;
                 item.IsAvailable = false; // Also mark as unavailable
                 item.AvailabilityLastCheckedUtc = now;
            }
        }
    }

    // --- Other Helper methods (UpdateProductType, UpdateProductBrand, DeserializeProductDetails, BuildApiUrl, UpdateRawProductData) remain the same ---
    private async Task UpdateProductType(Core.Entities.Product existProduct, AsosProductDetailtResponse productDetails, CancellationToken cancellationToken)
    {
        // ... (Implementation as before) ...
        if (_dbContext == null) throw new InvalidOperationException("Database context is not initialized.");
        if (existProduct.ProductTypeId == null && productDetails.ProductType != null)
        {
            var productType = await _dbContext.ProductTypes.FirstOrDefaultAsync(x => x.Name == productDetails.ProductType.Name, cancellationToken);
            if (productType != null)
            {
                existProduct.ProductTypeId = productType.Id;
            }
            else
            {
                var newProductType = new Core.Entities.ProductType
                {
                    Name = productDetails.ProductType.Name,
                    ApiId = productDetails.ProductType.Id,
                    Slug = productDetails.ProductType.Name.ToSlug()
                };
                _dbContext.ProductTypes.Add(newProductType);
                existProduct.ProductType = newProductType; 
            }
        }
    }

    private void UpdateProductBrand(Core.Entities.Product existProduct, AsosProductDetailtResponse productDetails)
    {
        // ... (Implementation as before) ...
        if (productDetails.Brand == null || existProduct.CatalogBrand == null)
            return;
        existProduct.CatalogBrand.ApiId = productDetails.Brand.Id;
        if (string.IsNullOrEmpty(existProduct.CatalogBrand.Description) && productDetails.Brand.Description != null)
        {
            existProduct.CatalogBrand.Description =
                productDetails.Brand.Description.Length > 900 ? productDetails.Brand.Description.Substring(0, 900) : productDetails.Brand.Description;
        }
    }
    private static AsosProductDetailtResponse? DeserializeProductDetails(string productDetailsResponse)
    {
        // ... (Implementation as before) ...
        try
        {
            return JsonSerializer.Deserialize<AsosProductDetailtResponse>(
                productDetailsResponse,
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Failed to deserialize product details: {ex.Message}"); // Replace with proper logging
            return null;
        }
    }
    private static string BuildApiUrl(long productId)
    {
        // ... (Implementation as before) ...
        return $"products/v3/detail?id={productId}&lang=en-GB&store=ROW&sizeSchema=UK&currency=GBP";
    }
    private async Task UpdateRawProductData(string productDetailsResponse, CancellationToken cancellationToken)
    {
        // ... (Implementation as before) ...
        if (_dbContext == null) throw new InvalidOperationException("Database context is not initialized.");
        var rawData = await _dbContext.ProductRawDatas.FirstOrDefaultAsync(x => x.ProductId == _productId, cancellationToken);
        if (rawData == null)
        {
            rawData = new ProductRawData { ProductId = _productId!.Value, RawData = productDetailsResponse };
            _dbContext.ProductRawDatas.Add(rawData);
        }
        else
        {
            rawData.RawData = productDetailsResponse;
        }
    }
}

