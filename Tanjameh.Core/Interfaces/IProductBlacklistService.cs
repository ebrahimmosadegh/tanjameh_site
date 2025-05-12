using System.Threading.Tasks;
using Tanjameh.Core.Dtos.Scraping; // For checking source data before import
using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Defines the contract for a service that checks if a product should be blacklisted.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: To determine if a product matches any defined blacklist rules based on keywords, tags, or other criteria.
    /// Usage: Called during product import (Grabber) to prevent unwanted items from entering the system, 
    ///        and potentially during product updates or display logic to hide existing blacklisted items.
    /// Developer Notes: Implementations should load and evaluate ProductBlacklistRule entities from the database.
    ///                The logic should be flexible to support different rule types.
    /// </remarks>
    public interface IProductBlacklistService
    {
        /// <summary>
        /// Checks if a product, based on its source data, matches any active blacklist rules.
        /// Primarily used *before* the product entity is fully created or updated in the database.
        /// </summary>
        /// <param name="sourceData">The DTO containing data fetched from the source (e.g., ProductGrabberDto).</param>
        /// <returns>True if the product matches a blacklist rule, false otherwise.</returns>
        Task<bool> ShouldBlockProductAsync(ProductGrabberDto sourceData);

        /// <summary>
        /// Checks if an existing Product entity matches any active blacklist rules.
        /// Used for evaluating products already in the database.
        /// </summary>
        /// <param name="product">The existing Product entity (should include related Brand, Categories, potentially Tags if stored).</param>
        /// <returns>True if the product matches a blacklist rule, false otherwise.</returns>
        Task<bool> IsProductBlacklistedAsync(Product product);
    }
}

