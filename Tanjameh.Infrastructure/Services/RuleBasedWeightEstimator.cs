using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;

namespace Tanjameh.Infrastructure.Services
{
    /// <summary>
    /// Service responsible for estimating product weight based on predefined rules.
    /// </summary>
    /// <remarks>
    /// README:
    /// Purpose: This service provides an estimated weight for a product when external sources
    /// (like Amazon scraping) are unavailable or fail. It uses a set of internal rules based on
    /// product characteristics like category, subcategory, material, etc.
    /// Dependencies: Requires ILogger for logging.
    /// Setup: Register this service with dependency injection.
    /// Structure: The core logic is in EstimateWeightAsync. It evaluates the product against a
    /// predefined set of rules. The current implementation uses a simple if-else structure.
    /// For more complex scenarios, consider loading rules from a configuration file or database.
    /// Extendability: Add more rules to the EstimateWeightAsync method by extending the if-else
    /// conditions or refactoring to use a more dynamic rule engine (e.g., dictionary lookup).
    /// Error Handling: Logs warnings if no matching rule is found.
    /// </remarks>
    public class RuleBasedWeightEstimator : IRuleBasedWeightEstimator
    {
        private readonly ILogger<RuleBasedWeightEstimator> _logger;

        // Example rule structure - could be loaded from config/DB
        // Key: CategoryName (ToLower), Value: (SubCategoryName (ToLower) -> WeightKg)
        private static readonly Dictionary<string, Dictionary<string, decimal>> _categoryWeightRules = 
            new Dictionary<string, Dictionary<string, decimal>>(StringComparer.OrdinalIgnoreCase)
            {
                { "clothing", new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase) { 
                    { "t-shirt", 0.2m }, 
                    { "shirt", 0.3m }, 
                    { "jeans", 0.7m }, 
                    { "trousers", 0.6m }, 
                    { "jacket", 1.1m }, 
                    { "coat", 1.5m }, 
                    { "dress", 0.5m },
                    { "sweater", 0.6m },
                    { "hoodie", 0.8m },
                    { "underwear", 0.1m },
                    { "socks", 0.05m }
                } },
                { "shoes", new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase) { 
                    { "sneakers", 0.8m }, 
                    { "boots", 1.5m }, 
                    { "sandals", 0.4m }, 
                    { "formal shoes", 1.0m }
                } },
                { "accessories", new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase) { 
                    { "bag", 0.9m }, 
                    { "belt", 0.2m }, 
                    { "hat", 0.15m }, 
                    { "scarf", 0.2m },
                    { "gloves", 0.1m }
                } }
                // Add more categories and subcategories
            };

        // Default weight if no specific rule matches
        private const decimal DefaultEstimatedWeight = 0.5m;

        public RuleBasedWeightEstimator(ILogger<RuleBasedWeightEstimator> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Estimates the weight of a given product based on internal rules.
        /// </summary>
        /// <param name="product">The product entity for which to estimate the weight.</param>
        /// <returns>
        /// A Task representing the asynchronous operation. The task result contains the estimated weight 
        /// in kilograms as a decimal?, or null if estimation is not possible (though this implementation provides a default).
        /// </returns>
        public Task<decimal?> EstimateWeightAsync(Product product)
        {
            _logger.LogInformation("Estimating weight for product: {ProductId} - {ProductName}", product.Id, product.Name);

            decimal estimatedWeight = DefaultEstimatedWeight;
            bool ruleMatched = false;

            // Ensure categories are loaded if using lazy loading (adjust based on actual context usage)
            // var categories = product.ProductCategories?.Select(pc => pc.Category).ToList();
            // For simplicity, assuming category info might be directly accessible or passed differently.
            // This placeholder needs access to Category/Subcategory names.
            // Let's assume we can get the primary category/subcategory names somehow.
            // In a real scenario, you'd likely need to query the DB or ensure Product includes this info.
            
            // --- Placeholder for getting category names ---
            // string primaryCategoryName = product.ProductCategories?.FirstOrDefault()?.Category?.Name ?? "unknown";
            // string primarySubCategoryName = "unknown"; // Need logic to determine subcategory
            // For now, we'll simulate having these names
            string primaryCategoryName = product.ProductCategories?.FirstOrDefault()?.Category?.Name ?? "clothing"; // Example
            string primarySubCategoryName = "t-shirt"; // Example
            // --- End Placeholder ---

            if (_categoryWeightRules.TryGetValue(primaryCategoryName, out var subCategoryRules))
            {
                if (subCategoryRules.TryGetValue(primarySubCategoryName, out var weight))
                {
                    estimatedWeight = weight;
                    ruleMatched = true;
                    _logger.LogInformation("Rule matched: Category=\'{Category}\' SubCategory=\'{SubCategory}\'. Estimated weight: {Weight} kg", primaryCategoryName, primarySubCategoryName, estimatedWeight);
                }
                else
                {
                    // Fallback: If subcategory doesn't match, maybe use an average for the category?
                    // Or stick to the default.
                     _logger.LogDebug("No specific rule for SubCategory \'{SubCategory}\' in Category \'{Category}\'. Using default or category average.", primarySubCategoryName, primaryCategoryName);
                     // Example: Use average weight for the category if available
                     if (subCategoryRules.Any())
                     {
                         // estimatedWeight = subCategoryRules.Values.Average(); 
                         // Sticking to default for simplicity now
                     }
                }
            }
            else
            {
                 _logger.LogDebug("No rules found for Category \'{Category}\'.", primaryCategoryName);
            }

            if (!ruleMatched)
            {
                _logger.LogWarning("No specific rule matched for Product ID {ProductId}. Using default estimated weight: {Weight} kg", product.Id, DefaultEstimatedWeight);
                estimatedWeight = DefaultEstimatedWeight; // Ensure default is assigned if no rule hit
            }

            // Future enhancements: Adjust weight based on Material, Size, Gender etc.
            // Example: if (product.Material == "Leather") estimatedWeight *= 1.2m;

            return Task.FromResult<decimal?>(estimatedWeight);
        }
    }
}

