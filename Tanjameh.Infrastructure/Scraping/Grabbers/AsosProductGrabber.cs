using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Tanjameh.BackgroundServices.Constants; // For HttpClientNames
using Tanjameh.BackgroundServices.ViewModel; // For AsosProductDetailtResponse
using Tanjameh.Core.Dtos.Scraping;
using Tanjameh.Core.Interfaces.Scraping;

namespace Tanjameh.Infrastructure.Scraping.Grabbers
{
    /// <summary>
    /// Implements IProductGrabber for fetching full product details from ASOS (via RapidAPI).
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Fetches comprehensive product details from ASOS for initial import.
    /// Usage: Used by import services to create new product entries.
    /// Dependencies: IHttpClientFactory, ILogger.
    /// Source: Assumes ASOS data is fetched via a configured RapidAPI endpoint.
    /// </remarks>
    public class AsosProductGrabber : IProductGrabber
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<AsosProductGrabber> _logger;

        public string SourceName => "ASOS";

        public AsosProductGrabber(IHttpClientFactory httpClientFactory, ILogger<AsosProductGrabber> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        /// <summary>
        /// Fetches the full product details from ASOS using the product's source-specific ID.
        /// </summary>
        /// <param name="sourceProductId">The ASOS product ID.</param>
        /// <returns>A ProductGrabberDto with full details, or null if fetching fails.</returns>
        public async Task<object?> GrabProductDetailsAsync(string sourceProductId)
        {
            if (!long.TryParse(sourceProductId, out long productId))
            {
                _logger.LogError("Invalid sourceProductId format for ASOS: {SourceProductId}. Expected a long integer.", sourceProductId);
                return null;
            }

            _logger.LogInformation("Grabbing full product details for ASOS product ID: {ProductId}", productId);

            try
            {
                using HttpClient httpClient = _httpClientFactory.CreateClient(HttpClientNames.AsosRapidApi);
                var apiUrl = BuildApiUrl(productId);
                var productDetailsResponse = await httpClient.GetStringAsync(apiUrl);

                if (string.IsNullOrEmpty(productDetailsResponse) || productDetailsResponse.Contains("\"errorMessage\":\"No available product"))
                {
                    _logger.LogWarning("ASOS product ID {ProductId} not found or unavailable via API.", productId);
                    return null;
                }

                AsosProductDetailtResponse? productDetails = DeserializeProductDetails(productDetailsResponse);
                if (productDetails == null)
                {
                    _logger.LogError("Failed to deserialize ASOS response for product ID: {ProductId}", productId);
                    return null;
                }

                // Map AsosProductDetailtResponse to ProductGrabberDto
                var grabberDto = MapToGrabberDto(productDetails, productId);
                
                _logger.LogInformation("Successfully grabbed details for ASOS product ID: {ProductId}", productId);
                return grabberDto;
            }
            catch (HttpRequestException ex)
            {
                 _logger.LogError(ex, "HTTP error grabbing details for ASOS product ID: {ProductId}", productId);
                 return null;
            }
            catch (JsonException ex)
            {
                 _logger.LogError(ex, "JSON deserialization error grabbing details for ASOS product ID: {ProductId}", productId);
                 return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error grabbing details for ASOS product ID: {ProductId}", productId);
                return null;
            }
        }

        private ProductGrabberDto MapToGrabberDto(AsosProductDetailtResponse source, long productId)
        {
            var dto = new ProductGrabberDto
            {
                SourceProductId = productId.ToString(),
                Name = source.Name ?? string.Empty,
                BrandName = source.Brand?.Name,
                ShortDescription = source.Info?.AboutMe, // Or other relevant field
                FullDescription = source.Info != null ? JsonSerializer.Serialize(source.Info) : null,
                Gender = source.Gender, // Assuming Gender field exists
                MainImageUrl = source.Images?.FirstOrDefault(img => img.IsPrimary)?.Url, // Find primary image
                AdditionalImageUrls = source.Images?.Where(img => !img.IsPrimary).Select(img => img.Url).ToList() ?? new List<string>(),
                ProductUrl = source.LocalisedData?.FirstOrDefault(x => x.Locale == "en-GB")?.PdpUrl,
                Categories = new List<string> { source.ProductType?.Name ?? "Unknown" }, // Basic category from ProductType
                Tags = source.Badges?.Select(b => b.BadgeType).ToList() ?? new List<string>() // Example: Using Badges as Tags
            };

            // Map Variants
            foreach (var variantSource in source.Variants ?? Enumerable.Empty<ProductDetailtVariant>())
            {
                dto.Variants.Add(new ProductVariantGrabberDto
                {
                    SourceVariantId = variantSource.Id.ToString(),
                    Name = variantSource.Name, // Often includes size/color
                    Size = variantSource.BrandSize ?? variantSource.DisplaySizeText,
                    Color = variantSource.Colour,
                    Sku = variantSource.Sku,
                    Ean = null, // EAN not directly available in provided ViewModel
                    Price = variantSource.Price?.Current?.Value,
                    OldPrice = variantSource.Price?.Previous?.Value,
                    Currency = variantSource.Price?.Currency,
                    IsAvailable = variantSource.IsAvailable ?? false,
                    StockQuantity = variantSource.IsInStock == true ? 10 : 0, // Example: Infer stock, API might not provide exact count
                    ImageUrl = source.Images?.FirstOrDefault(img => img.ColourWayId == variantSource.ColourWayId && !img.IsPrimary)?.Url // Find variant-specific image
                });
            }
            
            // If no main image found, try taking the first one
            if (string.IsNullOrEmpty(dto.MainImageUrl) && dto.AdditionalImageUrls.Any())
            {
                dto.MainImageUrl = dto.AdditionalImageUrls.First();
            }
            else if (string.IsNullOrEmpty(dto.MainImageUrl) && source.Images?.Any() == true)
            {
                 dto.MainImageUrl = source.Images.First().Url;
            }

            return dto;
        }

        // Helper methods copied/adapted from UpdateProductDetailCommandHandler
        private string BuildApiUrl(long productId)
        {
            return $"products/v4/detail?lang=en-GB&store=COM&sizeSchema=US&currency=GBP&id={productId}";
        }

        private static AsosProductDetailtResponse? DeserializeProductDetails(string productDetailsResponse)
        {
            try
            {
                return JsonSerializer.Deserialize<AsosProductDetailtResponse>(
                    productDetailsResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            catch (JsonException ex)
            {
                // Log the error appropriately in the calling method
                Console.WriteLine($"Failed to deserialize product details: {ex.Message}"); // Replace with proper logging
                return null;
            }
        }
    }
}

