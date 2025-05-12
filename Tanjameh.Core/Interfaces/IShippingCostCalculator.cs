using System.Collections.Generic;
using System.Threading.Tasks;
using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces
{
    /// <summary>
    /// Represents the calculated shipping options for an order.
    /// </summary>
    public class ShippingOption
    {
        public long ShippingProviderId { get; set; }
        public string ProviderName { get; set; } = string.Empty;
        public long ShippingTierId { get; set; }
        public string TierName { get; set; } = string.Empty; // e.g., "Standard (0-2kg)"
        public decimal Cost { get; set; }
        public string? EstimatedDeliveryTime { get; set; } // e.g., "3-5 business days"
        public bool IsRecommended { get; set; } // Flag for the potentially best/default option
    }

    /// <summary>
    /// Defines the contract for a service that calculates shipping costs based on order details.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: To calculate available shipping options and their costs based on total weight, destination, and provider tiers.
    /// Usage: Called during the checkout process to present shipping options to the user and determine the final shipping cost.
    /// Developer Notes: Implementations should query ShippingProvider and ShippingTier data, apply rules based on weight and destination.
    ///                The logic should be formula-based and configurable.
    /// </remarks>
    public interface IShippingCostCalculator
    {
        /// <summary>
        /// Calculates the available shipping options for a given order weight and destination.
        /// </summary>
        /// <param name="totalWeightKg">The total weight of the order in kilograms.</param>
        /// <param name="destinationCountry">The destination country code (e.g., "IR" for Iran).</param>
        /// <param name="destinationPostalCode">Optional: The destination postal code for more specific rates.</param>
        /// <returns>A list of available ShippingOption objects, or an empty list if no options are found.</returns>
        Task<List<ShippingOption>> GetShippingOptionsAsync(decimal totalWeightKg, string destinationCountry, string? destinationPostalCode = null);
    }
}

