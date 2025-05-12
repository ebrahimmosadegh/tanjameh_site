using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwApiProduct
{
    public uint Id { get; set; }

    public int Enabled { get; set; }

    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string Name { get; set; } = null!;

    public string? LocalName { get; set; }

    public string UrlGender { get; set; } = null!;

    public string UrlCategory { get; set; } = null!;

    public string UrlGroup { get; set; } = null!;

    public string? UrlGroup2 { get; set; }

    public string? Content { get; set; }

    public string Url { get; set; } = null!;

    public string? ImageSet { get; set; }

    public string ListImageUrl { get; set; } = null!;

    public float? MainPrice { get; set; }

    public float? LastPrice { get; set; }

    public string? CatIds { get; set; }

    public int? AdminOk { get; set; }

    public int NoWeightValue { get; set; }

    public string? Color { get; set; }

    public string? Gender { get; set; }

    public sbyte? IsNoSize { get; set; }

    public sbyte? IsOneSize { get; set; }

    public sbyte? IsInStock { get; set; }

    public sbyte? Prop65Risk { get; set; }

    public string? Info { get; set; }

    public sbyte? IsDeadProduct { get; set; }

    public float? Rating { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int? IwApiProductTypeId { get; set; }

    public int? IwApiBrandsId { get; set; }

    public int IwCompanyId { get; set; }

    public int? IwProductWeightId { get; set; }

    public virtual IwApiBrand? IwApiBrands { get; set; }

    public virtual IwApiProductType? IwApiProductType { get; set; }

    public virtual ICollection<IwApiProductVariant> IwApiProductVariants { get; set; } = new List<IwApiProductVariant>();

    public virtual IwCompany IwCompany { get; set; } = null!;
}
