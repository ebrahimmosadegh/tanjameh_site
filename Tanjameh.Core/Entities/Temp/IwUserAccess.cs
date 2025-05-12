using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserAccess
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string AllAccess { get; set; } = null!;

    public string AllTools { get; set; } = null!;

    public string? AllTrade { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwUserGroupId { get; set; }

    public virtual IwUserGroup IwUserGroup { get; set; } = null!;
}
