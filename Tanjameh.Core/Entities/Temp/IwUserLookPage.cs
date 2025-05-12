using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserLookPage
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string LookPageProfile { get; set; } = null!;

    public string LookPageBanner { get; set; } = null!;

    public string LookPageName { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public string? LookPageColor { get; set; }

    public int Stat { get; set; }

    public int Enabled { get; set; }

    public int Closet { get; set; }

    public string? LookPageDescription { get; set; }

    public string? AdminComment { get; set; }
}
