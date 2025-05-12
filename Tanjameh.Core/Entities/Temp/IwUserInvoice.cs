using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserInvoice
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public int UserId { get; set; }

    public int ShoppingCartId { get; set; }

    public int PaymentId { get; set; }

    public int? ProductId { get; set; }

    public string? Size { get; set; }

    public float? Price { get; set; }

    public int? IwUserAddress { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int CurrenciesConversionId { get; set; }

    public int? UserOrderStatusId { get; set; }

    public int? ApiProductsId { get; set; }

    public string? PromoCode { get; set; }
}
