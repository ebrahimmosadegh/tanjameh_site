using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces;

public interface IOrderService
{
    Task<Order?> CreateOrderAsync(long userId, int shippingAddressId, int? billingAddressId, List<OrderItem> items);
    Task<Order?> GetOrderByIdAsync(long orderId);
    Task<List<Order>> GetOrdersForUserAsync(long userId);
    // Add other necessary methods like UpdateOrderStatusAsync, etc.
}
