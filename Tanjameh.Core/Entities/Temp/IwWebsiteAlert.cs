using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsiteAlert
{
    public int Id { get; set; }

    public string IdKey { get; set; } = null!;

    public bool? Enabled { get; set; }

    public string AlertName { get; set; } = null!;

    public string AlertType { get; set; } = null!;

    public string AlertContent { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public int IwWebsiteInfoId { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public virtual IwWebsiteInfo IwWebsiteInfo { get; set; } = null!;
}
