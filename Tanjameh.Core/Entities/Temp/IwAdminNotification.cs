using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwAdminNotification
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public int Email { get; set; }

    public int Sms { get; set; }

    public int IwAdminId { get; set; }

    public virtual IwAdmin IwAdmin { get; set; } = null!;
}
