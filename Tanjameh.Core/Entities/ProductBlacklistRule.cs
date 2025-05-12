using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;
using Tanjameh.Core.Enums; // Assuming an enum for MatchType might be useful

namespace Tanjameh.Core.Entities
{
    /// <summary>
    /// Defines a rule for blacklisting products based on various criteria.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Specifies conditions under which a product should be considered blacklisted and potentially hidden or not imported.
    /// Usage: A collection of these rules will be evaluated against products during import or display.
    /// Developer Notes: Supports matching based on keywords in Title, Brand, Category, or specific Tags. Can be extended with more complex logic or criteria types.
    /// </remarks>
    public class ProductBlacklistRule : BaseEntity<int>
    {
        /// <summary>
        /// The field to apply the blacklist rule against.
        /// </summary>
        public BlacklistTargetField TargetField { get; set; }

        /// <summary>
        /// The type of match to perform (e.g., Contains, Exact, Regex).
        /// </summary>
        public BlacklistMatchType MatchType { get; set; }

        /// <summary>
        /// The value to match against the target field.
        /// </summary>
        [Required]
        [StringLength(255)]
        public string MatchValue { get; set; } = string.Empty;

        /// <summary>
        /// Optional description explaining the reason for this rule.
        /// </summary>
        [StringLength(500)]
        public string? Reason { get; set; }

        /// <summary>
        /// Indicates if this rule is currently active.
        /// </summary>
        public bool IsActive { get; set; } = true;
    }

    /// <summary>
    /// Specifies the product field that a blacklist rule targets.
    /// </summary>
    public enum BlacklistTargetField
    {
        Title = 0,
        Brand = 1,
        Category = 2,
        Tag = 3,
        // Add more fields as needed (e.g., Description, SKU)
    }

    /// <summary>
    /// Specifies the matching logic for a blacklist rule.
    /// </summary>
    public enum BlacklistMatchType
    {
        /// <summary>
        /// The target field must contain the MatchValue (case-insensitive).
        /// </summary>
        Contains = 0,
        /// <summary>
        /// The target field must exactly match the MatchValue (case-sensitive or insensitive based on implementation).
        /// </summary>
        Exact = 1,
        /// <summary>
        /// The target field must match the Regex pattern specified in MatchValue.
        /// </summary>
        Regex = 2,
        // Add more types as needed (e.g., StartsWith, EndsWith)
    }
}

