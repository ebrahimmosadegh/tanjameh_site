using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsiteInfo
{
    public int Id { get; set; }

    public string IdKey { get; set; } = null!;

    public bool? Enabled { get; set; }

    public string Email { get; set; } = null!;

    public string MainPhone { get; set; } = null!;

    public string WebsiteTitle { get; set; } = null!;

    public string WebsiteName { get; set; } = null!;

    public string WebsiteAddress { get; set; } = null!;

    public string Company { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public virtual ICollection<IwWebsiteAlert> IwWebsiteAlerts { get; set; } = new List<IwWebsiteAlert>();

    public virtual ICollection<IwWebsitePage> IwWebsitePages { get; set; } = new List<IwWebsitePage>();
}
