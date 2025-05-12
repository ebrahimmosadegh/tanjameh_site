using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwAdminObserver
{
    public uint Id { get; set; }

    public byte? Online { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwAdminId { get; set; }

    public virtual IwAdmin IwAdmin { get; set; } = null!;
}
