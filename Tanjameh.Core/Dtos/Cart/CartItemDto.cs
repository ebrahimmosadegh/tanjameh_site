namespace Tanjameh.Core.Dtos.Cart;

/// <summary>
/// Data Transfer Object for a shopping cart item.
/// </summary>
public class CartItemDto
{
    public int Id { get; set; } // Cart Item ID
    public int ProductId { get; set; }
    public int VariantId { get; set; }
    public string ProductName { get; set; }
    public string VariantName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string ImageUrl { get; set; }
}

