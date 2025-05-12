using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Interfaces.Scraping;

namespace Tanjameh.Infrastructure.Scraping
{
    /// <summary>
    /// Service to resolve the appropriate IProductUpdater based on the source name.
    /// </summary>
    public interface IProductUpdaterResolver
    {
        IProductUpdater? GetUpdater(string sourceName);
    }

    public class ProductUpdaterResolver : IProductUpdaterResolver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<ProductUpdaterResolver> _logger;
        private readonly Dictionary<string, Type> _updaterRegistry;

        public ProductUpdaterResolver(IServiceProvider serviceProvider, ILogger<ProductUpdaterResolver> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;

            // Register known updaters (case-insensitive matching for source names)
            _updaterRegistry = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
            {
                { "ASOS", typeof(Updaters.AsosProductUpdater) },
                { "ZALANDO", typeof(Updaters.ZalandoProductUpdater) },
                { "NEXT", typeof(Updaters.NextProductUpdater) }
                // Add other updaters here as they are implemented
            };
            _logger.LogInformation("ProductUpdaterResolver initialized with {Count} updaters.", _updaterRegistry.Count);
        }

        /// <summary>
        /// Gets the IProductUpdater implementation for the specified source name.
        /// </summary>
        /// <param name="sourceName">The name of the data source (e.g., "ASOS", "ZALANDO").</param>
        /// <returns>An instance of IProductUpdater, or null if no updater is registered for the source.</returns>
        public IProductUpdater? GetUpdater(string sourceName)
        {
            if (string.IsNullOrEmpty(sourceName))
            {
                _logger.LogWarning("Attempted to resolve updater with null or empty source name.");
                return null;
            }

            if (_updaterRegistry.TryGetValue(sourceName, out var updaterType))
            {
                try
                {
                    // Resolve the service from the DI container
                    var updaterInstance = _serviceProvider.GetService(updaterType) as IProductUpdater;
                    if (updaterInstance == null)
                    {
                        _logger.LogError("Failed to resolve updater type {UpdaterType} from DI container for source {SourceName}. Ensure it's registered.", updaterType.FullName, sourceName);
                    }
                    else
                    {
                         _logger.LogDebug("Resolved updater {UpdaterType} for source {SourceName}.", updaterType.Name, sourceName);
                    }
                    return updaterInstance;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error resolving updater type {UpdaterType} for source {SourceName} from DI container.", updaterType.FullName, sourceName);
                    return null;
                }
            }
            else
            {
                _logger.LogWarning("No product updater registered for source: {SourceName}", sourceName);
                return null;
            }
        }
    }
}

