using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsiteLogo
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public string? Icon { get; set; }

    public string? LinkTo { get; set; }

    public string Line1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IwWebsitePagesId { get; set; }

    public virtual IwWebsitePage IwWebsitePages { get; set; } = null!;
}
