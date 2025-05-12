using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Tanjameh.Core.Abstractions;
using Tanjameh.Core.Helper;

namespace Tanjameh.Core.Entities;


public partial class ProductVariant : BaseEntity<int>
{
    public ProductVariant()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private ProductVariant(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    public int ProductId { get; set; }

    private Product _product;

    [JsonIgnore]
    public Product Product
    {
        get => LazyLoader?.Load(this, ref _product) ?? (_product ??= new Product());
    }


    // Id is inherited from BaseEntity<int>
    // public int Id { get; set; }

    public string? Name { get; set; }

    public bool IsDefault { get; set; }


    public int? SizeId { get; set; }

    public string? BrandSize { get; set; }

    public string? SizeDescription { get; set; }

    public string? DisplaySizeText { get; set; }

    public int? SizeOrder { get; set; }

    public string? Sku { get; set; }

    public bool? IsLowInStock { get; set; }

    // Deprecating IsInStock in favor of StockQuantity
    // public bool? IsInStock { get; set; }

    public bool? IsAvailable { get; set; }

    public string? Colour { get; set; }

    public int? ColourWayId { get; set; }

    [Column(TypeName = "decimal(18, 2)")] // Ensure precision for price
    public decimal? PriceCurrentValue { get; set; }

    public string? PriceCurrentText { get; set; }

    public string? Currency { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsProp65Risk { get; set; }

    public string? Ean { get; set; }

    public string? Seller { get; set; }


    public int? GenderTypeId { get; set; }

    [NotMapped]
    public GenderType? GenderType
    {
        get => (GenderType?)GenderTypeId;
        set => GenderTypeId = (int?)value;
    }

    public long? ApiId { get; set; }


    public bool? Exist { get; set; } = true;

    // StockQuantity property (already added)
    public int? StockQuantity { get; set; }

    // --- New Fields for Scraping/Logistics Upgrade ---

    /// <summary>
    /// Indicates if this specific product variant (size) is eligible for free shipping based on criteria.
    /// </summary>
    public bool IsEligibleForFreeShipping { get; set; } = false;

    /// <summary>
    /// Timestamp of when the price for this variant was last checked/updated from the source.
    /// </summary>
    public DateTime? PriceLastCheckedUtc { get; set; }

    /// <summary>
    /// Timestamp of when the availability (stock) for this variant was last checked/updated from the source.
    /// </summary>
    public DateTime? AvailabilityLastCheckedUtc { get; set; }

}

