using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tanjameh.Api.Models.Orders;
using CoreEntities = Tanjameh.Core.Entities; // Alias for Core entities
using Tanjameh.Core.Interfaces; // Use Core interfaces
using Tanjameh.Infrastructure.Data; // Keep for DbContextFactory
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Dtos.Cart; // Corrected for CartItemDto
using Microsoft.Extensions.Logging; // Added for logging
using System.Collections.Generic; // Added for List<>
using System.Linq; // Added for LINQ
using System.Threading.Tasks; // Added for Task
using Tanjameh.Core.Interfaces.Scraping; // Added for IProductUpdaterResolver
using Tanjameh.Core.Dtos.Scraping; // Added for VariantUpdateDto
using System;

namespace Tanjameh.Api.Controllers;

[Authorize]
public class OrdersController : BaseApiController
{
    private readonly IOrderService _orderService;
    private readonly IShoppingCartService _cartService;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    private readonly ILogger<OrdersController> _logger;
    private readonly IProductUpdaterResolver _updaterResolver; // Added Updater Resolver

    public OrdersController(
        IOrderService orderService,
        IShoppingCartService cartService,
        UserManager<ApplicationUser> userManager,
        IDbContextFactory<ApplicationDbContext> contextFactory,
        ILogger<OrdersController> logger,
        IProductUpdaterResolver updaterResolver) // Inject Updater Resolver
    {
        _orderService = orderService;
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
        throw new UnauthorizedAccessException("User ID not found or invalid in token.");
    }

