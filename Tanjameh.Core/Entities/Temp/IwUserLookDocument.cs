using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserLookDocument
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string IdCartFront { get; set; } = null!;

    public string IdCartBack { get; set; } = null!;

    public string UserFace { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int Stat { get; set; }

    public int Enabled { get; set; }

    public string? AdminComment { get; set; }
}
