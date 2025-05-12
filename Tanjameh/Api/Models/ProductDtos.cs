using Tanjameh.Core.Entities; // Likely needed for base types if any
using Tanjameh.Core.Interfaces; // Added for PriceCalculationResult

namespace Tanjameh.Api.Models.Products;

// DTO for product listing
public class ProductSummaryDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public string? ImageUrl { get; set; } // Assuming a primary image URL
    
    // Original Price (e.g., GBP) - Assuming this is the base price for margin calculation
    public decimal OriginalPrice { get; set; } 
    
    // Calculated Local Price Info
    public PriceCalculationResult? LocalPriceInfo { get; set; }
    
    public string? BrandName { get; set; }
}

// DTO for product details
public class ProductDetailDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public string? ShortDescription { get; set; }
    public string? FullDescription { get; set; } // Or structured info
    public string? BrandName { get; set; }
    public List<ProductVariantDto> Variants { get; set; } = new();
    public List<string> ImageUrls { get; set; } = new(); // All image URLs
    // Add other relevant details like Category, Tags etc.

    // Optional: Main product local price if applicable (e.g., for display before variant selection)
    // public PriceCalculationResult? MainLocalPriceInfo { get; set; }
}

public class ProductVariantDto
{
    public int Id { get; set; }
    public string? Name { get; set; } // e.g., Color + Size
    
    // Original Price (e.g., GBP) - Used for margin calculation
    public decimal OriginalPrice { get; set; }
    
    // Calculated Local Price Info
    public PriceCalculationResult? LocalPriceInfo { get; set; }

    public int StockQuantity { get; set; }
    public bool IsAvailable { get; set; }
    public string? Sku { get; set; }
    public string? Color { get; set; }
    public string? Size { get; set; }
    // Add variant-specific image URLs if applicable
}

