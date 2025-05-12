using MediatR;
using Tanjameh.BlazorServices;
using Tanjameh.Features.Favorite.Models;
using Tanjameh.Features.Product.Queries;

namespace Tanjameh.Features.Favorite.Services;

public interface IFavoriteService
{
    Task<FavoriteModel?> GetFavoritesAsync(bool fullData = false);
    Task<FavoriteItem> AddToFavoriteAsync(int productId, int? productVariantId, string productName);
    Task RemoveFromFavoritesAsync(int productId, int? productVariantId);
    
    Task<bool> IsInFavoritesAsync(int productId);
    Task ClearFavoritesAsync();
    event Action OnChange;
}

public class FavoriteService : IFavoriteService
{
    private readonly ILocalStorageService _localStorage;
    private readonly IMediator _mediator;
    private const string FavoriteKey = "favorite_list";

    public FavoriteService(ILocalStorageService localStorage,
        IMediator mediator)
    {
        _localStorage = localStorage;
        _mediator = mediator;
    }

    public async Task<FavoriteModel> GetFavoritesAsync(bool fullData = false)
    {
        var result = await _localStorage.GetItemAsync<FavoriteModel?>(FavoriteKey);
        return fullData ? await SetProductImages(result) ?? new FavoriteModel() : (result ?? new FavoriteModel());
    }

    public async Task<FavoriteItem> AddToFavoriteAsync(int productId, int? productVariantId, string productName)
    {
        var favorites = await GetFavoritesAsync();
        var existingItem =
            favorites.Items.FirstOrDefault(i => i.ProductId == productId && i.ProductVariantId == productVariantId);

        var result = new FavoriteItem();
        


        if (existingItem != null)
        {
            result = existingItem;
        }
        else
        {
            result = new FavoriteItem
            {
                ProductId = productId,
                ProductVariantId = productVariantId,
                ProductName = productName ?? "",
                AddedTime = DateTime.UtcNow,
            };

            favorites.Items.Add(result);
        }
        
        result.ProductThumbnailUrl =
            (await _mediator.Send(new ProductThumbnailQuery(productId))).FirstOrDefault().WebPictureUrl;
        
        result.ProductUrl = await _mediator.Send(new GetProductUrlQuery(productId));

        await SaveFavoriteAsync(favorites);
        OnChange?.Invoke();
        
        return result;
    }

    public async Task RemoveFromFavoritesAsync(int productId, int? productVariantId)
    {
        var favorites = await GetFavoritesAsync();
        var item = favorites.Items.FirstOrDefault(i =>
            i.ProductId == productId && (i.ProductVariantId == productVariantId || productVariantId == null));

        if (item != null)
        {
            favorites.Items.Remove(item);
        }

        await SaveFavoriteAsync(favorites);
        OnChange?.Invoke();
    }

    public async Task<bool> IsInFavoritesAsync(int productId)
    {
        var favorites = await GetFavoritesAsync();
        return favorites.Items.Any(i => i.ProductId == productId);
    }

    public async Task ClearFavoritesAsync()
    {
        await SaveFavoriteAsync(new FavoriteModel());
        OnChange?.Invoke();
    }

    public event Action OnChange;

    private async Task SaveFavoriteAsync(FavoriteModel model)
    {
        await _localStorage.SetItemAsync(FavoriteKey, model);
    }

    private async Task<FavoriteModel?> SetProductImages(FavoriteModel? favorite)
    {
        if (favorite is null)
            return null;
        var productImages =
            await _mediator.Send(new ProductThumbnailQuery(favorite.Items.Select(x => x.ProductId).ToArray()));
        foreach (var item in favorite.Items)
        {
            item.ProductThumbnailUrl = productImages.FirstOrDefault(x => x.ProductId == item.ProductId).WebPictureUrl;
        }

        return favorite;
    }
}