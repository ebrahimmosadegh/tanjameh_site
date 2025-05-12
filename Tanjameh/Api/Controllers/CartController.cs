using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tanjameh.Core.Dtos.Cart;
using Tanjameh.Api.Models.Cart;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Logging;
using Tanjameh.Core.Interfaces.Scraping; // Added for IProductUpdaterResolver
using Tanjameh.Core.Dtos.Scraping; // Added for VariantUpdateDto
using System;
using System.Threading.Tasks;

namespace Tanjameh.Api.Controllers;

[Authorize] // Require authentication for all cart operations
public class CartController : BaseApiController
{
    private readonly IShoppingCartService _cartService;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    private readonly ILogger<CartController> _logger;
    private readonly IProductUpdaterResolver _updaterResolver; // Added Updater Resolver

    public CartController(
        IShoppingCartService cartService, 
        UserManager<ApplicationUser> userManager, 
        IDbContextFactory<ApplicationDbContext> contextFactory, 
        ILogger<CartController> logger,
        IProductUpdaterResolver updaterResolver) // Inject Updater Resolver
    {
        _cartService = cartService;
        _userManager = userManager;
        _contextFactory = contextFactory;
        _logger = logger;
        _updaterResolver = updaterResolver;
    }

    private long GetUserId()
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (long.TryParse(userIdClaim, out var userId))
        {
            return userId;
        }
        throw new UnauthorizedAccessException("User ID not found in token.");
    }

    // GET: api/cart
    [HttpGet]
    public async Task<ActionResult<CartResponseDto>> GetCart()
    {
        // ... (GetCart method remains the same) ...
        try
        {
            var userId = GetUserId();
            var cartItems = await _cartService.GetCartItemsAsync(userId);
            var response = new CartResponseDto
            {
                Items = cartItems,
                Subtotal = cartItems.Sum(ci => ci.Price * ci.Quantity)
            };
            return Ok(response);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving cart for user {UserId}", GetUserId());
            return StatusCode(500, "An error occurred while retrieving the cart.");
        }
    }

    // POST: api/cart
    [HttpPost]
    public async Task<IActionResult> AddToCart([FromBody] AddToCartRequestDto request)
    {
        if (request.Quantity <= 0)
        {
            return BadRequest("Quantity must be positive.");
        }

        long userId;
        try
        {
            userId = GetUserId();
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }

        await using var context = await _contextFactory.CreateDbContextAsync();
        using var transaction = await context.Database.BeginTransactionAsync(); // Use transaction for update + add

        try
        {
            // 1. Fetch Variant and Product details
            var variant = await context.ProductVariants
                                     .Include(pv => pv.Product)
                                     .Include(pv => pv.Product.ProductMediaFiles).ThenInclude(pmf => pmf.MediaFile)
                                     .FirstOrDefaultAsync(pv => pv.Id == request.VariantId);

            if (variant == null || variant.Product == null)
            {
                return NotFound("Product variant not found.");
            }

            // Check if product has necessary info for update check
            if (string.IsNullOrEmpty(variant.Product.DataSource) || !variant.Product.ApiId.HasValue || !variant.ApiId.HasValue)
            {
                _logger.LogWarning("Product {ProductId} Variant {VariantId} is missing DataSource or ApiId. Skipping real-time update check.", variant.ProductId, variant.Id);
                // Proceed without check or return error? For now, proceed but log.
            }
            else
            {
                // 2. Real-time Price/Availability Check
                var updater = _updaterResolver.GetUpdater(variant.Product.DataSource);
                if (updater == null)
                {
                    _logger.LogWarning("No updater found for DataSource: {DataSource}. Skipping real-time update check for Product {ProductId} Variant {VariantId}.", variant.Product.DataSource, variant.ProductId, variant.Id);
                    // Proceed without check or return error? For now, proceed but log.
                }
                else
                {
                    _logger.LogInformation("Performing real-time check for {DataSource} Product {ApiProductId} Variant {ApiVariantId}", 
                        variant.Product.DataSource, variant.Product.ApiId.Value.ToString(), variant.ApiId.Value.ToString());

                    var updateResult = await updater.UpdateVariantPriceAvailabilityAsync(variant.Product.ApiId.Value.ToString(), variant.ApiId.Value.ToString());

                    if (updateResult is VariantUpdateDto updateDto)
                    {
                        // 3. Handle Update Result
                        if (!updateDto.IsAvailable)
                        {
                            _logger.LogWarning("Variant {VariantId} is no longer available according to real-time check.", variant.Id);
                            // Update local status as well
                            variant.IsAvailable = false;
                            variant.AvailabilityLastCheckedUtc = DateTime.UtcNow;
                            await context.SaveChangesAsync();
                            await transaction.CommitAsync(); // Commit the availability update
                            return Conflict(new { message = "Sorry, this item is no longer available." });
                        }

                        decimal? oldPrice = variant.PriceCurrentValue;
                        if (updateDto.Price.HasValue && updateDto.Price != variant.PriceCurrentValue)
                        {
                            _logger.LogInformation("Price changed for Variant {VariantId} from {OldPrice} to {NewPrice}. Updating local record.", variant.Id, variant.PriceCurrentValue, updateDto.Price.Value);
                            variant.PriceCurrentValue = updateDto.Price.Value;
                            variant.PriceLastCheckedUtc = DateTime.UtcNow;
                            // Update availability timestamp as well, since we checked
                            variant.AvailabilityLastCheckedUtc = DateTime.UtcNow;
                            // We will save changes before calling AddToCartAsync
                        }
                        else
                        {
                             // Update timestamps even if no change detected
                             variant.PriceLastCheckedUtc = DateTime.UtcNow;
                             variant.AvailabilityLastCheckedUtc = DateTime.UtcNow;
                        }
                        // Save price/timestamp updates before adding to cart
                        await context.SaveChangesAsync(); 
                    }
                    else
                    {
                        _logger.LogError("Real-time update check failed for Variant {VariantId}. Proceeding with potentially stale data.", variant.Id);
                        // Decide policy: Proceed or block? For now, proceed but log error.
                    }
                }
            }

            // 4. Check Local Availability (redundant if real-time check passed, but good fallback)
            if (!variant.IsAvailable || (variant.StockQuantity.HasValue && variant.StockQuantity <= 0))
            {
                 return Conflict(new { message = "Sorry, this item is currently out of stock." });
            }

            // 5. Add to Cart using the potentially updated price
            var currentPrice = variant.PriceCurrentValue ?? 0m;
            if (currentPrice <= 0)
            {
                 _logger.LogWarning("Variant {VariantId} has a price of 0 or less. Check data integrity.", variant.Id);
                 // Decide policy: Allow adding for free or block? For now, block.
                 return BadRequest("Item price is invalid.");
            }

            var imageUrl = variant.Product.ProductMediaFiles
                                .Where(pmf => pmf.ProductVarientId == variant.Id || pmf.ProductVarientId == 0)
                                .OrderBy(pmf => pmf.ProductVarientId == variant.Id ? 0 : 1)
                                .ThenBy(pmf => pmf.DisplayOrder)
                                .Select(pmf => pmf.MediaFile?.WebUrl)
                                .FirstOrDefault() ?? "/images/placeholder.png";

            await _cartService.AddToCartAsync(
                userId,
                variant.ProductId,
                request.VariantId,
                variant.Product.Name,
                variant.Name ?? "",
                currentPrice, // Use the current, potentially updated price
                request.Quantity,
                imageUrl
            );

            await transaction.CommitAsync(); // Commit transaction after successful add

            // Construct response message (consider indicating price change if it happened)
            string message = "Item added to cart.";
            // We could check if the price was updated in this request scope, but it adds complexity.
            // A simpler approach is to rely on the frontend to display the current cart price.
            // if (priceChanged) { message = $"Item added to cart. Note: Price updated to {currentPrice}."; }

            return Ok(new { message = message });
        }
        catch (UnauthorizedAccessException ex)
        {
            await transaction.RollbackAsync();
            return Unauthorized(new { message = ex.Message });
        }
        catch (KeyNotFoundException ex) // If variant doesn't exist (should be caught above)
        {
            await transaction.RollbackAsync();
            return NotFound(new { message = ex.Message });
        }
        catch (DbUpdateException ex) // Catch potential DB errors during SaveChanges or AddToCartAsync
        {
            await transaction.RollbackAsync();
            _logger.LogError(ex, "Database error adding item to cart for user {UserId}", userId);
            return StatusCode(500, "An error occurred while saving cart changes.");
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            _logger.LogError(ex, "Error adding item to cart for user {UserId}", userId);
            return StatusCode(500, "An error occurred while adding the item to the cart.");
        }
    }

    // PUT: api/cart/{cartItemId}
    [HttpPut("{cartItemId:int}")]
    public async Task<IActionResult> UpdateCartItem(int cartItemId, [FromBody] UpdateCartItemRequestDto request)
    {
        // ... (UpdateCartItem method remains the same - real-time check might be added here too if needed) ...
        if (request.Quantity <= 0)
        {
             _logger.LogInformation("Updating cart item {CartItemId} to quantity {Quantity}. Will remove if <= 0.", cartItemId, request.Quantity);
        }

        try
        {
            var userId = GetUserId();
            var success = await _cartService.UpdateCartItemQuantityAsync(userId, cartItemId, request.Quantity);
            if (!success)
            {
                return NotFound("Cart item not found or does not belong to user.");
            }
            return Ok(new { message = "Cart item updated." });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
         catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (Exception ex)
        {
             _logger.LogError(ex, "Error updating cart item {CartItemId} for user {UserId}", cartItemId, GetUserId());
            return StatusCode(500, "An error occurred while updating the cart item.");
        }
    }

    // DELETE: api/cart/{cartItemId}
    [HttpDelete("{cartItemId:int}")]
    public async Task<IActionResult> RemoveFromCart(int cartItemId)
    {
        // ... (RemoveFromCart method remains the same) ...
        try
        {
            var userId = GetUserId();
            var success = await _cartService.RemoveFromCartAsync(userId, cartItemId);
             if (!success)
            {
                return NotFound("Cart item not found or does not belong to user.");
            }
            return Ok(new { message = "Item removed from cart." });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (Exception ex)
        {
             _logger.LogError(ex, "Error removing cart item {CartItemId} for user {UserId}", cartItemId, GetUserId());
            return StatusCode(500, "An error occurred while removing the item from the cart.");
        }
    }
}

