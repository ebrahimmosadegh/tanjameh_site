

using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;


public enum ProductVisibility
{
    /// <summary>
    /// Product is fully visible.
    /// </summary>
    Full = 0,

    /// <summary>
    /// Product is visible in search results.
    /// </summary>
    SearchResults = 10,

    /// <summary>
    /// Product is not visible in lists but clickable on product pages.
    /// </summary>
    ProductPage = 20,

    /// <summary>
    /// Product is not visible but appears on grouped product pages.
    /// </summary>
    Hidden = 30
}

[Flags]
public enum GenderType
{
    [Display(Description = "نا مشخص")]
    None = 0,

    [Display(Description = "زن")]
    Women = 1,

    [Display(Description = "مرد")]
    Men = 2,
}

[Flags]
public enum BannerProductType
{
    None = 0,
    Regular = 1,
    Sale = 2,
    BestSeller = 4,
    MostViewed = 8,
    New = 16
}