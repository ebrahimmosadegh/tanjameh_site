using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Dtos.Scraping;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Enums; // Assuming RuleType enum exists here
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Infrastructure.Services
{
    /// <summary>
    /// Service to check if products match defined blacklist rules.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Evaluates products against a list of configurable blacklist rules.
    /// Usage: Called during import (ShouldBlockProductAsync) and potentially during updates/display (IsProductBlacklistedAsync).
    /// Dependencies: IDbContextFactory<ApplicationDbContext>, ILogger.
    /// Logic: Loads active ProductBlacklistRule entities and checks product data against them.
    /// </remarks>
    public class ProductBlacklistService : IProductBlacklistService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        private readonly ILogger<ProductBlacklistService> _logger;
        private List<ProductBlacklistRule>? _cachedRules = null;
        private DateTime _cacheTimestamp = DateTime.MinValue;
        private readonly TimeSpan _cacheDuration = TimeSpan.FromMinutes(15); // Cache rules for 15 minutes

        public ProductBlacklistService(IDbContextFactory<ApplicationDbContext> dbContextFactory, ILogger<ProductBlacklistService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _logger = logger;
        }

        // Method to get cached or fresh rules
        private async Task<List<ProductBlacklistRule>> GetActiveRulesAsync()
        {
            if (_cachedRules != null && (DateTime.UtcNow - _cacheTimestamp) < _cacheDuration)
            {
                return _cachedRules;
            }

            _logger.LogInformation("Refreshing product blacklist rules cache...");
            try
            {
                await using var context = await _dbContextFactory.CreateDbContextAsync();
                _cachedRules = await context.ProductBlacklistRules
                                        .Where(r => r.IsActive)
                                        .ToListAsync();
                _cacheTimestamp = DateTime.UtcNow;
                _logger.LogInformation("Loaded {Count} active blacklist rules into cache.", _cachedRules.Count);
                return _cachedRules;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load product blacklist rules.");
                return new List<ProductBlacklistRule>(); // Return empty list on error
            }
        }

        /// <summary>
        /// Checks if source data matches any active blacklist rules before import.
        /// </summary>
        public async Task<bool> ShouldBlockProductAsync(ProductGrabberDto sourceData)
        {
            if (sourceData == null)
            {
                _logger.LogWarning("ShouldBlockProductAsync called with null sourceData.");
                return false;
            }

            var rules = await GetActiveRulesAsync();
            if (!rules.Any()) return false; // No rules, nothing to block

            foreach (var rule in rules)
            {
                if (MatchesRule(rule, sourceData))
                {
                    _logger.LogInformation("Product (Source ID: {SourceProductId}, Name: {ProductName}) matched blacklist rule ID {RuleId} (", sourceData.SourceProductId, sourceData.Name, rule.Id); // Removed rule description from log message
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if an existing Product entity matches any active blacklist rules.
        /// </summary>
        public async Task<bool> IsProductBlacklistedAsync(Product product)
        {
             if (product == null)
            {
                _logger.LogWarning("IsProductBlacklistedAsync called with null product.");
                return false;
            }

            var rules = await GetActiveRulesAsync();
            if (!rules.Any()) return false;

            // Ensure related data is loaded if needed (might require fetching from DB)
            // This assumes Brand, Categories, etc., are available on the passed product object.
            // If not, fetch the product with includes here.
            // Example: await using var context = await _dbContextFactory.CreateDbContextAsync();
            //          product = await context.Products.Include(p=>p.CatalogBrand)... .FirstOrDefaultAsync(p => p.Id == product.Id);

            foreach (var rule in rules)
            {
                if (MatchesRule(rule, product))
                {
                    _logger.LogInformation("Product ID {ProductId} (Name: {ProductName}) matched blacklist rule ID {RuleId} (", product.Id, product.Name, rule.Id); // Removed rule description from log message
                    return true;
                }
            }

            return false;
        }

        // Helper to check rule match against source data
        private bool MatchesRule(ProductBlacklistRule rule, ProductGrabberDto sourceData)
        {
            var keyword = rule.Keyword?.Trim();
            if (string.IsNullOrEmpty(keyword)) return false; // Invalid rule

            switch (rule.RuleType)
            {
                case BlacklistRuleType.KeywordTitle:
                    return sourceData.Name?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false;
                
                case BlacklistRuleType.KeywordBrand:
                    return sourceData.BrandName?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false;

                case BlacklistRuleType.KeywordCategory:
                    return sourceData.Categories?.Any(cat => cat?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ?? false;

                case BlacklistRuleType.Tag:
                    return sourceData.Tags?.Any(tag => tag?.Equals(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ?? false;
                
                // Add cases for other rule types (e.g., CustomLogic) if implemented

                default:
                    _logger.LogWarning("Unsupported blacklist rule type: {RuleType}", rule.RuleType);
                    return false;
            }
        }

        // Helper to check rule match against existing Product entity
        private bool MatchesRule(ProductBlacklistRule rule, Product product)
        {
            var keyword = rule.Keyword?.Trim();
            if (string.IsNullOrEmpty(keyword)) return false;

            switch (rule.RuleType)
            {
                case BlacklistRuleType.KeywordTitle:
                    return product.Name?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false;
                
                case BlacklistRuleType.KeywordBrand:
                    // Assumes product.CatalogBrand is loaded
                    return product.CatalogBrand?.Name?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false;

                case BlacklistRuleType.KeywordCategory:
                    // Assumes product.ProductCategories.Select(pc => pc.Category) is loaded
                    return product.ProductCategories?.Any(pc => pc.Category?.Name?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ?? false;

                case BlacklistRuleType.Tag:
                    // Assumes product tags are loaded (e.g., product.ProductProductTags.Select(pt => pt.ProductTag))
                    // return product.ProductProductTags?.Any(pt => pt.ProductTag?.Name?.Equals(keyword, StringComparison.OrdinalIgnoreCase) ?? false) ?? false;
                    _logger.LogWarning("Blacklist rule type 'Tag' check against existing Product entity is not fully implemented. Requires ProductTags relation.");
                    return false; // Placeholder

                default:
                    _logger.LogWarning("Unsupported blacklist rule type: {RuleType}", rule.RuleType);
                    return false;
            }
        }
    }
}

