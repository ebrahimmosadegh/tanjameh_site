using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserDispatch
{
    public int Id { get; set; }

    public string IdKey { get; set; } = null!;

    public bool Enabled { get; set; }

    public string UserIdKey { get; set; } = null!;

    public string BasketIdKey { get; set; } = null!;

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

    public string? UserAddressId { get; set; }

    public string? Description { get; set; }

    public string ModifyIp { get; set; } = null!;

    public string ModifyTime { get; set; } = null!;

    public string ModifyDate { get; set; } = null!;

    public string ModifyStrTime { get; set; } = null!;
}
