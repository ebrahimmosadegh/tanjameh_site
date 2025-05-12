using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserAddress
{
    public int IwUserId { get; set; }

    public bool IsDefault { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwUserAddressDetailsId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual IwUserAddressDetail IwUserAddressDetails { get; set; } = null!;
}
