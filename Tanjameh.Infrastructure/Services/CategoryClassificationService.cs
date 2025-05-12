using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Dtos.Scraping;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Infrastructure.Services
{
    /// <summary>
    /// Service for classifying products into logical categories based on source data.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Analyzes product data (tags, price, categories) from external sources 
    ///          and assigns relevant internal logical categories (e.g., "Sale", "Esports").
    /// Usage: Called during product import or update processes.
    /// Dependencies: IDbContextFactory<ApplicationDbContext>, ILogger.
    /// Logic: Contains rules for mapping source data to LogicalCategory entities.
    /// </remarks>
    public class CategoryClassificationService : ICategoryClassificationService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        private readonly ILogger<CategoryClassificationService> _logger;

        // Define mappings (could be moved to configuration)
        private static readonly Dictionary<string, string> TagToLogicalCategoryMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "esports", "Esports" },
            { "gaming", "Esports" },
            { "sustainable", "Sustainable Fashion" },
            { "eco-friendly", "Sustainable Fashion" }
            // Add more mappings as needed
        };

        private const string SaleCategoryName = "Sale";

        public CategoryClassificationService(IDbContextFactory<ApplicationDbContext> dbContextFactory, ILogger<CategoryClassificationService> logger)
        {
            _dbContextFactory = dbContextFactory;
            _logger = logger;
        }

        /// <summary>
        /// Analyzes the product data and assigns appropriate logical categories.
        /// </summary>
        /// <param name="product">The Product entity being processed. Its LogicalCategories collection will be updated.</param>
        /// <param name="sourceData">The DTO containing data fetched from the source.</param>
        public async Task ClassifyProductAsync(Product product, ProductGrabberDto sourceData)
        {
            if (product == null || sourceData == null)
            {
                _logger.LogWarning("ClassifyProductAsync called with null product or sourceData.");
                return;
            }

            await using var context = await _dbContextFactory.CreateDbContextAsync();
            
            // Ensure the LogicalCategories collection is loaded or initialized
            // If product is newly created, this might be null. If fetched, it might need explicit loading.
            // For simplicity, we assume it's handled correctly before calling this service, or we fetch it.
            // Let's fetch the product with its current logical categories to be safe.
            var productWithCategories = await context.Products
                                                .Include(p => p.LogicalCategories)
                                                .FirstOrDefaultAsync(p => p.Id == product.Id);
            
            if (productWithCategories == null)
            {
                 _logger.LogError("Product with ID {ProductId} not found in DB during classification.", product.Id);
                 return; // Or use the passed-in product if it's guaranteed to be tracked
            }
            product = productWithCategories; // Use the tracked entity
            product.LogicalCategories ??= new List<LogicalCategory>();

            var assignedCategoryNames = new HashSet<string>(product.LogicalCategories.Select(lc => lc.Name), StringComparer.OrdinalIgnoreCase);
            var categoriesToAdd = new List<LogicalCategory>();

            // 1. Detect "Sale" category based on price difference
            bool isOnSale = sourceData.Variants.Any(v => v.OldPrice.HasValue && v.Price.HasValue && v.OldPrice > v.Price);
            if (isOnSale && !assignedCategoryNames.Contains(SaleCategoryName))
            {
                var saleCategory = await FindOrCreateLogicalCategoryAsync(context, SaleCategoryName);
                if (saleCategory != null) categoriesToAdd.Add(saleCategory);
            }
            // Optional: Remove from Sale if no longer on sale (requires tracking previous state or re-evaluating all)
            // else if (!isOnSale && assignedCategoryNames.Contains(SaleCategoryName)) { ... remove logic ... }

            // 2. Map source tags to logical categories
            if (sourceData.Tags != null)
            {
                foreach (var tag in sourceData.Tags)
                {
                    if (TagToLogicalCategoryMap.TryGetValue(tag, out var logicalCategoryName))
                    {
                        if (!assignedCategoryNames.Contains(logicalCategoryName))
                        {
                            var logicalCategory = await FindOrCreateLogicalCategoryAsync(context, logicalCategoryName);
                            if (logicalCategory != null) categoriesToAdd.Add(logicalCategory);
                        }
                    }
                }
            }

            // 3. Add new categories to the product
            if (categoriesToAdd.Any())
            {
                foreach (var category in categoriesToAdd)
                {
                    // Double-check to prevent adding duplicates if multiple tags map to the same category
                    if (!product.LogicalCategories.Any(lc => lc.Id == category.Id))
                    {
                        product.LogicalCategories.Add(category);
                        _logger.LogInformation("Assigned logical category ", category.Name); // Removed product ID from log message
                    }
                }
                // Note: SaveChanges will be called by the calling process (e.g., UpdateProductDetailCommandHandler)
            }
        }

        /// <summary>
        /// Finds an existing LogicalCategory by name or creates a new one if it doesn't exist.
        /// </summary>
        private async Task<LogicalCategory?> FindOrCreateLogicalCategoryAsync(ApplicationDbContext context, string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
                return null;

            var category = await context.LogicalCategories
                                    .FirstOrDefaultAsync(lc => lc.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (category == null)
            {
                _logger.LogInformation("Creating new logical category: {CategoryName}", categoryName);
                category = new LogicalCategory { Name = categoryName, Slug = categoryName.ToLowerInvariant().Replace(" ", "-") }; // Basic slug generation
                context.LogicalCategories.Add(category);
                // SaveChanges needed here to get the ID if we were returning it immediately, 
                // but since we return the entity, it can be saved later by the caller.
            }
            return category;
        }
    }
}

