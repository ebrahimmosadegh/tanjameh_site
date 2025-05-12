using System.Collections.Generic;

namespace Tanjameh.Core.Dtos.Scraping
{
    /// <summary>
    /// DTO representing the lightweight price and availability status of a product variant.
    /// Used by IProductUpdater implementations.
    /// </summary>
    public class VariantUpdateDto
    {
        /// <summary>
        /// The unique identifier for the variant on the source platform.
        /// </summary>
        public string SourceVariantId { get; set; } = string.Empty;

        /// <summary>
        /// The current price of the variant.
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// The currency of the price (e.g., "GBP", "EUR").
        /// </summary>
        public string? Currency { get; set; }

        /// <summary>
        /// Indicates if the variant is currently in stock or available for purchase.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Optional: Specific stock quantity if available from the source.
        /// </summary>
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Optional: Indicates if the variant is eligible for free shipping based on source info.
        /// </summary>
        public bool? IsEligibleForFreeShipping { get; set; }
    }

    /// <summary>
    /// DTO representing the comprehensive details of a product fetched from a source.
    /// Used by IProductGrabber implementations.
    /// </summary>
    public class ProductGrabberDto
    {
        /// <summary>
        /// The unique identifier for the product on the source platform.
        /// </summary>
        public string SourceProductId { get; set; } = string.Empty;

        /// <summary>
        /// The name or title of the product.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The brand name.
        /// </summary>
        public string? BrandName { get; set; }

        /// <summary>
        /// Short description or marketing copy.
        /// </summary>
        public string? ShortDescription { get; set; }

        /// <summary>
        /// Detailed description, potentially including material, care instructions, etc.
        /// Often structured (e.g., JSON or HTML).
        /// </summary>
        public string? FullDescription { get; set; }

        /// <summary>
        /// List of category names or breadcrumbs from the source.
        /// </summary>
        public List<string> Categories { get; set; } = new List<string>();

        /// <summary>
        /// List of tags associated with the product (e.g., "Sale", "Sustainable").
        /// </summary>
        public List<string> Tags { get; set; } = new List<string>();

        /// <summary>
        /// Gender association (e.g., "Men", "Women", "Unisex").
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// URL of the main product image.
        /// </summary>
        public string? MainImageUrl { get; set; }

        /// <summary>
        /// URLs of additional product images.
        /// </summary>
        public List<string> AdditionalImageUrls { get; set; } = new List<string>();

        /// <summary>
        /// List of available variants (sizes, colors) with their details.
        /// </summary>
        public List<ProductVariantGrabberDto> Variants { get; set; } = new List<ProductVariantGrabberDto>();

        /// <summary>
        /// Direct URL to the product page on the source website.
        /// </summary>
        public string? ProductUrl { get; set; }
    }

    /// <summary>
    /// DTO representing a single product variant within the ProductGrabberDto.
    /// </summary>
    public class ProductVariantGrabberDto
    {
        /// <summary>
        /// The unique identifier for the variant on the source platform.
        /// </summary>
        public string SourceVariantId { get; set; } = string.Empty;

        /// <summary>
        /// Name or identifier for the variant (e.g., size + color).
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The specific size (e.g., "M", "UK 10", "42").
        /// </summary>
        public string? Size { get; set; }

        /// <summary>
        /// The specific color.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// SKU (Stock Keeping Unit) if available.
        /// </summary>
        public string? Sku { get; set; }

        /// <summary>
        /// EAN (European Article Number) or UPC (Universal Product Code) if available.
        /// </summary>
        public string? Ean { get; set; }

        /// <summary>
        /// The current price of this specific variant.
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// The original or previous price, if available (for sale detection).
        /// </summary>
        public decimal? OldPrice { get; set; }

        /// <summary>
        /// The currency of the price.
        /// </summary>
        public string? Currency { get; set; }

        /// <summary>
        /// Indicates if the variant is currently in stock or available.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Optional: Specific stock quantity.
        /// </summary>
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Optional: Image URL specific to this variant (e.g., different color).
        /// </summary>
        public string? ImageUrl { get; set; }
    }
}

