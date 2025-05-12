using System.Threading.Tasks;

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Represents the result of a price calculation, including original and final prices.
    /// </summary>
    public class PriceCalculationResult
    {
        /// <summary>
        /// The original price in the base currency (e.g., GBP).
        /// </summary>
        public decimal OriginalPriceBaseCurrency { get; set; }
        /// <summary>
        /// The base currency code (e.g., "GBP").
        /// </summary>
        public string BaseCurrency { get; set; } = string.Empty;
        /// <summary>
        /// The calculated final price in the target currency.
        /// </summary>
        public decimal FinalPriceLocalCurrency { get; set; }
        /// <summary>
        /// The target currency code (e.g., "IRR", "USD").
        /// </summary>
        public string LocalCurrency { get; set; } = string.Empty;
        /// <summary>
        /// The profit margin percentage applied (e.g., 0.10 for 10%).
        /// </summary>
        public decimal AppliedMarginPercentage { get; set; }
        /// <summary>
        /// The conversion rate used from base to local currency.
        /// </summary>
        public decimal ConversionRateUsed { get; set; }
    }

    /// <summary>
    /// Defines the contract for calculating product prices based on base price, 
    /// currency rates, and tiered profit margins.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: To provide a centralized service for calculating the final display/checkout price 
    ///          of a product in a target local currency, incorporating business logic for margins.
    /// Usage: Called by product display components (listing, detail) and checkout logic.
    /// Developer Notes: Implementations should fetch currency rates from configuration 
    ///                and apply the defined tiered profit margin logic.
    /// </remarks>
    public interface IPriceCalculatorService
    {
        /// <summary>
        /// Calculates the final price for a product variant in the specified target currency.
        /// </summary>
        /// <param name="originalPriceGbp">The original price of the product variant in GBP.</param>
        /// <param name="targetCurrencyCode">The desired target currency code (e.g., "IRR", "USD").</param>
        /// <returns>A PriceCalculationResult containing original and final prices, or null if calculation fails (e.g., rate not found).</returns>
        Task<PriceCalculationResult?> CalculatePriceAsync(decimal originalPriceGbp, string targetCurrencyCode);
    }
}

