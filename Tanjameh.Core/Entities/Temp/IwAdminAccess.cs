using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwAdminAccess
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string AllAccess { get; set; } = null!;

    public string AllTools { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwAdminGroupId { get; set; }

    public virtual IwAdminGroup IwAdminGroup { get; set; } = null!;
}
