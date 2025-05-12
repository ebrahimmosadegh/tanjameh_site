// User Customer for shopping entities
using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class Customer
{
    public int Id { get; set; }

    public long UserId { get; set; }
    // public ApplicationUser User { get; set; }
    [StringLength(50)]
    public string? FirstName { get; set; }
    [StringLength(50)]
    public string? LastName { get; set; }
    [StringLength(100)]
    public string? Email { get; set; }
    [StringLength(20)]
    public string? PhoneNumber { get; set; }
    [StringLength(50)]
    public string? Country { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? CreatedTime { get; set; }
    public DateTime? LastModify { get; set; }
    public int? Rating { get; set; }
    public ICollection<CustomerAddress>? CustomerAddresses { get; set; }
    public ICollection<LegacyCustomerOrder>? CustomerOrders { get; set; } = new List<LegacyCustomerOrder>();
}

public class CustomerAddress
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    [StringLength(200)]
    [Required(ErrorMessage = "آدرس الزامی است")]
    public string Address { get; set; } = string.Empty;
    
    [StringLength(50)]
    [Required(ErrorMessage = "شهر الزامی است")]
    public string City { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string Country { get; set; } = string.Empty;
    
    [StringLength(20)]
    [Required(ErrorMessage = "کد پستی الزامی است")]
    public string ZipCode { get; set; } = string.Empty;
    
    public bool IsDefault { get; set; }
    public bool IsDeleted { get; set; }
    
    public DateTime? CreatedTime { get; set; }
    public DateTime? LastModify { get; set; }
    
    [StringLength(200)]
    public string LatinAddress { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string LatinCity { get; set; } = string.Empty;

}
