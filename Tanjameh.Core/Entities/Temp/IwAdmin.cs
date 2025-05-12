using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwAdmin
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IwAdminGroupId { get; set; }

    public virtual IwAdminGroup IwAdminGroup { get; set; } = null!;

    public virtual ICollection<IwAdminNotification> IwAdminNotifications { get; set; } = new List<IwAdminNotification>();

    public virtual ICollection<IwAdminObserver> IwAdminObservers { get; set; } = new List<IwAdminObserver>();

    public virtual ICollection<IwAdminProfile> IwAdminProfiles { get; set; } = new List<IwAdminProfile>();
}
