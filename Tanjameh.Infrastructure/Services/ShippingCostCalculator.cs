using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Infrastructure.Services
{
    /// <summary>
    /// Service to calculate shipping costs based on order weight, destination, and provider tiers.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Calculates available shipping options and costs using predefined provider tiers.
    /// Usage: Called during checkout to display shipping choices.
    /// Dependencies: IDbContextFactory<ApplicationDbContext>, ILogger.
    /// Logic: Filters ShippingTiers based on weight and destination country.
    /// </remarks>
    public class ShippingCostCalculator : IShippingCostCalculator
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        private readonly ILogger<ShippingCostCalculator> _logger;

        public ShippingCostCalculator(IDbContextFactory<ApplicationDbContext> dbContextFactory, ILogger<ShippingCostCalculator> logger)
        {
            _dbContextFactory = dbContextFactory;
            _logger = logger;
        }

        /// <summary>
        /// Calculates the available shipping options for a given order weight and destination.
        /// </summary>
        /// <param name="totalWeightKg">The total weight of the order in kilograms.</param>
        /// <param name="destinationCountry">The destination country code (e.g., "IR").</param>
        /// <param name="destinationPostalCode">Optional: The destination postal code (currently unused, for future expansion).</param>
        /// <returns>A list of available ShippingOption objects.</returns>
        public async Task<List<ShippingOption>> GetShippingOptionsAsync(decimal totalWeightKg, string destinationCountry, string? destinationPostalCode = null)
        {
            var options = new List<ShippingOption>();
            if (totalWeightKg <= 0)
            {
                _logger.LogWarning("GetShippingOptionsAsync called with zero or negative weight: {WeightKg}. Returning no options.", totalWeightKg);
                // Or return a default option for zero weight if applicable (e.g., digital goods)
                return options; 
            }
            if (string.IsNullOrEmpty(destinationCountry))
            {
                 _logger.LogWarning("GetShippingOptionsAsync called with null or empty destination country.");
                 return options;
            }

            _logger.LogInformation("Calculating shipping options for Weight: {WeightKg} Kg, Country: {CountryCode}", totalWeightKg, destinationCountry);

            try
            {
                await using var context = await _dbContextFactory.CreateDbContextAsync();

                // Fetch active providers and their relevant tiers in one go
                var providersWithMatchingTiers = await context.ShippingProviders
                    .Where(sp => sp.IsActive)
                    .Include(sp => sp.Tiers.Where(st => 
                        st.IsActive &&
                        (st.DestinationCountry == destinationCountry || string.IsNullOrEmpty(st.DestinationCountry)) && // Match specific country or global tiers
                        totalWeightKg >= st.MinWeightKg && 
                        totalWeightKg < st.MaxWeightKg))
                    .ToListAsync();

                if (!providersWithMatchingTiers.Any())
                {
                    _logger.LogWarning("No active shipping providers found.");
                    return options;
                }

                foreach (var provider in providersWithMatchingTiers)
                {
                    if (!provider.Tiers.Any())
                    {
                        _logger.LogDebug("Provider {ProviderName} has no matching tiers for Weight: {WeightKg} Kg, Country: {CountryCode}", provider.Name, totalWeightKg, destinationCountry);
                        continue; // Skip provider if no tiers match
                    }

                    foreach (var tier in provider.Tiers)
                    {
                        options.Add(new ShippingOption
                        {
                            ShippingProviderId = provider.Id,
                            ProviderName = provider.Name,
                            ShippingTierId = tier.Id,
                            TierName = tier.Name, // e.g., "Standard (0-2kg)"
                            Cost = tier.Cost,
                            EstimatedDeliveryTime = tier.EstimatedDeliveryTime, // e.g., "3-5 days"
                            IsRecommended = false // Logic for recommendation can be added later
                        });
                    }
                }

                // Add logic to mark one as recommended (e.g., cheapest)
                if (options.Any())
                {
                    var cheapestOption = options.OrderBy(o => o.Cost).First();
                    cheapestOption.IsRecommended = true;
                }

                _logger.LogInformation("Found {Count} shipping options for Weight: {WeightKg} Kg, Country: {CountryCode}", options.Count, totalWeightKg, destinationCountry);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calculating shipping options for Weight: {WeightKg} Kg, Country: {CountryCode}", totalWeightKg, destinationCountry);
                // Return empty list or rethrow depending on desired error handling
            }

            return options;
        }
    }
}

