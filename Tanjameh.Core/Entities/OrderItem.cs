using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities;

public class OrderItem : BaseEntity<long>
{
    [Required]
    public long OrderId { get; set; }
    // Removed: public Order Order { get; set; }

    [Required]
    public int ProductId { get; set; }
    // Removed: public Product Product { get; set; }

    [Required]
    public int ProductVariantId { get; set; } // Added missing property
    // TODO: Consider adding navigation property for ProductVariant if needed
    // public ProductVariant ProductVariant { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PriceAtTimeOfOrder { get; set; }

}

