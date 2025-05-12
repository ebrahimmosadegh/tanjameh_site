using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Infrastructure.Services;

public class OrderService : IOrderService
{
    private readonly ApplicationDbContext _context;
    private readonly IShippingService _shippingService; // Inject Shipping Service
    private readonly IPaymentService _paymentService;   // Inject Payment Service

    public OrderService(ApplicationDbContext context, IShippingService shippingService, IPaymentService paymentService)
    {
        _context = context;
        _shippingService = shippingService; // Assign injected service
        _paymentService = paymentService;   // Assign injected service
    }

    public async Task<Order?> CreateOrderAsync(long userId, int shippingAddressId, int? billingAddressId, List<OrderItem> items)
    {
        // Basic validation (can be expanded)
        if (items == null || !items.Any())
        {
            return null; // Or throw an exception
        }

        // Retrieve the shipping address entity (needed for shipping calculation)
        // Note: This might fail if the Address entity with the given ID doesn't exist.
        var shippingAddress = await _context.Addresses.FindAsync(shippingAddressId);
        if (shippingAddress == null)
        {
            // Handle error: Invalid shipping address ID
            throw new ArgumentException("Invalid shipping address ID.", nameof(shippingAddressId));
        }

        // Calculate subtotal (assuming PriceAtTimeOfOrder is set correctly in items)
        var subtotal = items.Sum(item => item.PriceAtTimeOfOrder * item.Quantity);

        // Get available shipping methods (simplified: gets all enabled methods)
        // In a real scenario, this might depend on the address and items
        var availableMethods = await _shippingService.GetAvailableShippingMethodsAsync(shippingAddress, items);
        if (!availableMethods.Any())
        {
            // Handle error: No shipping methods available
            throw new InvalidOperationException("No shipping methods available for the given order.");
        }

        // Select a shipping method (simplified: use the first available one)
        // In a real checkout process, the user would select this.
        var selectedMethod = availableMethods.First();

        // Calculate shipping cost using the shipping service
        var shippingCost = await _shippingService.CalculateShippingCostAsync(selectedMethod, shippingAddress, items);

        var totalAmount = subtotal + shippingCost;

        var order = new Order
        {
            UserId = userId,
            ShippingAddressId = shippingAddressId,
            BillingAddressId = billingAddressId ?? shippingAddressId, // Default to shipping if billing not provided
            OrderDate = DateTime.UtcNow,
            Subtotal = subtotal,
            ShippingCost = shippingCost, // Use calculated cost
            TotalAmount = totalAmount,
            Status = Core.Enums.OrderStatus.Pending, // Use the enum from Core
            OrderItems = items
            // PaymentIntentId will be set after creation
            // TODO: Store the selected ShippingMethodId in the Order entity if needed
        };

        _context.Orders.Add(order);

        // Create or update Stripe Payment Intent *before* saving the order initially
        // This ensures the PaymentIntentId is associated with the order record.
        try
        {
            var paymentIntent = await _paymentService.CreateOrUpdatePaymentIntent(order);
            if (paymentIntent != null)
            {
                order.PaymentIntentId = paymentIntent.Id;
            }
            else
            {
                // Handle error: Payment Intent creation failed
                // Maybe log and proceed without PaymentIntentId, or throw an exception
                Console.WriteLine($"Error: Failed to create/update Payment Intent for potential Order.");
                // Depending on requirements, might need to prevent order creation here.
            }
        }
        catch (Exception ex)
        {
            // Log the exception from payment service
            Console.WriteLine($"Error creating/updating Payment Intent: {ex.Message}");
            // Decide how to proceed - potentially prevent order creation
            return null; // Or rethrow
        }

        // Save the order (including the PaymentIntentId) to the database
        // Note: This will still fail until the database migration is applied and the connection works.
        try
        {
            await _context.SaveChangesAsync();
            return order;
        }
        catch (DbUpdateException ex)
        {
            // Log the exception (implement proper logging)
            Console.WriteLine($"Error creating order: {ex.Message}"); 
            // Handle the error appropriately - maybe return null or rethrow
            // Consider if the Payment Intent should be cancelled if order saving fails.
            return null;
        }
    }

    public async Task<Order?> GetOrderByIdAsync(long orderId)
    {
        // Include related entities as needed
        return await _context.Orders
                             .Include(o => o.OrderItems) // Include OrderItems
                             // .Include(o => o.ShippingAddress) // Cannot include directly as navigation property removed
                             // .Include(o => o.BillingAddress)  // Cannot include directly as navigation property removed
                             .FirstOrDefaultAsync(o => o.Id == orderId);
        // Need separate queries to get Address details based on IDs if required
    }

    public async Task<List<Order>> GetOrdersForUserAsync(long userId)
    {
        return await _context.Orders
                             .Where(o => o.UserId == userId)
                             .Include(o => o.OrderItems)
                             .OrderByDescending(o => o.OrderDate)
                             .ToListAsync();
        // Need separate queries to get Address details based on IDs if required
    }

    // TODO: Implement other methods like UpdateOrderStatusAsync
}
