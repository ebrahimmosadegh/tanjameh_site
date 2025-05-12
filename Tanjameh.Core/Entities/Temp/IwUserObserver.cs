using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserObserver
{
    public uint Id { get; set; }

    public byte? Online { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwUserId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;
}
