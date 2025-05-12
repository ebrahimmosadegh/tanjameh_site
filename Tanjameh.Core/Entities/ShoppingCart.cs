

using System.ComponentModel.DataAnnotations.Schema;

namespace Tanjameh.Core.Entities;

public class ShoppingCart
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public long? UserId { get; set; }
    public ICollection<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
}

public class ShoppingCartItem
{
    public ShoppingCart ShoppingCart { get; set; }

    public int Id { get; set; }
    public int ProductId { get; set; }
    public int? ProductVariantId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;

    public int? CurrencyId { get; set; }

    public DateTime AddedTime { get; set; }

    [NotMapped]
    public string? ProductThumbnailUrl { get; set; }
    
    [NotMapped]
    public string? Color { get; set; }
    
    [NotMapped]
    public string? Size { get; set; }
}

