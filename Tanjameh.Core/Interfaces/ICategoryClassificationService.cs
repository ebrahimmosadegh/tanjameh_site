using System.Collections.Generic;
using System.Threading.Tasks;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Dtos.Scraping; // Assuming ProductGrabberDto contains tags, price info

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Defines the contract for a service that classifies products into logical categories 
    /// based on source data (tags, price differences, source categories).
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: To analyze product data from external sources and assign relevant internal logical categories (e.g., "Sale", "New Arrivals", "Esports").
    /// Usage: Called during product import (Grabber) or update processes.
    /// Developer Notes: Implementations should contain rules for mapping source tags/data to internal LogicalCategory entities.
    ///                The service should interact with the database to find or create LogicalCategory records and update Product associations.
    /// </remarks>
    public interface ICategoryClassificationService
    {
        /// <summary>
        /// Analyzes the product data and assigns appropriate logical categories.
        /// </summary>
        /// <param name="product">The Product entity being processed. The service will update its LogicalCategories collection.</param>
        /// <param name="sourceData">The DTO containing data fetched from the source (e.g., ProductGrabberDto), including tags, price, categories.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        Task ClassifyProductAsync(Product product, ProductGrabberDto sourceData);
    }
}

