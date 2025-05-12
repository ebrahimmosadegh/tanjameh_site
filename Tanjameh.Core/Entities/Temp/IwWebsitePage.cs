using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsitePage
{
    public int Id { get; set; }

    public string IdKey { get; set; } = null!;

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwWebsiteInfoId { get; set; }

    public virtual ICollection<IwStatusView> IwStatusViews { get; set; } = new List<IwStatusView>();

    public virtual IwWebsiteInfo IwWebsiteInfo { get; set; } = null!;

    public virtual ICollection<IwWebsiteLogo> IwWebsiteLogos { get; set; } = new List<IwWebsiteLogo>();

    public virtual ICollection<IwWebsitePagesPart> IwWebsitePagesParts { get; set; } = new List<IwWebsitePagesPart>();
}
