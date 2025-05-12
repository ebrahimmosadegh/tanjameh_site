using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Tanjameh.Core.Entities;
using MediatR;
using Tanjameh.Features.ShoppingCart.Queries;
using Tanjameh.Features.ShoppingCart.Commands;
using Tanjameh.BlazorServices;
using DocumentFormat.OpenXml.EMMA;
using Tanjameh.Core.Helper;
using Tanjameh.Features.Product.Commands;
using Tanjameh.Features.Product.Queries;

namespace Tanjameh.Features.ShoppingCart.Services;

public interface IShoppingCartService
{
    Task<Core.Entities.ShoppingCart?> GetCartAsync(bool fullData = false);

    Task<ShoppingCartItem> AddToCartAsync(int productId, int? productVariantId, string productName, decimal price,
        int currencyId, int quantity);

    Task UpdateQuantityAsync(int productId, int? productVariantId, int quantity);
    Task RemoveFromCartAsync(int productId, int? productVariantId);
    Task ClearCartAsync();
    Task MergeLocalCartWithUserCartAsync();
    event Action OnChange;
}

public class ShoppingCartService : IShoppingCartService
{
    private readonly ILocalStorageService _localStorage;
    private readonly AuthenticationStateProvider _authStateProvider;
    private readonly IMediator _mediator;
    private const string CartKey = "shopping_cart";

    public event Action OnChange;

    public ShoppingCartService(ILocalStorageService localStorage,
        AuthenticationStateProvider authStateProvider,
        IMediator mediator)
    {
        _localStorage = localStorage;
        _authStateProvider = authStateProvider;
        _mediator = mediator;
    }

    public async Task<Core.Entities.ShoppingCart?> GetCartAsync(bool fullData = false)
    {
        var authState = await _authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity?.IsAuthenticated == true)
        {
            var userId = long.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var cart = await _mediator.Send(new GetCartQuery(userId));
            return fullData ? await SetProductImages(cart) : cart ?? new Core.Entities.ShoppingCart();
        }
        else
        {
            var cart = await _localStorage.GetItemAsync<Core.Entities.ShoppingCart>(CartKey);
            return fullData ? await SetProductImages(cart) : cart ?? new Core.Entities.ShoppingCart();
        }
    }

    public async Task<ShoppingCartItem> AddToCartAsync(int productId, int? productVariantId, string productName,
        decimal price, int currencyId, int quantity)
    {
        var cart = await GetCartAsync();
        var existingItem =
            cart.Items.FirstOrDefault(i => i.ProductId == productId && i.ProductVariantId == productVariantId);

        var result = new ShoppingCartItem();

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
            result = existingItem;
        }
        else
        {
            //todo override this method with price api
            var updateProductExist = await _mediator.Send(new UpdateProductDetailCommand(productId));
            if (!updateProductExist)
            {
                throw new Exception("محصول موجود نیست");
            }

            var newPrice = await _mediator.Send(new ProductPriceQuery(productId));

            if (newPrice == null)
            {
                throw new Exception("محصول موجود نیست");
            }

            result = new ShoppingCartItem
            {
                ProductId = productId,
                ProductVariantId = productVariantId,
                ProductName = productName ?? "",
                UnitPrice = newPrice.Price,
                Quantity = quantity,
                CurrencyId = currencyId,
                AddedTime = DateTime.UtcNow
            };

            cart.Items.Add(result);
        }

        await SaveCartAsync(cart);
        OnChange?.Invoke();

        result.ProductThumbnailUrl =
            (await _mediator.Send(new ProductThumbnailQuery(productId))).FirstOrDefault().WebPictureUrl;

        return result;
    }

    public async Task UpdateQuantityAsync(int productId, int? productVariantId, int quantity)
    {
        var cart = await GetCartAsync();
        var item = cart.Items.FirstOrDefault(i => i.ProductId == productId && i.ProductVariantId == productVariantId);

        if (item != null)
        {
            item.Quantity = quantity;
            if (item.Quantity <= 0)
            {
                cart.Items.Remove(item);
            }
        }

        await SaveCartAsync(cart);
        OnChange?.Invoke();
    }

    public async Task RemoveFromCartAsync(int productId, int? productVariantId)
    {
        var cart = await GetCartAsync();
        var item = cart.Items.FirstOrDefault(i => i.ProductId == productId && i.ProductVariantId == productVariantId);

        if (item != null)
        {
            cart.Items.Remove(item);
        }

        await SaveCartAsync(cart);
        OnChange?.Invoke();
    }

    public async Task ClearCartAsync()
    {
        await SaveCartAsync(new Core.Entities.ShoppingCart());
        OnChange?.Invoke();
    }

    private async Task SaveCartAsync(Core.Entities.ShoppingCart cart)
    {
        var authState = await _authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            var userId = long.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _mediator.Send(new SaveCartCommand(userId, cart));
        }
        else
        {
            await _localStorage.SetItemAsync(CartKey, cart);
        }
    }

    public async Task MergeLocalCartWithUserCartAsync()
    {
        var authState = await _authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            var localCart = await _localStorage.GetItemAsync<Core.Entities.ShoppingCart>(CartKey);
            if (localCart is not null && localCart.Items.Any())
            {
                var userId = long.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                var userCart = await _mediator.Send(new GetCartQuery(userId));

                foreach (var item in localCart.Items)
                {
                    var existingItem = userCart.Items.FirstOrDefault(i =>
                        i.ProductId == item.ProductId && i.ProductVariantId == item.ProductVariantId);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += item.Quantity;
                    }
                    else
                    {
                        userCart.Items.Add(item);
                    }
                }

                await _mediator.Send(new SaveCartCommand(userId, userCart));
                await _localStorage.RemoveItemAsync(CartKey);
                OnChange?.Invoke();
            }
        }
    }


    private async Task<Core.Entities.ShoppingCart?> SetProductImages(Core.Entities.ShoppingCart? cart)
    {
        if (cart is null)
            return null;
        var productImages =
            await _mediator.Send(new ProductThumbnailQuery(cart.Items.Select(x => x.ProductId).ToArray()));
        var productVariants =
            await _mediator.Send(new ProductVariantQuery(cart.Items.Select(x => x.ProductVariantId ?? 0).ToArray()));
        foreach (var item in cart.Items)
        {
            item.ProductThumbnailUrl = productImages.FirstOrDefault(x => x.ProductId == item.ProductId).WebPictureUrl;
            var productVariant = productVariants.FirstOrDefault(x => x.Id == item.ProductVariantId);
            item.Size = productVariant?.DisplaySizeText.ToSafeString() +
                        productVariant?.SizeDescription.ToSafeString(true);
            item.Color = productVariant?.Colour.ToSafeString();
        }

        return cart;
    }
}