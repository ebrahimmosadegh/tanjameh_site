using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Tanjameh.BackgroundServices.Constants; // For HttpClientNames
using Tanjameh.BackgroundServices.ViewModel; // For AsosProductDetailtResponse
using Tanjameh.Core.Dtos.Scraping;
using Tanjameh.Core.Interfaces.Scraping;

namespace Tanjameh.Infrastructure.Scraping.Updaters
{
    /// <summary>
    /// Implements IProductUpdater for fetching lightweight price/availability updates from ASOS (via RapidAPI).
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Fetches current price and availability for a specific ASOS product variant.
    /// Usage: Called by background update jobs and real-time validation logic.
    /// Dependencies: IHttpClientFactory, ILogger.
    /// Source: Assumes ASOS data is fetched via a configured RapidAPI endpoint.
    /// Optimization: Fetches the full product detail but only extracts variant-specific data to minimize API changes if a dedicated variant endpoint isn't available.
    /// </remarks>
    public class AsosProductUpdater : IProductUpdater
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<AsosProductUpdater> _logger;

        public string SourceName => "ASOS";

        public AsosProductUpdater(IHttpClientFactory httpClientFactory, ILogger<AsosProductUpdater> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        /// <summary>
        /// Fetches the current price and availability for a specific ASOS product variant.
        /// </summary>
        /// <param name="sourceProductId">The ASOS product ID.</param>
        /// <param name="sourceVariantId">The ASOS variant ID.</param>
        /// <returns>A VariantUpdateDto with price/availability, or null if fetching fails or variant not found.</returns>
        public async Task<object?> UpdateVariantPriceAvailabilityAsync(string sourceProductId, string sourceVariantId)
        {
            if (!long.TryParse(sourceProductId, out long productId) || !long.TryParse(sourceVariantId, out long variantId))
            {
                _logger.LogError("Invalid sourceProductId or sourceVariantId format for ASOS: P:{SourceProductId}, V:{SourceVariantId}. Expected long integers.", sourceProductId, sourceVariantId);
                return null;
            }

            _logger.LogDebug("Updating price/availability for ASOS product ID: {ProductId}, Variant ID: {VariantId}", productId, variantId);

            try
            {
                // Note: The ASOS RapidAPI endpoint used fetches full product details.
                // We fetch the whole detail and then extract the specific variant info.
                // This is less efficient than a dedicated variant endpoint but uses the existing integration.
                using HttpClient httpClient = _httpClientFactory.CreateClient(HttpClientNames.AsosRapidApi);
                var apiUrl = BuildApiUrl(productId);
                var productDetailsResponse = await httpClient.GetStringAsync(apiUrl);

                if (string.IsNullOrEmpty(productDetailsResponse) || productDetailsResponse.Contains("\"errorMessage\":\"No available product"))
                {
                    _logger.LogWarning("ASOS product ID {ProductId} not found or unavailable via API during update check.", productId);
                    // Return a DTO indicating unavailability if the whole product is gone
                    return new VariantUpdateDto { SourceVariantId = sourceVariantId, IsAvailable = false };
                }

                AsosProductDetailtResponse? productDetails = DeserializeProductDetails(productDetailsResponse);
                if (productDetails == null)
                {
                    _logger.LogError("Failed to deserialize ASOS response during update check for product ID: {ProductId}", productId);
                    return null;
                }

                // Find the specific variant within the response
                var variantData = productDetails.Variants?.FirstOrDefault(v => v.Id == variantId);
                if (variantData == null)
                {
                    _logger.LogWarning("ASOS Variant ID {VariantId} not found within Product ID {ProductId} during update check.", variantId, productId);
                    // Return a DTO indicating unavailability for this specific variant
                    return new VariantUpdateDto { SourceVariantId = sourceVariantId, IsAvailable = false };
                }

                // Map the found variant data to VariantUpdateDto
                var updateDto = new VariantUpdateDto
                {
                    SourceVariantId = variantId.ToString(),
                    Price = variantData.Price?.Current?.Value,
                    Currency = variantData.Price?.Currency,
                    IsAvailable = variantData.IsAvailable ?? false,
                    StockQuantity = variantData.IsInStock == true ? 10 : 0, // Example stock inference
                    // IsEligibleForFreeShipping - This might require product-level price, handle in calling logic if needed
                };

                _logger.LogDebug("Successfully updated price/availability for ASOS Variant ID: {VariantId}", variantId);
                return updateDto;
            }
            catch (HttpRequestException ex)
            {
                 _logger.LogError(ex, "HTTP error updating ASOS Variant ID: {VariantId} (Product ID: {ProductId})", variantId, productId);
                 return null;
            }
            catch (JsonException ex)
            {
                 _logger.LogError(ex, "JSON deserialization error updating ASOS Variant ID: {VariantId} (Product ID: {ProductId})", variantId, productId);
                 return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error updating ASOS Variant ID: {VariantId} (Product ID: {ProductId})", variantId, productId);
                return null;
            }
        }

        // Helper methods copied/adapted from AsosProductGrabber
        private string BuildApiUrl(long productId)
        {
            return $"products/v4/detail?lang=en-GB&store=COM&sizeSchema=US&currency=GBP&id={productId}";
        }

        private static AsosProductDetailtResponse? DeserializeProductDetails(string productDetailsResponse)
        {
            try
            {
                return JsonSerializer.Deserialize<AsosProductDetailtResponse>(
                    productDetailsResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Failed to deserialize product details: {ex.Message}"); // Replace with proper logging
                return null;
            }
        }
    }
}

