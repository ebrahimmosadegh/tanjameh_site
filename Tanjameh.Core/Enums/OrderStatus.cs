namespace Tanjameh.Core.Enums;

public enum OrderStatus
{
    Pending,       // Order created, awaiting payment
    Processing,    // Payment received, order being processed
    Shipped,       // Order shipped to customer
    Delivered,     // Order delivered to customer
    Cancelled,     // Order cancelled
    PaymentFailed  // Payment attempt failed
}
