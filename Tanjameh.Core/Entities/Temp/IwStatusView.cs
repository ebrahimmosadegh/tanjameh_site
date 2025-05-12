using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwStatusView
{
    public int Id { get; set; }

    public int? AllCount { get; set; }

    public string ExpireDate { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwWebsitePagesId { get; set; }

    public virtual IwWebsitePage IwWebsitePages { get; set; } = null!;
}
