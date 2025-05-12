using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class ProductList
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public decimal? PriceCurrentValue { get; set; }

    public string? PriceCurrentText { get; set; }

    public decimal? PricePreviousValue { get; set; }

    public string? PricePreviousText { get; set; }

    public decimal? PriceRrpValue { get; set; }

    public string? PriceRrpText { get; set; }

    public bool? IsMarkedDown { get; set; }

    public bool? IsOutletPrice { get; set; }

    public string? Currency { get; set; }

    public string? Colour { get; set; }

    public int? ColourWayId { get; set; }

    public string? BrandName { get; set; }

    public bool? HasVariantColours { get; set; }

    public bool? HasMultiplePrices { get; set; }

    public int? GroupId { get; set; }

    public int? ProductCode { get; set; }

    public string? ProductType { get; set; }

    public string? Url { get; set; }

    public string? ImageUrl { get; set; }

    public string? VideoUrl { get; set; }

    public bool? ShowVideo { get; set; }

    public bool? IsSellingFast { get; set; }

    public int? SponsoredCampaignId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }
}
