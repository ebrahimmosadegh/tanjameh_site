// User Customer for shopping entities

using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

//todo log each change in customer order
public class LegacyCustomerOrder // Renamed from CustomerOrder
{
    public int Id { get; set; }
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public LegacyOrderStatus Status { get; set; } // Renamed from OrderStatus
    public ICollection<LegacyOrderItem> OrderItems { get; set; } = new List<LegacyOrderItem>(); // Renamed from OrderItem
    public ShippingInfo ShippingInfo { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? CreatedTime { get; set; }
    public DateTime? LastModify { get; set; }

    [StringLength(5000)]
    public string? Comments { get; set; }
    
    [StringLength(100)]
    public string? CustomOrderId { get; set; }
}

public class LegacyOrderItem // Renamed from OrderItem
{
    public int Id { get; set; }
    public int CustomerOrderId { get; set; }
    public LegacyCustomerOrder CustomerOrder { get; set; } // Renamed from CustomerOrder
    public int ProductId { get; set; }
    public int? ProductVariantId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;

    public decimal? ExchangeRateTime { get; set; }
    public int? CurrencyId { get; set; }

    [StringLength(5000)]
    public string? Comments { get; set; }
    
    [StringLength(100)]
    public string? CustomItemOrderId { get; set; }
    
    public LegacyPackage? Package { get; set; } // Renamed from Package
    public int? PackageId { get; set; }
}

public class LegacyPackage // Renamed from Package
{
    public int Id { get; set; }
    public int PackageId { get; set; }
    
    public List<LegacyOrderItem> OrderItem { get; set; } = new List<LegacyOrderItem>(); // Renamed from OrderItem
    
    public int StatusId { get; set; }
    
    public WeightSource? Weight { get; set; }
    public int? WeightId { get; set; }
    
}

public enum LegacyOrderStatus // Renamed from OrderStatus
{
    Pending = 0,
    Payed = 5,
    Processing = 10,
    Packaging = 15,
    Shipped = 20,
    Delivered = 25,
    Cancelled = -1
}