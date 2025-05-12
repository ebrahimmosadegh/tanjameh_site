using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserShoppingCart
{
    public int Id { get; set; }

    public int IwUserId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int? IwUserAddress { get; set; }

    public int? IwUserOrderStatusId { get; set; }

    public virtual ICollection<IwPaymentState> IwPaymentStates { get; set; } = new List<IwPaymentState>();

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual ICollection<IwUserPacking> IwUserPackings { get; set; } = new List<IwUserPacking>();

    public virtual ICollection<IwUserTempCart> IwUserTempCarts { get; set; } = new List<IwUserTempCart>();
}
