using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserLookGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int Enabled { get; set; }

    public string Root { get; set; } = null!;
}
