using Tanjameh.Core.Dtos.Cart; // Use Core DTO

namespace Tanjameh.Api.Models.Cart;

// Api.Models.Cart.CartItemDto is no longer needed as we use the Core DTO directly
/*
public class CartItemDto
{
    public int ProductId { get; set; }
    public int VariantId { get; set; }
    public string? ProductName { get; set; }
    public string? VariantName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string? ImageUrl { get; set; }
}
*/

public class AddToCartRequestDto
{
    public int VariantId { get; set; }
    public int Quantity { get; set; }
}

public class UpdateCartItemRequestDto
{
    // VariantId is not needed if using cartItemId in route
    // public int VariantId { get; set; }
    public int Quantity { get; set; }
}

public class CartResponseDto
{
    // Changed to use Core DTO
    public List<Core.Dtos.Cart.CartItemDto> Items { get; set; } = new();
    public decimal Subtotal { get; set; }
    // Add other cart details like total items count if needed
}

