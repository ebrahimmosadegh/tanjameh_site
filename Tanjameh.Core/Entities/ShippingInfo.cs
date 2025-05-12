// User Customer for shopping entities

using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class ShippingInfo
{
    public int Id { get; set; }
    public int CustomerOrderId { get; set; }
    
    public LegacyCustomerOrder CustomerOrder { get; set; }
    
    [StringLength(50)] public string ShippingMethod { get; set; }
    
    [StringLength(50)] public string TrackingNumber { get; set; }
    
    public DateTime? ShippedDate { get; set; }
    
    public DateTime? EstimatedDeliveryDate { get; set; }
    
    [StringLength(200)] public string ShippingAddress { get; set; }
    
    [StringLength(50)] public string ShippingCity { get; set; }
    
    [StringLength(50)] public string ShippingCountry { get; set; }
    
    [StringLength(20)] public string ShippingZipCode { get; set; }
}