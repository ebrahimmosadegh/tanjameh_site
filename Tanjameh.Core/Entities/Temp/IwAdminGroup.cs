using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwAdminGroup
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public bool SuperAdmin { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public virtual ICollection<IwAdminAccess> IwAdminAccesses { get; set; } = new List<IwAdminAccess>();

    public virtual ICollection<IwAdmin> IwAdmins { get; set; } = new List<IwAdmin>();
}
