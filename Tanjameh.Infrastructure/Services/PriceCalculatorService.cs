using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Tanjameh.Core.Interfaces;
using Tanjameh.Core.Settings;

namespace Tanjameh.Infrastructure.Services
{
    /// <summary>
    /// Service for calculating product prices based on base price, currency rates, and tiered profit margins.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Provides final display/checkout price calculation incorporating margins and currency conversion.
    /// Usage: Called by product display and checkout logic.
    /// Dependencies: IOptions<PricingSettings>, ILogger.
    /// Logic: Applies tiered margins based on GBP price and converts using configured rates.
    /// </remarks>
    public class PriceCalculatorService : IPriceCalculatorService
    {
        private readonly PricingSettings _pricingSettings;
        private readonly ILogger<PriceCalculatorService> _logger;

        // Define margin tiers (hardcoded as per current requirements)
        private static readonly List<(decimal MinGbp, decimal MaxGbp, decimal Margin)> MarginTiers = new List<(decimal, decimal, decimal)>()
        {
            (0m, 199.99m, 0.10m),    // 10%
            (200m, 399.99m, 0.09m),   // 9%
            (400m, 599.99m, 0.08m),   // 8%
            (600m, 799.99m, 0.07m),   // 7%
            (800m, 999.99m, 0.06m),   // 6%
            (1000m, decimal.MaxValue, 0.05m) // 5%
        };

        public PriceCalculatorService(IOptions<PricingSettings> pricingSettingsOptions, ILogger<PriceCalculatorService> logger)
        {
            _pricingSettings = pricingSettingsOptions.Value;
            _logger = logger;

            if (_pricingSettings.CurrencyRates == null || !_pricingSettings.CurrencyRates.Any())
            {
                _logger.LogWarning("PricingSettings: CurrencyRates dictionary is null or empty. Price calculations might fail.");
                _pricingSettings.CurrencyRates ??= new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
            }
            if (string.IsNullOrEmpty(_pricingSettings.BaseCurrency))
            {
                 _logger.LogWarning("PricingSettings: BaseCurrency is not set. Defaulting to GBP, but this should be configured.");
                 _pricingSettings.BaseCurrency = "GBP";
            }
        }

        /// <summary>
        /// Calculates the final price for a product variant in the specified target currency.
        /// </summary>
        /// <param name="originalPriceGbp">The original price of the product variant in GBP.</param>
        /// <param name="targetCurrencyCode">The desired target currency code (e.g., "IRR", "USD").</param>
        /// <returns>A PriceCalculationResult containing original and final prices, or null if calculation fails.</returns>
        public Task<PriceCalculationResult?> CalculatePriceAsync(decimal originalPriceGbp, string targetCurrencyCode)
        {
            if (originalPriceGbp < 0)
            {
                _logger.LogWarning("CalculatePriceAsync called with negative originalPriceGbp: {OriginalPriceGbp}", originalPriceGbp);
                return Task.FromResult<PriceCalculationResult?>(null);
            }
            if (string.IsNullOrWhiteSpace(targetCurrencyCode))
            {
                 _logger.LogWarning("CalculatePriceAsync called with null or empty targetCurrencyCode.");
                 return Task.FromResult<PriceCalculationResult?>(null);
            }

            // 1. Get Conversion Rate
            if (!_pricingSettings.CurrencyRates.TryGetValue(targetCurrencyCode, out decimal conversionRate) || conversionRate <= 0)
            {
                _logger.LogError("Conversion rate not found or invalid for target currency: {TargetCurrencyCode}", targetCurrencyCode);
                return Task.FromResult<PriceCalculationResult?>(null);
            }

            // 2. Get Margin Percentage
            decimal marginPercentage = GetMarginPercentage(originalPriceGbp);

            // 3. Calculate Final Price
            // FinalPrice = (GBP_Price) * (GBP_to_LocalRate) * (1 + Margin_Percentage)
            decimal finalPriceLocal = originalPriceGbp * conversionRate * (1 + marginPercentage);

            // Rounding strategy? For IRR (Toman), maybe round to nearest 100 or 1000?
            // For now, let's round to 2 decimal places for general currencies, specific rounding can be added later.
            finalPriceLocal = Math.Round(finalPriceLocal, 2); 
            // Example for IRR (Toman) rounding to nearest 1000:
            // if (targetCurrencyCode.Equals("IRR", StringComparison.OrdinalIgnoreCase)) { 
            //     finalPriceLocal = Math.Round(finalPriceLocal / 1000) * 1000; 
            // }

            var result = new PriceCalculationResult
            {
                OriginalPriceBaseCurrency = originalPriceGbp,
                BaseCurrency = _pricingSettings.BaseCurrency,
                FinalPriceLocalCurrency = finalPriceLocal,
                LocalCurrency = targetCurrencyCode.ToUpperInvariant(),
                AppliedMarginPercentage = marginPercentage,
                ConversionRateUsed = conversionRate
            };

            _logger.LogDebug("Calculated price for {OriginalPriceGbp} {BaseCurrency} -> {FinalPriceLocal} {LocalCurrency} (Rate: {Rate}, Margin: {MarginPcnt}%)", 
                result.OriginalPriceBaseCurrency, result.BaseCurrency, result.FinalPriceLocalCurrency, result.LocalCurrency, result.ConversionRateUsed, result.AppliedMarginPercentage * 100);

            return Task.FromResult<PriceCalculationResult?>(result);
        }

        /// <summary>
        /// Determines the profit margin percentage based on the original GBP price.
        /// </summary>
        /// <param name="originalPriceGbp">The price in GBP.</param>
        /// <returns>The applicable margin percentage (e.g., 0.10 for 10%).</returns>
        private decimal GetMarginPercentage(decimal originalPriceGbp)
        {
            foreach (var tier in MarginTiers)
            {
                // Check if price falls within the tier range (inclusive min, exclusive max for typical tiering, but requirements use inclusive max)
                // Adjusting to match requirements: <= MaxPrice
                if (originalPriceGbp >= tier.MinGbp && originalPriceGbp <= tier.MaxGbp)
                {
                    return tier.Margin;
                }
            }

            // Fallback if somehow no tier matches (shouldn't happen with decimal.MaxValue)
            _logger.LogWarning("No margin tier found for GBP price: {OriginalPriceGbp}. Defaulting to lowest margin.", originalPriceGbp);
            return MarginTiers.LastOrDefault().Margin; // Default to the last tier's margin (5%)
        }
    }
}

