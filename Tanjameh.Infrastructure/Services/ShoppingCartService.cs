using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Dtos.Cart; // Corrected: Use Core DTO
using System.Collections.Generic; // Added for List
using System.Linq; // Added for LINQ methods
using Microsoft.Extensions.Logging; // Added for ILogger

namespace Tanjameh.Infrastructure.Services;

/// <summary>
/// Implementation for IShoppingCartService.
/// </summary>
public class ShoppingCartService : IShoppingCartService
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    private readonly ILogger<ShoppingCartService> _logger;

    public ShoppingCartService(IDbContextFactory<ApplicationDbContext> contextFactory, ILogger<ShoppingCartService> logger)
    {
        _contextFactory = contextFactory;
        _logger = logger;
    }

    /// <summary>
    /// Gets user IDs who have a specific variant in their cart.
    /// </summary>
    public async Task<List<long>> GetUserIdsWithCartItemVariantAsync(int variantId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        // Find carts containing the variantId
        return await context.ShoppingCarts
                             .Include(sc => sc.Items)
                             .Where(sc => sc.Items.Any(item => item.ProductVariantId == variantId))
                             .Select(sc => sc.UserId ?? 0) // Assuming UserId is nullable long, handle null case
                             .Where(userId => userId != 0) // Filter out potential nulls converted to 0
                             .Distinct()
                             .ToListAsync();
    }

    /// <summary>
    /// Gets the items in the user's shopping cart.
    /// </summary>
    public async Task<List<CartItemDto>> GetCartItemsAsync(long userId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var cart = await context.ShoppingCarts
                                .Include(sc => sc.Items)
                                .FirstOrDefaultAsync(sc => sc.UserId == userId);

        if (cart == null)
        {
            return new List<CartItemDto>();
        }

        // Fetch product details for image URL (simplified)
        var variantIds = cart.Items.Select(i => i.ProductVariantId).ToList();
        // Corrected: Use context.ProductMediaFile (singular)
        var productMediaFiles = await context.ProductMediaFile
                                             .Include(pmf => pmf.MediaFile)
                                             // Corrected: Filter by ProductVariantId which is int?
                                             .Where(pmf => variantIds.Contains(pmf.ProductVarientId))
                                             .ToListAsync();

        return cart.Items.Select(item =>
        {
            // Find the best image URL for the variant
            var imageUrl = productMediaFiles
                            // Corrected: Filter by ProductVariantId which is int?
                            .Where(pmf => pmf.ProductVarientId == item.ProductVariantId)
                            .OrderBy(pmf => pmf.DisplayOrder)
                            .Select(pmf => pmf.MediaFile?.WebUrl)
                            .FirstOrDefault();

            // Use Core DTO
            return new CartItemDto
            {
                Id = item.Id, // Use ShoppingCartItem Id
                ProductId = item.ProductId,
                VariantId = item.ProductVariantId ?? 0,
                ProductName = item.ProductName,
                VariantName = "", // VariantName is not stored in ShoppingCartItem
                Price = item.UnitPrice,
                Quantity = item.Quantity,
                ImageUrl = imageUrl ?? "/images/placeholder.png"
            };
        }).ToList();
    }

    /// <summary>
    /// Adds an item to the user's shopping cart.
    /// </summary>
    public async Task<CartItemDto> AddToCartAsync(long userId, int productId, int variantId, string productName, string variantName, decimal price, int quantity, string imageUrl)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var cart = await context.ShoppingCarts
                                .Include(sc => sc.Items)
                                .FirstOrDefaultAsync(sc => sc.UserId == userId);

        if (cart == null)
        {
            cart = new ShoppingCart { UserId = userId };
            context.ShoppingCarts.Add(cart);
        }

        var existingItem = cart.Items.FirstOrDefault(i => i.ProductVariantId == variantId);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
            existingItem.UnitPrice = price; // Update price in case it changed
        }
        else
        {
            existingItem = new ShoppingCartItem
            {
                ProductId = productId,
                ProductVariantId = variantId,
                ProductName = productName,
                Quantity = quantity,
                UnitPrice = price,
                AddedTime = DateTime.UtcNow
                // ImageUrl is not stored, VariantName is not stored
            };
            cart.Items.Add(existingItem);
        }

        await context.SaveChangesAsync();

        // Return Core DTO based on the added/updated item
        return new CartItemDto
        {
            Id = existingItem.Id,
            ProductId = existingItem.ProductId,
            VariantId = existingItem.ProductVariantId ?? 0,
            ProductName = existingItem.ProductName,
            VariantName = variantName, // Pass through from input
            Price = existingItem.UnitPrice,
            Quantity = existingItem.Quantity,
            ImageUrl = imageUrl // Pass through from input
        };
    }

    /// <summary>
    /// Updates the quantity of an item in the user's shopping cart.
    /// </summary>
    public async Task<bool> UpdateCartItemQuantityAsync(long userId, int cartItemId, int quantity)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var cart = await context.ShoppingCarts
                                .Include(sc => sc.Items)
                                .FirstOrDefaultAsync(sc => sc.UserId == userId);

        if (cart == null) return false;

        var itemToUpdate = cart.Items.FirstOrDefault(i => i.Id == cartItemId);

        if (itemToUpdate == null) return false;

        if (quantity <= 0)
        {
            // Remove item if quantity is zero or less
            // Corrected: Remove from the cart's Items collection
            cart.Items.Remove(itemToUpdate);
            // EF Core will detect the removal when SaveChangesAsync is called
        }
        else
        {
            itemToUpdate.Quantity = quantity;
        }

        await context.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Removes an item from the user's shopping cart.
    /// </summary>
    public async Task<bool> RemoveFromCartAsync(long userId, int cartItemId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var cart = await context.ShoppingCarts
                                .Include(sc => sc.Items)
                                .FirstOrDefaultAsync(sc => sc.UserId == userId);

        if (cart == null) return false;

        var itemToRemove = cart.Items.FirstOrDefault(i => i.Id == cartItemId);

        if (itemToRemove == null) return false;

        // Corrected: Remove from the cart's Items collection
        cart.Items.Remove(itemToRemove);
        // EF Core will detect the removal when SaveChangesAsync is called
        await context.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Clears all items from the user's shopping cart.
    /// </summary>
    public async Task<bool> ClearCartAsync(long userId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var cart = await context.ShoppingCarts
                                .Include(sc => sc.Items)
                                .FirstOrDefaultAsync(sc => sc.UserId == userId);

        if (cart == null || !cart.Items.Any()) return false;

        // Corrected: Clear the cart's Items collection
        cart.Items.Clear();
        // EF Core will detect the removals when SaveChangesAsync is called
        // Optionally remove the cart itself if it should be deleted when empty
        // context.ShoppingCarts.Remove(cart);

        await context.SaveChangesAsync();
        return true;
    }
}

