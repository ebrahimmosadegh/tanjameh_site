using Tanjameh.Core.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanjameh.Core.Entities;

public class ShippingMethod : BaseEntity<int>
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Cost { get; set; } // Base cost, could be flat rate or minimum

    public bool IsEnabled { get; set; } = true;

    // Add properties for more complex rules if needed, e.g.:
    // public decimal? MinOrderValueForFreeShipping { get; set; }
    // public decimal? MaxWeight { get; set; }
    // public ICollection<ShippingZone> ApplicableZones { get; set; } = new List<ShippingZone>();
}
