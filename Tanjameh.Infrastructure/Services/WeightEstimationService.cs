using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Enums;
using Tanjameh.Core.Interfaces;

namespace Tanjameh.Infrastructure.Services
{
    /// <summary>
    /// Service responsible for orchestrating the determination and updating of product weight.
    /// </summary>
    /// <remarks>
    /// README:
    /// Purpose: This service implements the 3-tiered fallback logic for assigning a weight
    /// to a product. It prioritizes actual measured weight, then attempts to fetch weight
    /// from external sources (like Amazon), and finally falls back to rule-based estimation.
    /// Dependencies: Requires IAmazonScraperService, IRuleBasedWeightEstimator, and ILogger.
    /// Setup: Register this service along with its dependencies (AmazonScraperService, RuleBasedWeightEstimator)
    /// with the dependency injection container.
    /// Structure: The core logic is in UpdateProductWeightAsync. It checks for actual weight first.
    /// If none exists, it calls the Amazon scraper. If that fails, it calls the rule-based estimator.
    /// It updates the Product entity's EstimatedWeightKg and WeightSource properties in memory.
    /// Interaction: This service is typically called during product import or update processes.
    /// The calling code is responsible for persisting the changes made to the Product entity.
    /// Error Handling: Logs information about the process and potential failures at each step.
    /// </remarks>
    public class WeightEstimationService : IWeightEstimationService
    {
        private readonly IAmazonScraperService _amazonScraperService;
        private readonly IRuleBasedWeightEstimator _ruleBasedWeightEstimator;
        private readonly ILogger<WeightEstimationService> _logger;

        public WeightEstimationService(
            IAmazonScraperService amazonScraperService,
            IRuleBasedWeightEstimator ruleBasedWeightEstimator,
            ILogger<WeightEstimationService> logger)
        {
            _amazonScraperService = amazonScraperService;
            _ruleBasedWeightEstimator = ruleBasedWeightEstimator;
            _logger = logger;
        }

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
        public async Task<bool> UpdateProductWeightAsync(Product product)
        {
            if (product == null)
            {
                _logger.LogError("UpdateProductWeightAsync called with a null product.");
                return false;
            }

            _logger.LogInformation("Starting weight estimation for Product ID: {ProductId}", product.Id);

            // Tier 1: Actual Weight (Manual Entry)
            if (product.ActualWeightKg.HasValue && product.ActualWeightKg > 0)
            {
                _logger.LogInformation("Product ID: {ProductId} has ActualWeightKg: {Weight} kg. Setting WeightSource to ManualEntry.", product.Id, product.ActualWeightKg.Value);
                product.WeightSource = WeightSource.ManualEntry;
                // EstimatedWeightKg might still exist from previous runs, but ActualWeightKg takes precedence.
                // The EffectiveWeightKg property handles this logic.
                return true; // A definitive weight exists.
            }

            // Tier 2: External API (Amazon Scraper)
            _logger.LogDebug("Product ID: {ProductId} - No actual weight. Attempting Amazon scraping.", product.Id);
            try
            {
                // Need Brand and Category names for the scraper
                string brandName = product.CatalogBrand?.Name ?? "Unknown Brand"; // Ensure CatalogBrand is loaded or handle null
                string categoryName = product.ProductCategories?.FirstOrDefault()?.Category?.Name ?? "Unknown Category"; // Ensure Categories are loaded
                string subCategoryName = null; // Add logic to get subcategory if needed by scraper

                decimal? scrapedWeight = await _amazonScraperService.GetProductWeightAsync(product.Name, brandName, categoryName, subCategoryName);
                if (scrapedWeight.HasValue && scrapedWeight > 0)
                {
                    _logger.LogInformation("Product ID: {ProductId} - Amazon scraper found weight: {Weight} kg. Setting WeightSource to ExternalApi.", product.Id, scrapedWeight.Value);
                    product.EstimatedWeightKg = scrapedWeight.Value;
                    product.WeightSource = WeightSource.ExternalApi;
                    return true; // Weight found via external API.
                }
                else
                {
                    _logger.LogInformation("Product ID: {ProductId} - Amazon scraper did not find a weight.", product.Id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Product ID: {ProductId} - Error occurred during Amazon scraping.", product.Id);
                // Continue to fallback even if scraper fails
            }

            // Tier 3: Rule-Based Estimation
            _logger.LogDebug("Product ID: {ProductId} - Attempting rule-based estimation.", product.Id);
            try
            {
                decimal? estimatedWeight = await _ruleBasedWeightEstimator.EstimateWeightAsync(product);
                if (estimatedWeight.HasValue && estimatedWeight > 0)
                {
                    _logger.LogInformation("Product ID: {ProductId} - Rule-based estimator provided weight: {Weight} kg. Setting WeightSource to Estimated.", product.Id, estimatedWeight.Value);
                    product.EstimatedWeightKg = estimatedWeight.Value;
                    product.WeightSource = WeightSource.Estimated;
                    return true; // Weight found via estimation.
                }
                else
                {
                    _logger.LogWarning("Product ID: {ProductId} - Rule-based estimator did not provide a weight.", product.Id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Product ID: {ProductId} - Error occurred during rule-based estimation.", product.Id);
            }

            // If we reach here, no weight could be determined by any method.
            _logger.LogWarning("Product ID: {ProductId} - Could not determine weight from any source.", product.Id);
            // Ensure WeightSource reflects the failure if it wasn't set previously
            if (product.WeightSource == WeightSource.Unknown && !product.ActualWeightKg.HasValue)
            {
                 // Keep it as Unknown or set a specific 'Failed' status if needed.
                 // product.WeightSource = WeightSource.Unknown; // Already the default
            }
            // Reset estimated weight if it wasn't successfully set by API or rules?
            // product.EstimatedWeightKg = 0; // Or keep potentially stale value?
            // Decision: Keep potentially stale value for now, but ensure source is correct.
            
            // Return true if *any* weight (Actual or Estimated > 0) exists, false otherwise.
            return product.EffectiveWeightKg > 0;
        }
    }
}

