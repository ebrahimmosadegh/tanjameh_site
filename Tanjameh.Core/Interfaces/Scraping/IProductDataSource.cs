using System.Threading.Tasks;
using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces.Scraping
{
    /// <summary>
    /// Defines the contract for a service that fetches comprehensive product details 
    /// from a specific external source for initial import or full refresh.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: To retrieve all necessary product information (details, variants, images, etc.) 
    ///          from a source, typically used for creating new product entries in the database.
    /// Usage: Called during batch import processes or manual full product refreshes.
    /// Developer Notes: Implementations should handle source-specific API calls or web scraping logic.
    ///                The returned DTO should contain all data needed to populate Product and related entities.
    /// </remarks>
    public interface IProductGrabber
    {
        /// <summary>
        /// Gets the unique identifier for the data source this grabber handles (e.g., "ASOS", "ZALANDO", "NEXT").
        /// </summary>
        string SourceName { get; }

        /// <summary>
        /// Fetches the full product details from the source using the product's source-specific ID.
        /// </summary>
        /// <param name="sourceProductId">The unique identifier of the product on the external source platform.</param>
        /// <returns>
        /// A Task representing the asynchronous operation. The task result contains a DTO 
        /// representing the full product details, or null if the product could not be found or fetched.
        /// </returns>
        Task<object?> GrabProductDetailsAsync(string sourceProductId); // Return type object? for now, define specific DTOs later
    }

    /// <summary>
    /// Defines the contract for a service that fetches lightweight price and availability 
    /// updates for a product variant from a specific external source.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: To quickly check and retrieve the current price and stock status for a specific product variant (size/color).
    ///          Used for scheduled background updates and real-time validation during user interactions.
    /// Usage: Called frequently by the background update job and during Add-to-Basket/Checkout validation.
    /// Developer Notes: Implementations should be optimized for speed, fetching only the essential price/availability data.
    ///                Requires identifiers for both the product and the specific variant on the source platform.
    /// </remarks>
    public interface IProductUpdater
    {
        /// <summary>
        /// Gets the unique identifier for the data source this updater handles (e.g., "ASOS", "ZALANDO", "NEXT").
        /// </summary>
        string SourceName { get; }

        /// <summary>
        /// Fetches the current price and availability for a specific product variant from the source.
        /// </summary>
        /// <param name="sourceProductId">The unique identifier of the product on the external source platform.</param>
        /// <param name="sourceVariantId">The unique identifier of the specific variant (size/color) on the external source platform.</param>
        /// <returns>
        /// A Task representing the asynchronous operation. The task result contains a DTO 
        /// with the latest price and availability status, or null if the variant could not be found or updated.
        /// </returns>
        Task<object?> UpdateVariantPriceAvailabilityAsync(string sourceProductId, string sourceVariantId); // Return type object? for now, define specific DTOs later
    }
}

