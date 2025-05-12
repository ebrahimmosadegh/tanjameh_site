using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProductType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public virtual ICollection<IwProduct> Products { get; set; } = new List<IwProduct>();
}
