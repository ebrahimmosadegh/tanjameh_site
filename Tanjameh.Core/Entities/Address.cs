using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities;

public class Address : BaseEntity<int>
{
    [Required]
    public long UserId { get; set; } // Link to ApplicationUser ID
    // Removed: public ApplicationUser User { get; set; }

    [Required]
    [StringLength(100)]
    public string FullName { get; set; }

    [Required]
    [StringLength(200)]
    public string StreetAddress { get; set; }

    [StringLength(100)]
    public string? ApartmentSuiteEtc { get; set; }

    [Required]
    [StringLength(50)]
    public string City { get; set; }

    [Required]
    [StringLength(50)]
    public string StateProvince { get; set; }

    [Required]
    [StringLength(20)]
    public string PostalCode { get; set; }

    [Required]
    [StringLength(50)]
    public string Country { get; set; }

    [Required]
    [StringLength(20)]
    public string PhoneNumber { get; set; }

    public bool IsDefaultShipping { get; set; } = false;
    public bool IsDefaultBilling { get; set; } = false;

    // Navigation properties for orders where this address is used
    // These might be better handled via specific queries rather than direct navigation properties in Core
    // public ICollection<Order> ShippingOrders { get; set; } = new List<Order>();
    // public ICollection<Order> BillingOrders { get; set; } = new List<Order>();
}
