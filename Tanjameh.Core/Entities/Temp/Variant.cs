using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class Variant
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? SizeId { get; set; }

    public string? BrandSize { get; set; }

    public string? SizeDescription { get; set; }

    public string? DisplaySizeText { get; set; }

    public int? SizeOrder { get; set; }

    public string? Sku { get; set; }

    public bool? IsLowInStock { get; set; }

    public bool? IsInStock { get; set; }

    public bool? IsAvailable { get; set; }

    public int? ColourWayId { get; set; }

    public decimal? PriceCurrentValue { get; set; }

    public string? PriceCurrentText { get; set; }

    public string? Currency { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsProp65Risk { get; set; }

    public string? Ean { get; set; }

    public string? Seller { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public virtual IwProduct? Product { get; set; }
}
