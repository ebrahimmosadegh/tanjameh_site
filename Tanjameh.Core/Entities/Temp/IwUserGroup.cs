using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserGroup
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public bool SuperUser { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public virtual ICollection<IwUserAccess> IwUserAccesses { get; set; } = new List<IwUserAccess>();

    public virtual ICollection<IwUser> IwUsers { get; set; } = new List<IwUser>();
}
