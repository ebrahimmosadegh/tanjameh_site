using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserPacking
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string PackingIdKey { get; set; } = null!;

    public string PaymentIdKey { get; set; } = null!;

    public string? ProductId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductSizeId { get; set; }

    public string? Size { get; set; }

    public string? Count { get; set; }

    public string ChkState { get; set; } = null!;

    public string? OrderNu { get; set; }

    public string? PackWeight { get; set; }

    public string? TrackingNu { get; set; }

    public string? UserAddressId { get; set; }

    public string? Description { get; set; }

    public string ModifyIp { get; set; } = null!;

    public string ModifyTime { get; set; } = null!;

    public string ModifyDate { get; set; } = null!;

    public string ModifyStrTime { get; set; } = null!;

    public int IwUserId { get; set; }

    public int IwUserShoppingCartId { get; set; }

    public int IwUserShopOrderId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual IwUserShopOrder IwUserShopOrder { get; set; } = null!;

    public virtual IwUserShoppingCart IwUserShoppingCart { get; set; } = null!;
}
