using Tanjameh.Core.Entities;

namespace Tanjameh.Features.BrandAndType;

public static class ExtentionMethods
{

    public static string ToUrl(this ProductType productType)
    {
        return "trend/" + productType.Slug;
    }

    public static string ToUrl(this CatalogBrand brand)
    {
        return "brand/" + brand.Slug;
    }
}
