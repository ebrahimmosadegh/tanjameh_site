using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserTempCart
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string? SessionId { get; set; }

    public int Qty { get; set; }

    public float? Price { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int? IwUserId { get; set; }

    public int? CurrenciesConversionId { get; set; }

    public string? PromoCode { get; set; }

    public int? ProductId { get; set; }

    public int IwUserShoppingCartId { get; set; }

    public int IwApiProductsId { get; set; }

    public virtual IwUser? IwUser { get; set; }

    public virtual IwUserShoppingCart IwUserShoppingCart { get; set; } = null!;
}
