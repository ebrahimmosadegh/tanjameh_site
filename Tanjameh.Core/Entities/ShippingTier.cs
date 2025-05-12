using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities
{
    /// <summary>
    /// Represents a specific pricing tier for a shipping provider, typically based on weight.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Defines a cost bracket for a specific shipping provider based on order weight and destination.
    /// Usage: Used during checkout to calculate shipping costs based on the total weight of the cart.
    /// Developer Notes: This entity links a provider to a specific weight range and cost. It includes fields for destination country (initially Iran) and potentially insurance levels.
    /// </remarks>
    public class ShippingTier : BaseEntity<int>
    {
        /// <summary>
        /// Foreign key to the ShippingProvider this tier belongs to.
        /// </summary>
        public int ShippingProviderId { get; set; }

        /// <summary>
        /// Navigation property to the ShippingProvider.
        /// </summary>
        public virtual ShippingProvider ShippingProvider { get; set; } = null!; // Required relationship

        /// <summary>
        /// The minimum weight (inclusive) for this tier in kilograms.
        /// Use 0 for the lowest tier.
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        public decimal MinWeightKg { get; set; }

        /// <summary>
        /// The maximum weight (exclusive) for this tier in kilograms.
        /// Use a very large number (or null, depending on design) for the highest tier if it has no upper bound.
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        public decimal MaxWeightKg { get; set; }

        /// <summary>
        /// The cost for shipping within this weight tier.
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }

        /// <summary>
        /// The currency of the shipping cost (e.g., "GBP", "USD", "IRR").
        /// Consider linking to a Currency entity if one exists.
        /// </summary>
        [StringLength(3)]
        public string CurrencyCode { get; set; } = "GBP"; // Default or fetch from config

        /// <summary>
        /// The destination country code (ISO 3166-1 alpha-2) this tier applies to.
        /// Initially "IR" for Iran. Can be expanded later.
        /// Use "*" or null for a tier applicable to all destinations (if needed).
        /// </summary>
        [StringLength(2)]
        public string DestinationCountryCode { get; set; } = "IR";

        /// <summary>
        /// Optional description for the tier (e.g., "Standard Insured", "Express").
        /// </summary>
        [StringLength(100)]
        public string? Description { get; set; }

        /// <summary>
        /// Optional field to indicate insurance level or type associated with this tier.
        /// </summary>
        [StringLength(50)]
        public string? InsuranceLevel { get; set; }

        /// <summary>
        /// Indicates if this tier is currently active and available.
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}

