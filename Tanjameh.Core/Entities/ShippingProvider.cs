using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities
{
    /// <summary>
    /// Represents a shipping provider (e.g., Royal Mail, DHL, Local Courier).
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Defines a shipping company that can be used for delivering orders.
    /// Usage: Used in conjunction with ShippingTier to define cost structures.
    /// Developer Notes: Contains basic information about the provider. More fields like tracking URL template, API integration details could be added later.
    /// </remarks>
    public class ShippingProvider : BaseEntity<int>
    {
        /// <summary>
        /// Name of the shipping provider.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A short description or notes about the provider.
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates if this provider is currently active and available for selection.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// The tiers (weight/price brackets) offered by this provider.
        /// </summary>
        public virtual ICollection<ShippingTier> Tiers { get; set; } = new List<ShippingTier>();
    }
}

