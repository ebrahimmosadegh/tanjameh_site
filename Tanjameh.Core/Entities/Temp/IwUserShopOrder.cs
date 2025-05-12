using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserShopOrder
{
    public int Id { get; set; }

    public int OrderTotal { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwUserId { get; set; }

    public int IwUserPaymentMethodId { get; set; }

    public int IwUserAddressDetailsId { get; set; }

    public int IwUserShoppingMethodId { get; set; }

    public int IwUserOrderStatusId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual IwUserAddressDetail IwUserAddressDetails { get; set; } = null!;

    public virtual IwUserOrderStatus IwUserOrderStatus { get; set; } = null!;

    public virtual ICollection<IwUserPacking> IwUserPackings { get; set; } = new List<IwUserPacking>();

    public virtual IwUserPaymentMethod IwUserPaymentMethod { get; set; } = null!;

    public virtual IwUserShoppingMethod IwUserShoppingMethod { get; set; } = null!;
}
