
using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;


public class Banner
{
    public int Id { get; init; }

    [StringLength(255)]
    public string Text { get; set; } = string.Empty;

    [StringLength(5000)]
    public string? Description { get; set; }

    [StringLength(2083)]
    public string? ImageUrl { get; set; }

    [StringLength(2083)]

    public string Link { get; set; } = string.Empty;

    [StringLength(255)]
    public string TextLink { get; set; } = string.Empty;

    [StringLength(50)]
    public string MainColor { get; set; } = string.Empty;

    [StringLength(50)]
    public string SecondaryColor { get; set; } = string.Empty;

    //json map
    public BannerInfo BannerInfo { get; set; } = new BannerInfo();

    public int DisplayOrder { get; set; } = 0;

    public int TemplateId { get; set; } = 1;

    [StringLength(2083)]
    public string BaseUrl { get; set; } = string.Empty;
}

public class BannerInfo
{
    public int Take { get; set; } = 9;

    public GenderType? GenderType { get; set; }

    public BannerProductType? BannerProductType { get; set; }

    public string? Filter { get; set; }
    //Category
}

