using Tanjameh.Core.Entities;
using Tanjameh.Core.Dtos.Cart; // Corrected: Use Core DTO
using System.Collections.Generic; // Added for List

namespace Tanjameh.Core.Interfaces;

/// <summary>
/// Interface for managing user shopping carts.
/// </summary>
public interface IShoppingCartService
{
    /// <summary>
    /// Gets a list of user IDs who have a specific product variant in their cart.
    /// </summary>
    /// <param name="variantId">The ID of the product variant.</param>
    /// <returns>A list of user IDs.</returns>
    Task<List<long>> GetUserIdsWithCartItemVariantAsync(int variantId);

    /// <summary>
    /// Gets the items in the user's shopping cart.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of cart items (using Core DTO).</returns>
    Task<List<CartItemDto>> GetCartItemsAsync(long userId);

    /// <summary>
    /// Adds an item to the user's shopping cart.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="productId">The ID of the product.</param>
    /// <param name="variantId">The ID of the product variant.</param>
    /// <param name="productName">The name of the product.</param>
    /// <param name="variantName">The name of the variant.</param>
    /// <param name="price">The price of the item.</param>
    /// <param name="quantity">The quantity to add.</param>
    /// <param name="imageUrl">The URL of the product image.</param>
    /// <returns>The added or updated cart item (using Core DTO).</returns>
    Task<CartItemDto> AddToCartAsync(long userId, int productId, int variantId, string productName, string variantName, decimal price, int quantity, string imageUrl);

    /// <summary>
    /// Updates the quantity of an item in the user's shopping cart.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="cartItemId">The ID of the cart item to update.</param>
    /// <param name="quantity">The new quantity.</param>
    /// <returns>True if successful, false otherwise.</returns>
    Task<bool> UpdateCartItemQuantityAsync(long userId, int cartItemId, int quantity);

    /// <summary>
    /// Removes an item from the user's shopping cart.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="cartItemId">The ID of the cart item to remove.</param>
    /// <returns>True if successful, false otherwise.</returns>
    Task<bool> RemoveFromCartAsync(long userId, int cartItemId);

    /// <summary>
    /// Clears all items from the user's shopping cart.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>True if successful, false otherwise.</returns>
    Task<bool> ClearCartAsync(long userId);
}

