using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Tanjameh.Core.Abstractions;
using Tanjameh.Core.Enums; // Added for WeightSource enum
using Tanjameh.Core.Helper;

namespace Tanjameh.Core.Entities;

public class Product : BaseEntity<int>
{
    public Product()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private Product(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }
    
    // --- New Fields for Scraping/Logistics Upgrade ---

    /// <summary>
    /// Unique internal product code assigned by Tanjameh (e.g., ASO-12345, ZLD-67890).
    /// </summary>
    [StringLength(50)]
    [Required] // Should be generated and required
    public string InternalProductCode { get; set; } = string.Empty; 

    /// <summary>
    /// The original data source of the product (e.g., "ASOS", "ZALANDO", "NEXT").
    /// </summary>
    [StringLength(50)]
    public string? DataSource { get; set; }

    /// <summary>
    /// The product ID from the original data source.
    /// Combined with DataSource, uniquely identifies the product externally.
    /// </summary>
    public long? SourceProductId => ApiId; // Using existing ApiId for this purpose

    // --- Existing Fields ---

    [StringLength(255)]
    public string Name { get; set; } = string.Empty;

    [StringLength(4000)]
    public string Content { get; set; } = string.Empty;

    [StringLength(4000)]
    public string FullDescription { get; set; } = string.Empty;

    [StringLength(1000)]
    public string ShortDescription { get; set; } = string.Empty;

    // Price at the Product level might become less relevant if all pricing is per-variant
    // Consider if this should be deprecated or represent a default/base price.
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OldPrice { get; set; }
    public long? CustomePriceKey { get; set; }

    public int? PriceCurrencyId { get; set; }
    private Currency? _priceCurrency;
    public Currency? PriceCurrency
    {
        get => LazyLoader.Load(this, ref _priceCurrency);
        set => _priceCurrency = value;
    }

    [StringLength(255)]
    public string? MainPictureFileName { get; set; }
    public bool HasPreviewPicture { get; set; }

    public string? WebPictureUrl => MainPictureFileName.FilePathToUrl();

    // InSale might be replaced or driven by the Logical Category system
    public bool InSale { get; set; }

    public int? GenderTypeId { get; set; }

    [NotMapped]
    public GenderType? GenderType
    {
        get => (GenderType?)GenderTypeId;
        set => GenderTypeId = (int?)value;
    }

    public int CatalogBrandId { get; set; }
    private CatalogBrand _catalogBrand;
    public CatalogBrand CatalogBrand
    {
        get => LazyLoader.Load(this, ref _catalogBrand);
        set => _catalogBrand = value;
    }


    /// <summary>
    /// Gets or sets the visibility level of the product.
    /// </summary>
    public ProductVisibility Visibility { get; set; }


    private ICollection<ProductMediaFile>? _productMediaFiles;
    /// <summary>
    /// Gets or sets the product media files.
    /// </summary>
    public ICollection<ProductMediaFile> ProductMediaFiles
    {
        get => LazyLoader?.Load(this, ref _productMediaFiles) ?? (_productMediaFiles ??= new HashSet<ProductMediaFile>());
        protected set => _productMediaFiles = value;
    }

    private ICollection<ProductCategory>? _productCategories;
    public ICollection<ProductCategory> ProductCategories
    {
        get => LazyLoader?.Load(this, ref _productCategories) ?? (_productCategories ??= new HashSet<ProductCategory>());
        protected set => _productCategories = value;
    }

    // Consider adding ProductLogicalCategory relationship here
    // private ICollection<ProductLogicalCategory>? _productLogicalCategories;
    // public ICollection<ProductLogicalCategory> ProductLogicalCategories { ... }

    private ICollection<ProductProductTag>? _productProductTags;
    public ICollection<ProductProductTag>? ProductProductTags
    {
        get => LazyLoader?.Load(this, ref _productProductTags);
        protected set => _productProductTags = value;
    }

    private ICollection<ProductVariant>? _productVariants;
    public ICollection<ProductVariant>? ProductVariants
    {
        get => LazyLoader?.Load(this, ref _productVariants) ?? (_productVariants ??= new HashSet<ProductVariant>());
        protected set => _productVariants = value;
    }

    public int? ProductTypeId { get; set; }
    private ProductType? _productType;
    public ProductType? ProductType
    {
        get => LazyLoader.Load(this, ref _productType);
        set => _productType = value;
    }

    public int? Rating { get; set; }

    public long? ApiId { get; set; } // Represents SourceProductId
    
    public bool Exist { get; set; } = true;

    public bool Hidden { get; set; } // Might be influenced by Blacklist

    public string Slug => Name.ToSlug() ?? "";

    public string Url => $"Product/{GenderType.ToString()}/{Name.ToSlug()}/{Id}";


    private Dictionary<string, string>? FullDescriptionDict = null;
    public Dictionary<string, string>? GetFullDescriptionObject()
    {
        if (FullDescription is null)
            return null;
        try
        {
            if (FullDescriptionDict is null)
                FullDescriptionDict = JsonSerializer.Deserialize<Dictionary<string, string>>(FullDescription);

            return FullDescriptionDict;
        }
        catch (Exception ex)
        {
            // Log error
            return new Dictionary<string, string>() { { "Info", FullDescription } };
        }

    }

    [StringLength(1000)]
    public string? SiteLink { get; set; }

    public bool Rejected { get; set; }
    
    public DateTime? CreateTime { get; set; } = DateTime.Now;
    public DateTime? PublishDate { get; set; }

    // --- Weight Fields (from previous task) ---

    [Column(TypeName = "decimal(18, 4)")]
    public decimal EstimatedWeightKg { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ActualWeightKg { get; set; }

    public WeightSource WeightSource { get; set; } = WeightSource.Unknown;

    [NotMapped]
    public decimal EffectiveWeightKg => ActualWeightKg ?? EstimatedWeightKg;

    // --- Timestamps ---
    // Inherited CreatedOnUtc, UpdatedOnUtc from BaseEntity

    /// <summary>
    /// Timestamp of when the core product details (non-variant) were last checked/updated from the source.
    /// </summary>
    public DateTime? DetailsLastCheckedUtc { get; set; }

}

