using System;

namespace Tanjameh.Core.Helper
{
    /// <summary>
    /// Utility class for generating unique internal product codes.
    /// </summary>
    public static class InternalProductCodeGenerator
    {
        /// <summary>
        /// Generates a unique internal product code based on the source and source ID.
        /// </summary>
        /// <param name="sourceName">The name of the data source (e.g., "ASOS", "ZALANDO", "NEXT").</param>
        /// <param name="sourceProductId">The unique identifier of the product on the external source platform.</param>
        /// <returns>A formatted internal product code (e.g., "ASO-123456"), or null if inputs are invalid.</returns>
        /// <remarks>
        /// Documentation:
        /// Purpose: Creates a standardized internal identifier for products based on their origin.
        /// Usage: Called during product import or update to assign the InternalProductCode.
        /// Format: Uses the first 3 letters of the source name (uppercase) followed by a hyphen and the source product ID.
        /// Example: GenerateInternalCode("ASOS", "12345678") -> "ASO-12345678"
        ///          GenerateInternalCode("Zalando", "ZA987B") -> "ZAL-ZA987B"
        /// </remarks>
        public static string? GenerateInternalCode(string? sourceName, string? sourceProductId)
        {
            if (string.IsNullOrWhiteSpace(sourceName) || string.IsNullOrWhiteSpace(sourceProductId))
            {
                return null;
            }

            // Take first 3 letters of source name, uppercase
            string prefix = sourceName.Trim().Length >= 3 
                ? sourceName.Trim().Substring(0, 3).ToUpperInvariant() 
                : sourceName.Trim().ToUpperInvariant();

            // Clean sourceProductId? For now, assume it's usable as is.
            string idPart = sourceProductId.Trim();

            return $"{prefix}-{idPart}";
        }
    }
}

