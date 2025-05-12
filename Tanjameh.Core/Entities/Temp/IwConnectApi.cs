using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwConnectApi
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public int? AllCount { get; set; }

    public string ExpireDate { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public int IwCompanyId { get; set; }

    public virtual IwCompany IwCompany { get; set; } = null!;
}
