using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwAdminStatus
{
    public int AllCountEnter { get; set; }

    public int IwAdminId { get; set; }

    public virtual IwAdmin IwAdmin { get; set; } = null!;
}
