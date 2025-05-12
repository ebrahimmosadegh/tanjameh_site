using System.Threading.Tasks;
using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Defines the contract for a service that orchestrates the process of 
    /// determining and updating a product's weight based on available sources.
    /// </summary>
    /// <remarks>
    /// This service implements the 3-tiered fallback logic:
    /// 1. Prioritize Actual Weight (Manual Entry).
    /// 2. Attempt External API (e.g., Amazon Scraping).
    /// 3. Fallback to Rule-Based Estimation.
    /// </remarks>
    public interface IWeightEstimationService
    {
        /// <summary>
        /// Determines the most appropriate weight for the product based on the 
        /// defined fallback logic and updates the product entity's weight fields.
        /// </summary>
        /// <param name="product">The product entity to update. The service will modify its 
        /// EstimatedWeightKg and WeightSource properties, potentially based on ActualWeightKg.</param>
        /// <returns>
        /// A Task representing the asynchronous operation. The task result indicates whether 
        /// a weight (either actual or estimated) was successfully assigned.
        /// </returns>
        /// <remarks>
        /// The service should not save the changes to the database; it only updates the entity in memory.
        /// The calling process is responsible for persisting the changes.
        /// </remarks>
        Task<bool> UpdateProductWeightAsync(Product product);
    }
}

