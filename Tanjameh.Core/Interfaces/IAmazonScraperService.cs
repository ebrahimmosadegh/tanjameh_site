using System.Threading.Tasks;

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Defines the contract for a service that scrapes Amazon product pages 
    /// to extract product weight information.
    /// </summary>
    public interface IAmazonScraperService
    {
        /// <summary>
        /// Attempts to find a product on Amazon based on its details and extract its weight.
        /// </summary>
        /// <param name="productTitle">The title or name of the product.</param>
        /// <param name="brand">The brand of the product.</param>
        /// <param name="category">The primary category of the product.</param>
        /// <param name="subCategory">The sub-category of the product (optional).</param>
        /// <returns>
        /// A Task representing the asynchronous operation. The task result contains the extracted weight 
        /// in kilograms as a decimal?, or null if the weight could not be found or extracted.
        /// </returns>
        /// <remarks>
        /// Implementations should handle potential scraping blocks, page structure changes, 
        /// and unit conversions (e.g., pounds to kilograms).
        /// </remarks>
        Task<decimal?> GetProductWeightAsync(string productTitle, string brand, string category, string? subCategory = null);
    }
}

