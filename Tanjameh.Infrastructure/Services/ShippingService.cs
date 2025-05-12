using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Infrastructure.Services;

public class ShippingService : IShippingService
{
    private readonly ApplicationDbContext _context;

    public ShippingService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ShippingMethod>> GetAvailableShippingMethodsAsync(Address destinationAddress, List<OrderItem> items)
    {
        // Basic implementation: Return all enabled shipping methods.
        // TODO: Implement more complex logic based on destination (zones), item weight/dimensions, etc.
        return await _context.ShippingMethods.Where(sm => sm.IsEnabled).ToListAsync();
    }

    public async Task<decimal> CalculateShippingCostAsync(ShippingMethod selectedMethod, Address destinationAddress, List<OrderItem> items)
    {
        // Basic implementation: Return the base cost of the selected method.
        // TODO: Implement more complex logic based on weight, distance, item count, etc.
        
        // Ensure the method exists and is enabled (optional, could be checked earlier)
        var method = await _context.ShippingMethods.FirstOrDefaultAsync(sm => sm.Id == selectedMethod.Id && sm.IsEnabled);
        
        if (method == null)
        {
            // Handle error: Invalid or disabled shipping method selected
            throw new ArgumentException("Invalid or disabled shipping method selected.", nameof(selectedMethod));
        }

        // Return the base cost for now
        return method.Cost;
    }

    // TODO: Implement GetShippingMethodByIdAsync if needed
}
