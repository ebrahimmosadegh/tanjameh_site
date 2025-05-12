using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserShoppingMethod
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public virtual ICollection<IwUserShopOrder> IwUserShopOrders { get; set; } = new List<IwUserShopOrder>();
}
