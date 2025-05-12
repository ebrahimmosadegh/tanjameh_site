using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwViewProductNotCheck
{
    public uint? Id { get; set; }

    public int? Enabled { get; set; }

    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? Name { get; set; }

    public string? LocalName { get; set; }

    public string? UrlGender { get; set; }

    public string? UrlCategory { get; set; }

    public string? UrlGroup { get; set; }

    public string? UrlGroup2 { get; set; }

    public string? Content { get; set; }

    public string? ImageSet { get; set; }

    public int? AdminOk { get; set; }

    public string? Url { get; set; }

    public int? NoWeightValue { get; set; }

    public int? IwApiProductTypeId { get; set; }

    public int? IwApiBrandsId { get; set; }

    public int? IwCompanyId { get; set; }
}
