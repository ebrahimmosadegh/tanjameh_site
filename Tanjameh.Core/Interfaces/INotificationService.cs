using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces;

/// <summary>
/// Service responsible for handling notifications to users about relevant events.
/// </summary>
public interface INotificationService
{
    /// <summary>
    /// Notifies relevant users about a price change for a specific product variant.
    /// </summary>
    /// <param name="variant">The product variant whose price changed.</param>
    /// <param name="oldPrice">The previous price.</param>
    /// <param name="newPrice">The new price.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task NotifyPriceChangeAsync(ProductVariant variant, decimal oldPrice, decimal newPrice);

    /// <summary>
    /// Notifies relevant users about a stock level change for a specific product variant.
    /// </summary>
    /// <param name="variant">The product variant whose stock changed.</param>
    /// <param name="oldStock">The previous stock level.</param>
    /// <param name="newStock">The new stock level.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task NotifyStockChangeAsync(ProductVariant variant, int oldStock, int newStock);

    // Add other notification methods as needed, e.g., for new promotions, order status updates, etc.
}
