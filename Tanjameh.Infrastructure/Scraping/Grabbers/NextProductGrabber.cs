using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Dtos.Scraping;
using Tanjameh.Core.Interfaces.Scraping;

namespace Tanjameh.Infrastructure.Scraping.Grabbers
{
    /// <summary>
    /// Implements IProductGrabber for fetching full product details from Next.co.uk using web scraping.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Fetches comprehensive product details from Next.co.uk for initial import.
    /// Usage: Used by import services to create new product entries.
    /// Dependencies: IHttpClientFactory, ILogger, HtmlAgilityPack.
    /// Source: Scrapes the public Next.co.uk website.
    /// **Warning:** Web scraping is fragile and may break if Next changes its website structure.
    ///          It might also violate Next's terms of service. Use with caution.
    ///          This implementation is a basic placeholder and requires significant refinement.
    /// </remarks>
    public class NextProductGrabber : IProductGrabber
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<NextProductGrabber> _logger;

        public string SourceName => "NEXT";

        public NextProductGrabber(IHttpClientFactory httpClientFactory, ILogger<NextProductGrabber> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        /// <summary>
        /// Fetches the full product details from Next.co.uk using the product's source-specific ID (or URL).
        /// </summary>
        /// <param name="sourceProductId">The Next product ID or potentially a full URL.</param>
        /// <returns>A ProductGrabberDto with full details, or null if fetching fails.</returns>
        public async Task<object?> GrabProductDetailsAsync(string sourceProductId)
        {
            // Next product URLs often contain the product ID
            string productUrl = sourceProductId; // Basic assumption, needs refinement
            if (!Uri.TryCreate(productUrl, UriKind.Absolute, out _))
            {
                // Attempt to construct a URL if just an ID is given (needs Next URL structure)
                // Example: productUrl = $"https://www.next.co.uk/style/st{sourceProductId}"; // Needs verification
                _logger.LogWarning("Treating sourceProductId as URL for Next: {ProductUrl}. If this is just an ID, URL construction logic is needed.", productUrl);
            }

            _logger.LogInformation("Grabbing full product details for Next product: {ProductUrl}", productUrl);

            try
            {
                var client = _httpClientFactory.CreateClient("DefaultScraperClient"); // Use a configured client
                // Add headers to mimic a browser if necessary
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                
                var response = await client.GetAsync(productUrl);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError("Failed to fetch Next page {ProductUrl}. Status Code: {StatusCode}", productUrl, response.StatusCode);
                    return null;
                }

                var html = await response.Content.ReadAsStringAsync();
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);

                // --- Placeholder Scraping Logic --- 
                // Requires inspecting the actual Next.co.uk product page HTML structure.
                // Selectors below are illustrative examples and WILL NOT WORK without adaptation.

                var dto = new ProductGrabberDto
                {
                    SourceProductId = sourceProductId, // Use the input ID/URL
                    ProductUrl = productUrl,
                    Name = htmlDoc.DocumentNode.SelectSingleNode("//h1[@data-testid=\'product-title\']")?.InnerText.Trim() ?? string.Empty,
                    // Brand: Next often sells its own brand or specific collaborations. May need specific logic.
                    BrandName = htmlDoc.DocumentNode.SelectSingleNode("//meta[@property=\'og:brand\']")?.GetAttributeValue("content", null) ?? "Next", // Example: Check meta tags or assume 'Next'
                    // Categories: Look for breadcrumbs
                    Categories = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, \'Breadcrumbs\')]//a")?.Select(n => n.InnerText.Trim()).ToList() ?? new List<string>(),
                    // Product Type: Might be part of the title or categories
                    // Main Image: Look for primary image tags
                    MainImageUrl = htmlDoc.DocumentNode.SelectSingleNode("//img[contains(@class, \'ProductImage\')]")?.GetAttributeValue("src", null),
                    // Variants: Often in dropdowns or specific divs/buttons
                    Variants = ParseVariantsFromHtml(htmlDoc), // Requires dedicated parsing logic
                    // Full/Short Description: Find description sections
                    ShortDescription = htmlDoc.DocumentNode.SelectSingleNode("//div[contains(@class, \'ProductDescription\')]")?.InnerText.Trim(),
                    FullDescription = htmlDoc.DocumentNode.SelectSingleNode("//div[@id=\'Composition\']")?.InnerHtml.Trim(), // Example: Composition section
                    Tags = new List<string>() // Extract tags if available
                };
                
                // Extract Product Type from categories or title if possible
                // dto.ProductType = ExtractProductType(dto.Categories, dto.Name);

                // --- End Placeholder Scraping Logic ---

                if (string.IsNullOrEmpty(dto.Name))
                {
                     _logger.LogWarning("Could not extract essential details (e.g., Name) for Next product: {ProductUrl}. Page structure might have changed.", productUrl);
                     return null; 
                }

                _logger.LogInformation("Successfully grabbed details for Next product: {ProductUrl}", productUrl);
                return dto;
            }
            catch (HttpRequestException ex)
            {
                 _logger.LogError(ex, "HTTP error grabbing details for Next product: {ProductUrl}", productUrl);
                 return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error grabbing details for Next product: {ProductUrl}", productUrl);
                return null;
            }
        }

        // Placeholder for complex variant parsing logic
        private List<ProductVariantGrabberDto> ParseVariantsFromHtml(HtmlDocument htmlDoc)
        {
            var variants = new List<ProductVariantGrabberDto>();
            _logger.LogWarning("Next variant parsing logic is a placeholder. Requires inspection of page source (HTML/JSON/Dropdowns) and implementation using HtmlAgilityPack.");

            // Example: Look for size/color dropdowns or selection buttons
            var sizeNodes = htmlDoc.DocumentNode.SelectNodes("//select[@id=\'size\']/option | //button[contains(@class, \'size-selector\')]"); // Adjust selector
            if (sizeNodes != null)
            {
                foreach(var node in sizeNodes)
                {
                    // Extract size, price (might be shared), availability from attributes or related elements
                    string? size = node.InnerText.Trim();
                    string? variantId = node.GetAttributeValue("value", null) ?? size; // Use value or text as ID
                    bool isAvailable = !node.GetAttributeValue("disabled", false);
                    
                    // Price might be static on the page or change dynamically
                    var priceNode = htmlDoc.DocumentNode.SelectSingleNode("//span[contains(@class, \'Price\')]"); // Adjust selector
                    decimal? price = ParsePrice(priceNode?.InnerText);
                    string? currency = ParseCurrency(priceNode?.InnerText);

                    if (!string.IsNullOrEmpty(size) && size.ToLower() != "select size") // Ignore placeholder options
                    {
                        variants.Add(new ProductVariantGrabberDto 
                        {
                             SourceVariantId = variantId ?? size, // Need a reliable variant ID
                             Size = size,
                             Price = price,
                             Currency = currency,
                             IsAvailable = isAvailable
                             // Color might be selected separately
                        });
                    }
                }
            }
            
            // Add logic for color variants if applicable

            return variants;
        }
        
        // Placeholder helper methods (ParsePrice, ParseCurrency - can reuse from Zalando impl.)
        private decimal? ParsePrice(string? priceText)
        {
            if (string.IsNullOrWhiteSpace(priceText)) return null;
            try
            {
                var cleaned = System.Text.RegularExpressions.Regex.Replace(priceText, @"[^0-9.,]", "");
                if (decimal.TryParse(cleaned.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal price))
                {
                    return price;
                }
            }
            catch { /* Ignore parsing errors */ }
            return null;
        }

        private string? ParseCurrency(string? priceText)
        {
             if (string.IsNullOrWhiteSpace(priceText)) return null;
             if (priceText.Contains("£")) return "GBP";
             if (priceText.Contains("€")) return "EUR";
             if (priceText.Contains("$")) return "USD";
             return null;
        }
    }
}

