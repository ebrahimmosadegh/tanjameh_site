using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tanjameh.Core.Enums;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities;

public class Order : BaseEntity<long>
{
    [Required]
    public long UserId { get; set; } // Link to ApplicationUser ID
    // Removed: public ApplicationUser User { get; set; }

    [Required]
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Subtotal { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal ShippingCost { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalAmount { get; set; }

    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    // Shipping Address
    [Required]
    public int ShippingAddressId { get; set; }
    // Removed FK attribute and navigation property for Address in Core
    // public Address ShippingAddress { get; set; }

    // Billing Address (Optional, could be same as shipping)
    public int? BillingAddressId { get; set; }
    // Removed FK attribute and navigation property for Address in Core
    // public Address? BillingAddress { get; set; }

    // Payment Info (e.g., Stripe Payment Intent ID)
    [StringLength(100)]
    public string? PaymentIntentId { get; set; }

    // Navigation property for order items
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    // Could add ShippingMethod, TrackingNumber etc. later
}