    // GET: api/orders
    [HttpGet]
    public async Task<ActionResult<IEnumerable<OrderSummaryDto>>> GetOrders()
    {
        // ... (GetOrders method remains the same) ...
        try
        {
            var userId = GetUserId();
            var orders = await _orderService.GetOrdersForUserAsync(userId);

            var orderSummaries = orders.Select(o => new OrderSummaryDto
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalAmount = o.TotalAmount,
                Status = o.Status,
                ItemCount = o.OrderItems.Count
            }).ToList();

            return Ok(orderSummaries);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving orders for user {UserId}", GetUserId());
            return StatusCode(500, "An error occurred while retrieving orders.");
        }
    }

    // GET: api/orders/{id:long}
    [HttpGet("{id:long}")]
    public async Task<ActionResult<OrderDetailDto>> GetOrder(long id)
    {
        // ... (GetOrder method remains the same) ...
        try
        {
            var userId = GetUserId();
            var order = await _orderService.GetOrderByIdAsync(id);

            if (order == null || order.UserId != userId)
            {
                return NotFound("Order not found or access denied.");
            }

            await using var context = await _contextFactory.CreateDbContextAsync();
            var shippingAddress = await context.Addresses.FindAsync(order.ShippingAddressId);
            var billingAddress = order.BillingAddressId.HasValue ? await context.Addresses.FindAsync(order.BillingAddressId.Value) : shippingAddress;

            var variantIds = order.OrderItems.Select(oi => oi.ProductVariantId).ToList();
            var variants = await context.ProductVariants
                                        .Include(pv => pv.Product).ThenInclude(p => p.CatalogBrand)
                                        .Include(pv => pv.Product).ThenInclude(p => p.ProductMediaFiles).ThenInclude(pmf => pmf.MediaFile)
                                        .Where(pv => variantIds.Contains(pv.Id))
                                        .ToDictionaryAsync(pv => pv.Id);

            var orderDetail = new OrderDetailDto
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                Subtotal = order.Subtotal,
                ShippingCost = order.ShippingCost,
                TotalAmount = order.TotalAmount,
                Status = order.Status,
                ShippingAddress = shippingAddress != null ? new AddressDto
                {
                    Id = shippingAddress.Id,
                    Street = shippingAddress.StreetAddress,
                    City = shippingAddress.City,
                    State = shippingAddress.StateProvince,
                    Country = shippingAddress.Country,
                    ZipCode = shippingAddress.PostalCode
                } : null,
                BillingAddress = billingAddress != null ? new AddressDto
                {
                    Id = billingAddress.Id,
                    Street = billingAddress.StreetAddress,
                    City = billingAddress.City,
                    State = billingAddress.StateProvince,
                    Country = billingAddress.Country,
                    ZipCode = billingAddress.PostalCode
                } : null,
                Items = order.OrderItems.Select(oi =>
                {
                    variants.TryGetValue(oi.ProductVariantId, out var variant);
                    var imageUrl = variant?.Product?.ProductMediaFiles
                                        .Where(pmf => pmf.ProductVarientId == variant.Id || pmf.ProductVarientId == 0)
                                        .OrderBy(pmf => pmf.ProductVarientId == variant.Id ? 0 : 1)
                                        .ThenBy(pmf => pmf.DisplayOrder)
                                        .Select(pmf => pmf.MediaFile?.WebUrl)
                                        .FirstOrDefault();

                    return new OrderItemDto
                    {
                        ProductId = oi.ProductId,
                        VariantId = oi.ProductVariantId,
                        ProductName = variant?.Product?.Name,
                        VariantName = variant?.Name,
                        PriceAtTimeOfOrder = oi.PriceAtTimeOfOrder,
                        Quantity = oi.Quantity,
                        ImageUrl = imageUrl ?? "/images/placeholder.png"
                    };
                }).ToList(),
                PaymentIntentId = order.PaymentIntentId
            };

            return Ok(orderDetail);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving order details for order {OrderId}", id);
            return StatusCode(500, "An error occurred while retrieving the order details.");
        }
    }

    /// <summary>
    /// Validates the current user's shopping cart for price and availability changes before checkout.
    /// </summary>
    /// <remarks>
    /// Documentation:
    /// Purpose: Performs a real-time check on all items in the user's cart against external sources.
    /// Usage: Call this endpoint before navigating the user to the payment gateway.
    /// Response:
    /// - 200 OK: If all items are available at their current prices. Body contains { isValid: true }.
    /// - 409 Conflict: If any items are unavailable or have price changes. Body contains details of the discrepancies.
    /// - 400 Bad Request: If the cart is empty.
    /// - 401 Unauthorized: If the user is not authenticated.
    /// - 500 Internal Server Error: For unexpected errors during validation.
    /// Note: This endpoint DOES NOT modify the cart or product data. It only reports discrepancies.
    /// </remarks>
    /// <returns>IActionResult indicating validation status and discrepancies if any.</returns>
    [HttpPost("validate-checkout")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)] // Using object for { isValid: true }
    [ProducesResponseType(typeof(CheckoutValidationResultDto), StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ValidateCheckout()
    {
        long userId;
        try
        {
            userId = GetUserId();
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }

        try
        {
            var cartItems = await _cartService.GetCartItemsAsync(userId);
            if (!cartItems.Any())
            {
                return BadRequest(new { message = "Cannot validate an empty cart." });
            }

            var discrepancies = new List<CheckoutDiscrepancyDto>();
            await using var context = await _contextFactory.CreateDbContextAsync();

            // Get all variant IDs from the cart for efficient DB query
            var variantIds = cartItems.Select(ci => ci.VariantId).Distinct().ToList();
            var variantsInDb = await context.ProductVariants
                                        .Include(pv => pv.Product) // Include Product for DataSource and ApiId
                                        .Where(pv => variantIds.Contains(pv.Id))
                                        .ToDictionaryAsync(pv => pv.Id);

            foreach (var cartItem in cartItems)
            {
                if (!variantsInDb.TryGetValue(cartItem.VariantId, out var variant))
                {
                    _logger.LogWarning("Cart item {CartItemId} refers to VariantId {VariantId} which was not found in DB during checkout validation.", cartItem.Id, cartItem.VariantId);
                    discrepancies.Add(new CheckoutDiscrepancyDto
                    {
                        CartItemId = cartItem.Id,
                        VariantId = cartItem.VariantId,
                        ProductName = cartItem.ProductName,
                        VariantName = cartItem.VariantName,
                        Issue = "Item not found",
                        Details = "This item seems to have been removed."
                    });
                    continue; // Move to the next cart item
                }

                // Check local availability first (quick check)
                if (!variant.IsAvailable || (variant.StockQuantity.HasValue && variant.StockQuantity < cartItem.Quantity))
                {
                     discrepancies.Add(new CheckoutDiscrepancyDto
                     {
                         CartItemId = cartItem.Id,
                         VariantId = cartItem.VariantId,
                         ProductName = cartItem.ProductName,
                         VariantName = cartItem.VariantName,
                         Issue = "Unavailable",
                         Details = "This item is currently out of stock."
                     });
                     continue; // No need for external check if locally unavailable
                }

                // Proceed with external check if source info is available
                if (!string.IsNullOrEmpty(variant.Product?.DataSource) && variant.Product.ApiId.HasValue && variant.ApiId.HasValue)
                {
                    var updater = _updaterResolver.GetUpdater(variant.Product.DataSource);
                    if (updater != null)
                    {
                        _logger.LogDebug("Validating checkout: Checking {DataSource} Product {ApiProductId} Variant {ApiVariantId}", 
                            variant.Product.DataSource, variant.Product.ApiId.Value.ToString(), variant.ApiId.Value.ToString());
                            
                        var updateResult = await updater.UpdateVariantPriceAvailabilityAsync(variant.Product.ApiId.Value.ToString(), variant.ApiId.Value.ToString());

                        if (updateResult is VariantUpdateDto updateDto)
                        {
                            if (!updateDto.IsAvailable)
                            {
                                discrepancies.Add(new CheckoutDiscrepancyDto
                                {
                                    CartItemId = cartItem.Id,
                                    VariantId = cartItem.VariantId,
                                    ProductName = cartItem.ProductName,
                                    VariantName = cartItem.VariantName,
                                    Issue = "Unavailable",
                                    Details = "This item just became unavailable."
                                });
                            }
                            else if (updateDto.Price.HasValue && updateDto.Price != cartItem.Price)
                            {
                                discrepancies.Add(new CheckoutDiscrepancyDto
                                {
                                    CartItemId = cartItem.Id,
                                    VariantId = cartItem.VariantId,
                                    ProductName = cartItem.ProductName,
                                    VariantName = cartItem.VariantName,
                                    Issue = "Price changed",
                                    Details = $"Price changed from {cartItem.Price:C} to {updateDto.Price.Value:C}.", // Format currency
                                    OldPrice = cartItem.Price,
                                    NewPrice = updateDto.Price.Value
                                });
                            }
                            // Update local timestamps if desired, but not critical for validation endpoint
                            // variant.PriceLastCheckedUtc = DateTime.UtcNow;
                            // variant.AvailabilityLastCheckedUtc = DateTime.UtcNow;
                        }
                        else
                        {
                            _logger.LogWarning("Checkout validation failed for Variant {VariantId} from source {DataSource}. Could not get update.", variant.Id, variant.Product.DataSource);
                            // Policy: Treat failure as potential issue? Or allow proceeding?
                            // For now, let's flag it as needing attention, but not block unless critical.
                            // discrepancies.Add(new CheckoutDiscrepancyDto { ... Issue = "Check failed" ... });
                        }
                    }
                    else
                    {
                         _logger.LogWarning("No updater found for DataSource: {DataSource}. Skipping real-time checkout validation for Variant {VariantId}.", variant.Product.DataSource, variant.Id);
                    }
                }
                else
                {
                    _logger.LogWarning("Variant {VariantId} is missing DataSource or ApiId. Skipping real-time checkout validation.", variant.Id);
                }
            }

            // await context.SaveChangesAsync(); // Only save if timestamps were updated

            if (discrepancies.Any())
            {
                _logger.LogInformation("Checkout validation found {Count} discrepancies for user {UserId}.", discrepancies.Count, userId);
                return Conflict(new CheckoutValidationResultDto { IsValid = false, Discrepancies = discrepancies });
            }
            else
            {
                _logger.LogInformation("Checkout validation successful for user {UserId}.", userId);
                return Ok(new { isValid = true });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error during checkout validation for user {UserId}", userId);
            return StatusCode(500, "An unexpected error occurred during checkout validation.");
        }
    }


    // POST: api/orders
    [HttpPost]
    public async Task<ActionResult<OrderDetailDto>> CreateOrder([FromBody] CreateOrderRequestDto request)
    {
        // *** IMPORTANT: Add a final, less intensive check here before creating the order ***
        // This acts as a safeguard in case the user delays between validation and creation,
        // or if the validation endpoint wasn't called.
        // It should primarily check local DB flags (IsAvailable, StockQuantity) 
        // rather than making external calls again.

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
        using var transaction = await context.Database.BeginTransactionAsync();

        try
        {
            // 1. Get items from the user's current cart
            var cartItems = await _cartService.GetCartItemsAsync(userId);
            if (!cartItems.Any())
            {
                return BadRequest("Cannot create an order with an empty cart.");
            }

            // *** Add Final Local Validation Loop Here ***
            var variantIds = cartItems.Select(ci => ci.VariantId).Distinct().ToList();
            var variantsInDb = await context.ProductVariants
                                        .Where(pv => variantIds.Contains(pv.Id))
                                        .ToDictionaryAsync(pv => pv.Id);
            
            foreach (var cartItem in cartItems)
            {
                if (!variantsInDb.TryGetValue(cartItem.VariantId, out var variant) || !variant.IsAvailable || (variant.StockQuantity.HasValue && variant.StockQuantity < cartItem.Quantity))
                {
                    await transaction.RollbackAsync();
                    // Return a generic error or specific item error?
                    return Conflict(new { message = $"Item '{cartItem.ProductName} - {cartItem.VariantName}' is no longer available. Please review your cart.", variantId = cartItem.VariantId });
                }
                // Optional: Check if price in cart matches current DB price (variant.PriceCurrentValue)
                if (variant.PriceCurrentValue != cartItem.Price)
                {
                     _logger.LogWarning("Price mismatch detected during final order creation check for Variant {VariantId}. Cart: {CartPrice}, DB: {DbPrice}. Proceeding with DB price.", cartItem.VariantId, cartItem.Price, variant.PriceCurrentValue);
                     // Use DB price for order creation
                     cartItem.Price = variant.PriceCurrentValue ?? cartItem.Price; // Fallback to cart price if DB price is null?
                }
            }
            // *** End Final Local Validation Loop ***

            // 2. Convert cart items to order items (using potentially updated prices from final check)
            var orderItems = cartItems.Select(ci => new CoreEntities.OrderItem
            {
                ProductId = ci.ProductId,
                ProductVariantId = ci.VariantId,
                Quantity = ci.Quantity,
                PriceAtTimeOfOrder = ci.Price // Use the price from the cart item (potentially updated in final check)
            }).ToList();

            // 3. Create the order using OrderService
            var order = await _orderService.CreateOrderAsync(userId, request.ShippingAddressId, request.BillingAddressId, orderItems);

            if (order == null)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, "Failed to create order. Please check address, cart, and try again.");
            }

            // 4. Clear the user's cart
            await _cartService.ClearCartAsync(userId);

            await transaction.CommitAsync();

            // 5. Return the created order details
            _logger.LogInformation("Order {OrderId} created successfully for user {UserId}.", order.Id, userId);
            // Return details needed by frontend (e.g., order ID, payment intent ID if applicable)
            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, new { orderId = order.Id, paymentIntentId = order.PaymentIntentId, message = "Order created successfully." });

        }
        catch (UnauthorizedAccessException ex)
        {
            await transaction.RollbackAsync();
            return Unauthorized(new { message = ex.Message });
        }
        catch (ArgumentException ex) // e.g., Invalid address ID
        {
            await transaction.RollbackAsync();
            return BadRequest(new { message = ex.Message });
        }
        catch (InvalidOperationException ex) // e.g., No shipping methods
        {
            await transaction.RollbackAsync();
            return BadRequest(new { message = ex.Message });
        }
        catch (DbUpdateException ex)
        {
            await transaction.RollbackAsync();
            _logger.LogError(ex, "Database error creating order for user {UserId}", userId);
            return StatusCode(500, "An error occurred while saving the order.");
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            _logger.LogError(ex, "Unexpected error creating order for user {UserId}", userId);
            return StatusCode(500, "An unexpected error occurred while creating the order.");
        }
    }
}

