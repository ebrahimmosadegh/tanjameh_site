namespace Tanjameh.Core.Settings
{
    /// <summary>
    /// Configuration settings for pricing, including currency rates and margin tiers.
    /// </summary>
    public class PricingSettings
    {
        public const string SectionName = "PricingSettings";

        /// <summary>
        /// The base currency in which source prices are provided (e.g., "GBP").
        /// </summary>
        public string BaseCurrency { get; set; } = "GBP";

        /// <summary>
        /// Dictionary mapping target currency codes (ISO 4217, e.g., "IRR", "USD") 
        /// to their conversion rate from the BaseCurrency.
        /// Example: If BaseCurrency is GBP, IRR rate might be 65000.0 (1 GBP = 65000 IRR).
        /// </summary>
        public Dictionary<string, decimal> CurrencyRates { get; set; } = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

        // Margin tiers could be added here for configuration later, 
        // but are hardcoded in the service for now based on requirements.
        // public List<MarginTierSetting> MarginTiers { get; set; } = new List<MarginTierSetting>();
    }

    // Example structure if margin tiers were configurable:
    // public class MarginTierSetting
    // {
    //     public decimal MinPriceGbp { get; set; }
    //     public decimal MaxPriceGbp { get; set; }
    //     public decimal MarginPercentage { get; set; }
    // }
}

