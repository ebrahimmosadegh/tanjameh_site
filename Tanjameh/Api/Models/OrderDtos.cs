using Tanjameh.Core.Enums;

namespace Tanjameh.Api.Models.Orders;

public class OrderItemDto
{
    public int ProductId { get; set; }
    public int VariantId { get; set; }
    public string? ProductName { get; set; } // Need to fetch this
    public string? VariantName { get; set; } // Need to fetch this
    public decimal PriceAtTimeOfOrder { get; set; }
    public int Quantity { get; set; }
    public string? ImageUrl { get; set; } // Need to fetch this
}

public class OrderSummaryDto
{
    public long Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public int ItemCount { get; set; }
}

public class OrderDetailDto
{
    public long Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Subtotal { get; set; }
    public decimal ShippingCost { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public AddressDto? ShippingAddress { get; set; } // Need to fetch this
    public AddressDto? BillingAddress { get; set; } // Need to fetch this
    public List<OrderItemDto> Items { get; set; } = new();
    public string? PaymentIntentId { get; set; } // For client-side payment confirmation if needed
    // Add ShippingMethod details if required
}

public class AddressDto
{
    public int Id { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
}

// DTO for creating an order via API (might differ from Blazor checkout)
public class CreateOrderRequestDto
{
    public int ShippingAddressId { get; set; }
    public int? BillingAddressId { get; set; }
    public int ShippingMethodId { get; set; } // User selects shipping method via API
    // Items might be implicitly taken from the user's cart, or passed explicitly
    // public List<CreateOrderItemDto> Items { get; set; } = new();
}

// public class CreateOrderItemDto
// {
//     public int VariantId { get; set; }
//     public int Quantity { get; set; }
// }

