using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwViewUserCart
{
    public int InvoiceId { get; set; }

    public bool Enabled { get; set; }

    public float? Price { get; set; }

    public DateTime? LastModify { get; set; }

    public int UserId { get; set; }

    public int CurrenciesConversionId { get; set; }

    public int? ProductId { get; set; }

    public int UserShoppingCartId { get; set; }

    public int? ApiProductsId { get; set; }

    public int? UserOrderStatusId { get; set; }

    public int PaymentId { get; set; }

    public string? Size { get; set; }

    public int? UserAddress { get; set; }

    public string Status { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? NationalCode { get; set; }

    public int UserGroupId { get; set; }

    public string? ProductCode { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Images { get; set; }

    public string Url { get; set; } = null!;

    public string? Amount { get; set; }

    public string? TraceNo { get; set; }

    public string? SecurePan { get; set; }

    public string BankName { get; set; } = null!;

    public int CurrenciesId1 { get; set; }

    public int CurrenciesId2 { get; set; }

    public string? SizeText { get; set; }

    public int? SizeOrder { get; set; }

    public string? Colour { get; set; }

    public int CompanyId { get; set; }

    public int? BarcodeNumber { get; set; }

    public int? PackingNumber { get; set; }

    public float? PackingWeight { get; set; }

    public string? TrackingNumber { get; set; }

    public string? CopFile { get; set; }

    public string GroupName { get; set; } = null!;

    public bool SuperUser { get; set; }

    public int CountryId { get; set; }

    public string City { get; set; } = null!;

    public string? UserAddressName { get; set; }

    public string? UserAddressFamily { get; set; }

    public string? UserAddressGender { get; set; }

    public string UserAddressDescription { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string? UserAddressOthertel { get; set; }

    public string CountryName { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public int CompanyCountryId { get; set; }

    public string CompanyCountryName { get; set; } = null!;
}
