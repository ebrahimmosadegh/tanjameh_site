using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserPaymentMethod
{
    public int Id { get; set; }

    public string? Provider { get; set; }

    public string AccountNumber { get; set; } = null!;

    public DateTime ExpiryDate { get; set; }

    public int IsDefault { get; set; }

    public int IwUserId { get; set; }

    public int IwUserPaymentTypeId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual IwUserPaymentType IwUserPaymentType { get; set; } = null!;

    public virtual ICollection<IwUserShopOrder> IwUserShopOrders { get; set; } = new List<IwUserShopOrder>();
}
