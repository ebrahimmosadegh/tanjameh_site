using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsiteTitleAdver
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string ConditionStatement { get; set; } = null!;

    public string BottomCaption { get; set; } = null!;

    public string? BottomLink { get; set; }

    public string MainColor { get; set; } = null!;

    public string SecondColor { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwWebPagesPartId { get; set; }
}
