using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class Image
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public string? Type { get; set; }

    public bool? IsPrimary { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }
}
