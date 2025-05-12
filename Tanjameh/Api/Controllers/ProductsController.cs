using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Api.Models.Products;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Core.Entities; // Required for ProductVisibility enum if used
using Tanjameh.Core.Interfaces; // Added for IPriceCalculatorService
using System.Linq; // Added for LINQ
using System.Threading.Tasks; // Added for Task
using System.Collections.Generic; // Added for IEnumerable/List

namespace Tanjameh.Api.Controllers;

public class ProductsController : BaseApiController
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    private readonly IPriceCalculatorService _priceCalculatorService; // Added
    private readonly ILogger<ProductsController> _logger; // Added for logging

    // TODO: Get target currency from user context/request headers
    private const string DefaultTargetCurrency = "IRR";

    public ProductsController(IDbContextFactory<ApplicationDbContext> contextFactory,
                              IPriceCalculatorService priceCalculatorService, // Added
                              ILogger<ProductsController> logger) // Added
    {
        _contextFactory = contextFactory;
        _priceCalculatorService = priceCalculatorService; // Added
        _logger = logger; // Added
    }

    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductSummaryDto>>> GetProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 10, [FromQuery] string currency = DefaultTargetCurrency)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        string targetCurrency = string.IsNullOrWhiteSpace(currency) ? DefaultTargetCurrency : currency.ToUpperInvariant();

        var productsQuery = context.Products
            .Include(p => p.CatalogBrand)
            .Include(p => p.ProductVariants)
            .Include(p => p.ProductMediaFiles).ThenInclude(pmf => pmf.MediaFile)
            .Where(p => p.Exist && !p.Hidden)
            .OrderBy(p => p.Id);

        var paginatedProducts = await productsQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(); // Fetch entities first

        // Now process and calculate prices
        var productDtos = new List<ProductSummaryDto>();
        foreach (var p in paginatedProducts)
        {
            // Determine the price to display (primary or first variant)
            var displayVariant = p.ProductVariants?.FirstOrDefault(pv => pv.IsPrimary == true) ?? p.ProductVariants?.FirstOrDefault();
            decimal originalPriceGbp = displayVariant?.PriceCurrentValue ?? 0m;

            // Calculate local price
            PriceCalculationResult? localPriceInfo = null;
            if (originalPriceGbp > 0)
            {
                localPriceInfo = await _priceCalculatorService.CalculatePriceAsync(originalPriceGbp, targetCurrency);
                if (localPriceInfo == null)
                {
                    _logger.LogWarning("Failed to calculate local price for Product ID {ProductId} (Variant ID {VariantId}) in {Currency}", p.Id, displayVariant?.Id, targetCurrency);
                }
            }

            productDtos.Add(new ProductSummaryDto
            {
                Id = p.Id,
                Name = p.Name,
                Slug = p.Slug,
                ImageUrl = p.ProductMediaFiles?
                             .OrderBy(pmf => pmf.ProductVarientId == displayVariant?.Id ? 0 : 1)
                             .ThenBy(pmf => pmf.DisplayOrder)
                             .Select(pmf => pmf.MediaFile?.WebUrl)
                             .FirstOrDefault() ?? "/images/placeholder.png",
                OriginalPrice = originalPriceGbp, // Store original GBP price
                LocalPriceInfo = localPriceInfo, // Store calculated local price info
                BrandName = p.CatalogBrand?.Name
            });
        }

        return Ok(productDtos);
    }

    // GET: api/products/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductDetailDto>> GetProduct(int id, [FromQuery] string currency = DefaultTargetCurrency)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        string targetCurrency = string.IsNullOrWhiteSpace(currency) ? DefaultTargetCurrency : currency.ToUpperInvariant();

        var product = await context.Products
            .Include(p => p.CatalogBrand)
            .Include(p => p.ProductVariants)
            .Include(p => p.ProductMediaFiles).ThenInclude(pmf => pmf.MediaFile)
            .Where(p => p.Id == id && p.Exist && !p.Hidden)
            .FirstOrDefaultAsync();

        if (product == null)
        {
            return NotFound();
        }

        // Calculate prices for variants
        var variantDtos = new List<ProductVariantDto>();
        if (product.ProductVariants != null)
        {
            foreach (var pv in product.ProductVariants)
            {
                decimal originalVariantPriceGbp = pv.PriceCurrentValue ?? 0m;
                PriceCalculationResult? localVariantPriceInfo = null;
                if (originalVariantPriceGbp > 0)
                {
                    localVariantPriceInfo = await _priceCalculatorService.CalculatePriceAsync(originalVariantPriceGbp, targetCurrency);
                     if (localVariantPriceInfo == null)
                    {
                        _logger.LogWarning("Failed to calculate local price for Product ID {ProductId}, Variant ID {VariantId} in {Currency}", product.Id, pv.Id, targetCurrency);
                    }
                }

                variantDtos.Add(new ProductVariantDto
                {
                    Id = pv.Id,
                    Name = pv.Name,
                    OriginalPrice = originalVariantPriceGbp,
                    LocalPriceInfo = localVariantPriceInfo,
                    StockQuantity = pv.StockQuantity ?? 0,
                    IsAvailable = pv.IsAvailable ?? false,
                    Sku = pv.Sku,
                    Color = pv.Colour,
                    Size = pv.DisplaySizeText
                });
            }
        }

        var productDetailDto = new ProductDetailDto
        {
            Id = product.Id,
            Name = product.Name,
            Slug = product.Slug,
            ShortDescription = product.ShortDescription,
            FullDescription = product.FullDescription,
            BrandName = product.CatalogBrand?.Name,
            Variants = variantDtos,
            ImageUrls = product.ProductMediaFiles?
                          .OrderBy(pmf => pmf.DisplayOrder)
                          .Select(pmf => pmf.MediaFile?.WebUrl)
                          .Distinct()
                          .ToList() ?? new List<string>()
        };

        return Ok(productDetailDto);
    }
}

