using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsitePagesPart
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

    public int IwWebsitePagesId { get; set; }

    public virtual ICollection<IwWebsiteBannerAdver> IwWebsiteBannerAdvers { get; set; } = new List<IwWebsiteBannerAdver>();

    public virtual IwWebsitePage IwWebsitePages { get; set; } = null!;

    public virtual ICollection<IwWebsiteSpAdver> IwWebsiteSpAdvers { get; set; } = new List<IwWebsiteSpAdver>();
}
