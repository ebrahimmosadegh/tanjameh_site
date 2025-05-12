using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwShippingProduct
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int CartId { get; set; }

    public string Size { get; set; } = null!;

    public int AddressId { get; set; }

    public int? BarcodeNumber { get; set; }

    public int? PackingNumber { get; set; }

    public float? PackingWeight { get; set; }

    public string? PackingDescription { get; set; }

    public string? TrackingNumber { get; set; }

    public string? CopFile { get; set; }

    public int? InvoiceId { get; set; }
}
