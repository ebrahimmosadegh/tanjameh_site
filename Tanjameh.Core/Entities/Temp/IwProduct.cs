using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProduct
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public int? ProductListId { get; set; }

    public string? Description { get; set; }

    public string? Gender { get; set; }

    public string? ProductCode { get; set; }

    public string? PdpLayout { get; set; }

    public string? SizeGuide { get; set; }

    public string? SizeGuideApiUrl { get; set; }

    public bool? IsNoSize { get; set; }

    public bool? IsOneSize { get; set; }

    public bool? IsInStock { get; set; }

    public string? CountryOfManufacture { get; set; }

    public bool? HasVariantsWithProp65Risk { get; set; }

    public string? ShippingRestriction { get; set; }

    public bool? IsDeadProduct { get; set; }

    public int? Rating { get; set; }

    public int? ProductTypeId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public virtual ICollection<IwBrand> Brands { get; set; } = new List<IwBrand>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    // public virtual ProductType? ProductType { get; set; }

    public virtual ICollection<Variant> Variants { get; set; } = new List<Variant>();
}
