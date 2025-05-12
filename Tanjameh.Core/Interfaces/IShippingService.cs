using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces;

public interface IShippingService
{
    Task<List<ShippingMethod>> GetAvailableShippingMethodsAsync(Address destinationAddress, List<OrderItem> items);
    Task<decimal> CalculateShippingCostAsync(ShippingMethod selectedMethod, Address destinationAddress, List<OrderItem> items);
    // Add other methods as needed, e.g., GetShippingMethodByIdAsync
}
