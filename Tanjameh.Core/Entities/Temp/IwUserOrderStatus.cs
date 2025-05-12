using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserOrderStatus
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<IwUserShopOrder> IwUserShopOrders { get; set; } = new List<IwUserShopOrder>();
}
