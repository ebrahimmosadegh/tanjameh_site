namespace Tanjameh.BackgroundServices.ViewModel;


public class AsosProductDetailtResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<LocalisedData>? LocalisedData { get; set; }
    public string? Gender { get; set; }
    public string? ProductCode { get; set; }
    public string? PdpLayout { get; set; }
    public ProductDetailtBrand? Brand { get; set; }
    public string? SizeGuide { get; set; }
    public bool? IsNoSize { get; set; }
    public bool? IsOneSize { get; set; }
    public bool? HasVariantsWithProp65Risk { get; set; }
    public List<ProductDetailtVariant>? Variants { get; set; }
    public ProductDetailtMedia? Media { get; set; }

    //public List<object>? Badges { get; set; }

    public ProductDetailtInfo? Info { get; set; }
    public AssociatedGroups? AssociatedGroups { get; set; }
    //public object ShippingRestriction { get; set; }
    //public object Rating { get; set; }
    public ProductType? ProductType { get; set; }
    public List<PlpId>? PlpIds { get; set; }
    //public object BrandType { get; set; }
    //public object HairType { get; set; }
    //public object SkinType { get; set; }
    public List<object>? SellingTags { get; set; }
    public bool IsDiscontinued { get; set; }
    public string? BaseUrl { get; set; }
}

public class LocalisedData
{
    public string? Locale { get; set; }
    public string? Title { get; set; }
    public string? PdpUrl { get; set; }
}

public class ProductDetailtBrand
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

// Added Price and IsInStock properties
public class ProductDetailtVariant
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public int? SizeId { get; set; }
    public string? BrandSize { get; set; }
    public string? DisplaySizeText { get; set; }
    public int SizeOrder { get; set; }
    public string? Sku { get; set; }
    public bool IsAvailable { get; set; }
    public int? ColourWayId { get; set; }
    public string? Colour { get; set; }
    public bool IsPrimary { get; set; }
    public bool IsProp65Risk { get; set; }
    public ProductDetailtPrice? Price { get; set; } // Added Price property
    public bool IsInStock { get; set; } // Added IsInStock property
    //public object Ean { get; set; }
}

// Added Price structure based on common API patterns
public class ProductDetailtPrice
{
    public PriceInfo? Current { get; set; }
    public PriceInfo? Previous { get; set; }
    public PriceInfo? Rrp { get; set; }
    public bool IsMarkedDown { get; set; }
    public bool IsOutletPrice { get; set; }
    public string? Currency { get; set; }
}

public class PriceInfo
{
    public decimal? Value { get; set; }
    public string? Text { get; set; }
}

public class ProductDetailtMedia
{
    public List<ProductDetailtImage>? Images { get; set; }
    //public List<object>? Catwalk { get; set; }
    //public List<object>? Spinset { get; set; }
    //public List<object>? SwatchSprite { get; set; }
}

public class ProductType
{
    public int? Id { get; set; }
    public string? Name { get; set; }
}

public class ProductDetailtImage
{
    public string? Url { get; set; }
    public string? Type { get; set; }
    public long? ColourWayId { get; set; }
    public string? Colour { get; set; }
    public bool IsPrimary { get; set; }
}

public class ProductDetailtInfo
{
    public string? AboutMe { get; set; }
    public string? SizeAndFit { get; set; }
    public string? CareInfo { get; set; }
}

public class AssociatedGroups
{
    public List<ProductDetailtLook>? Looks { get; set; }
}

public class ProductDetailtLook
{
    public long Id { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
}

public class PlpId
{
    public long Id { get; set; }
    public string? Type { get; set; }
}

