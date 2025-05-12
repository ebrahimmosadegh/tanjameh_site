using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwBrand
{
    public int Id { get; set; }

    public int? BrandId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public virtual IwProduct? Product { get; set; }
}
