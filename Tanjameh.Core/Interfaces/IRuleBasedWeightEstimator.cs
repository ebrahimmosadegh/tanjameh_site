using System.Threading.Tasks;
using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Defines the contract for a service that estimates product weight based on predefined rules.
    /// </summary>
    /// <remarks>
    /// This service acts as a fallback when external sources (like Amazon scraping) fail to provide weight.
    /// Rules typically consider product category, subcategory, material, size, etc.
    /// </remarks>
    public interface IRuleBasedWeightEstimator
    {
        /// <summary>
        /// Estimates the weight of a given product based on internal rules.
        /// </summary>
        /// <param name="product">The product entity for which to estimate the weight.</param>
        /// <returns>
        /// A Task representing the asynchronous operation. The task result contains the estimated weight 
        /// in kilograms as a decimal?, or null if no applicable rule is found or estimation is not possible.
        /// </returns>
        /// <remarks>
        /// Implementations should contain the logic to evaluate rules against the product's properties.
        /// The rule set should ideally be configurable or easily extendable.
        /// </remarks>
        Task<decimal?> EstimateWeightAsync(Product product);
    }
}

