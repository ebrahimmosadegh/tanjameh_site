using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwApiProductType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int? ProductTypeId { get; set; }

    public int? IwProductWeightId { get; set; }

    public virtual ICollection<IwApiProduct> IwApiProducts { get; set; } = new List<IwApiProduct>();
}
