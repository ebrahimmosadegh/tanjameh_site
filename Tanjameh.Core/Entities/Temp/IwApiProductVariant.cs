using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwApiProductVariant
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string? Name { get; set; }

    public int? SizeId { get; set; }

    public string? BrandSize { get; set; }

    public string? SizeDescription { get; set; }

    public string? DisplaySizeText { get; set; }

    public int? SizeOrder { get; set; }

    public sbyte? IsInStock { get; set; }

    public sbyte? IsAvailable { get; set; }

    public string? Colour { get; set; }

    public float? PriceCurrent { get; set; }

    public float? PricePrevious { get; set; }

    public sbyte? IsProp65Risk { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public uint IwApiProductsId { get; set; }

    public int IwCompanyId { get; set; }

    public virtual IwApiProduct IwApiProducts { get; set; } = null!;

    public virtual ICollection<IwUserOrderLine> IwUserOrderLines { get; set; } = new List<IwUserOrderLine>();
}
