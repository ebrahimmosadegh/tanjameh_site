using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces; // Corrected: Interfaces are likely in Core
using Tanjameh.Infrastructure.Data;
// Removed incorrect using statements for Features namespaces

namespace Tanjameh.Infrastructure.Services;
// Removed duplicate namespace declaration

/// <summary>
/// Basic implementation of the notification service. Logs notifications to the console.
/// </summary>
public class NotificationService : INotificationService
{
    private readonly ILogger<NotificationService> _logger;
    private readonly IFavoriteService _favoriteService; // Assuming IFavoriteService exists in Core.Interfaces
    private readonly IShoppingCartService _shoppingCartService; // Assuming IShoppingCartService exists in Core.Interfaces
    private readonly ApplicationDbContext _context; // Keep context if needed for other things, but don't use for fav/cart lookups here

    // Constructor needs ApplicationDbContext if other methods use it, otherwise remove.
    // Assuming it might be needed elsewhere or was planned, keep it for now.
    public NotificationService(ILogger<NotificationService> logger, IFavoriteService favoriteService, IShoppingCartService shoppingCartService, ApplicationDbContext context)
    {
        _logger = logger;
        _favoriteService = favoriteService;
        _shoppingCartService = shoppingCartService;
        _context = context; // Assign context
    }

    public async Task NotifyPriceChangeAsync(ProductVariant variant, decimal oldPrice, decimal newPrice)
    {
        // Only notify if the price has dropped
        if (newPrice < oldPrice)
        {
            _logger.LogInformation($"Price drop detected for Variant ID {variant.Id} (Product ID: {variant.ProductId}). Old: {oldPrice}, New: {newPrice}");

            // Find users who have this variant in their favorites or cart using injected services
            var userIdsFromFavorites = await _favoriteService.GetUserIdsWithFavoriteVariantAsync(variant.Id);
            var userIdsFromCarts = await _shoppingCartService.GetUserIdsWithCartItemVariantAsync(variant.Id);

            var userIdsToNotify = userIdsFromFavorites.Union(userIdsFromCarts).ToList();

            if (userIdsToNotify.Any())
            {
                _logger.LogInformation($"Found {userIdsToNotify.Count} users interested in Variant ID {variant.Id}.");
                foreach (var userId in userIdsToNotify)
                {
                    // TODO: Implement actual notification sending (e.g., email, SignalR)
                    _logger.LogInformation($"---> Sending price drop notification to User ID {userId} for Variant ID {variant.Id}.");
                }
            }
            else
            {
                _logger.LogInformation($"No users found with Variant ID {variant.Id} in favorites or cart.");
            }
        }
    }

    public async Task NotifyStockChangeAsync(ProductVariant variant, int oldStock, int newStock)
    {
        // Notify if the item comes back in stock
        if (oldStock <= 0 && newStock > 0)
        {
            _logger.LogInformation($"Restock detected for Variant ID {variant.Id} (Product ID: {variant.ProductId}). Old: {oldStock}, New: {newStock}");

            // Find users who have this variant in their favorites or cart using injected services
            // Corrected: Use injected services instead of direct context access
            var userIdsFromFavorites = await _favoriteService.GetUserIdsWithFavoriteVariantAsync(variant.Id);
            var userIdsFromCarts = await _shoppingCartService.GetUserIdsWithCartItemVariantAsync(variant.Id);

            var userIdsToNotify = userIdsFromFavorites.Union(userIdsFromCarts).ToList();

            if (userIdsToNotify.Any())
            {
                 _logger.LogInformation($"Found {userIdsToNotify.Count} users interested in Variant ID {variant.Id}.");
               foreach (var userId in userIdsToNotify)
                {
                    // TODO: Implement actual notification sending
                    _logger.LogInformation($"---> Sending restock notification to User ID {userId} for Variant ID {variant.Id}.");
                    // Example: await _emailSender.SendEmailAsync(userEmail, "Back in Stock!", $"{variant.Product.Name} - {variant.Name} is back in stock!");
                }
            }
             else
            {
                _logger.LogInformation($"No users found with Variant ID {variant.Id} in favorites or cart.");
            }
        }
        // Could add notifications for low stock as well
    }
}

