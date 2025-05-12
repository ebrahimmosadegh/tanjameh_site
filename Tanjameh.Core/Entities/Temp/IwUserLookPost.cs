using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserLookPost
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int LookGroup { get; set; }

    public int? Itemm1 { get; set; }

    public int? Itemm2 { get; set; }

    public int? Itemm3 { get; set; }

    public int? Itemm4 { get; set; }

    public int? Iteml1 { get; set; }

    public int? Iteml2 { get; set; }

    public int? Iteml3 { get; set; }

    public int? Iteml4 { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int Stat { get; set; }

    public int Enabled { get; set; }

    public string Image1 { get; set; } = null!;

    public string Image2 { get; set; } = null!;

    public string Image3 { get; set; } = null!;

    public string Image4 { get; set; } = null!;

    public string LookGender { get; set; } = null!;

    public string? AdminComment { get; set; }
}
