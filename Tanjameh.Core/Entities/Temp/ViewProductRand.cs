using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class ViewProductRand
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string UrlGender { get; set; } = null!;

    public string UrlCategory { get; set; } = null!;

    public string UrlGroup { get; set; } = null!;

    public string? CatIds { get; set; }

    public string? Color { get; set; }

    public string? Content { get; set; }

    public string? ImageSet { get; set; }

    public float? MainPrice { get; set; }

    public float? LastPrice { get; set; }

    public int? ProductTypeId { get; set; }

    public int? BrandsId { get; set; }

    public int CompanyId { get; set; }

    public int? Sale { get; set; }
}
