using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities
{
    /// <summary>
    /// Represents a logical category derived from tags or other rules (e.g., "Sale", "New Arrivals", "Esports").
    /// These are distinct from the primary product hierarchy categories.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Defines dynamic or rule-based categories used for filtering and promotion, separate from the main structural categories.
    /// Usage: Products can be assigned to these categories based on tags, price changes (for "Sale"), or other business logic.
    /// Developer Notes: This allows for flexible grouping of products without altering the core category structure. Includes a slug for URL-friendly access.
    /// </remarks>
    public class LogicalCategory : BaseEntity<int>
    {
        /// <summary>
        /// The display name of the logical category (e.g., "Sale", "Esports Gear").
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A URL-friendly identifier for the category.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Slug { get; set; } = string.Empty;

        /// <summary>
        /// Optional description of the category.
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates if this logical category is currently active and should be used.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Join entity collection mapping Products to this LogicalCategory.
        /// </summary>
        public virtual ICollection<ProductLogicalCategory> ProductLogicalCategories { get; set; } = new List<ProductLogicalCategory>();
    }

    /// <summary>
    /// Join entity mapping Products to LogicalCategories (Many-to-Many).
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Links a Product to one or more LogicalCategories.
    /// Usage: Created/updated by the category classification system when a product matches the criteria for a logical category.
    /// Developer Notes: Standard many-to-many join table.
    /// </remarks>
    public class ProductLogicalCategory
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        public int LogicalCategoryId { get; set; }
        public virtual LogicalCategory LogicalCategory { get; set; } = null!;

        // Potential future fields: AssignedDate, Reason, etc.
    }
}

