using Blazored.Toast.Services;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Tanjameh.Core.Entities;
using Tanjameh.Dtos;
using Tanjameh.Features.Favorite.Services;
using Tanjameh.Features.Product.Commands;
using Tanjameh.Features.Product.Queries;
using Tanjameh.Features.ShoppingCart.Services;

namespace Tanjameh.Features.Product.Components;

public partial class ProductInfo
{
    [Inject]
    public IMediator Mediator { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IShoppingCartService ShoppingCartService { get; set; }
    
    [Inject]
    public IFavoriteService FavoriteService { get; set; }

    [Inject]
    public IToastService ToastService { get; set; }

    [Parameter, EditorRequired]
    public required ProductInfoDto Info { get; set; } = new ProductInfoDto();

    [Parameter, EditorRequired]
    public List<Core.Entities.ProductVariant> ProductVariants { get; set; } = new List<Core.Entities.ProductVariant>();

    [Parameter, EditorRequired]
    public required ProductWeightPriceDto ProductWeightPrice { get; set; }
    
    private ElementReference? AddtoCartModalElement { get; set; }

    public ShoppingCartItem? ShoppingCartItem { get; set; }

    public bool LoadingProductDetails = false;
    public bool AddtoCartWaiting = false;

    private string _careInfo = string.Empty;
    private string _sizeAndFit = string.Empty;
    private string _productInfo = string.Empty;

    public VariantDto? SelectedVariant { get; set; }


    protected override void OnInitialized()
    {
        base.OnInitialized();
        
        FavoriteService.OnChange += OnFavoriteChanged;
    }

    private async void OnFavoriteChanged()
    {
        await CheckFavoriteStatus();
    }

    private async void ToggleSizes()
    {
        await JSRuntime.InvokeVoidAsync("sildeToggle", "sizelist");
        await UpdateProduct();
    }

    private async ValueTask UpdateProduct()
    {
        if (ProductVariants.Count > 0)
            return;

        LoadingProductDetails = true;
        await Task.Delay(20);
        StateHasChanged();

        var result = await Mediator.Send(new UpdateProductDetailCommand(Info.Id));
        if (result == true)
        {
            await RefreshProduct(Info.Id, Info.Slug);
        }
        LoadingProductDetails = false;

        await Task.Delay(10);
        StateHasChanged();
    }


    public async void SelectVariant(int id)
    {
        await JSRuntime.InvokeVoidAsync("sildeToggle", "sizelist");
        SelectedVariant = ProductVariants.Select(x => new VariantDto(x.Id, x.DisplaySizeText, x.ApiId)).FirstOrDefault(x => x.Id == id);
        StateHasChanged();

        await JSRuntime.InvokeVoidAsync("closeAllMenu");
    }

    private async Task AddToShopCart()
    {
        if (Info != null && SelectedVariant != null)
        {
            AddtoCartWaiting = true;
            try
            {
                ShoppingCartItem = await ShoppingCartService.AddToCartAsync(Info.Id, SelectedVariant.Id, Info.Name, Info.Price, Info.PriceCurrencyId ?? 2, 1);
                await JSRuntime.InvokeVoidAsync( "tanjameh.bootstrap.modals.show", AddtoCartModalElement);

            }
            catch (Exception ex)
            {
                ToastService.ShowError(ex.Message);
            }
            finally
            {
                AddtoCartWaiting = false;
            }
            
        }
    }
    
    private bool IsInWishList { get; set; }
    private async Task ToggleWishList()
    {
        try
        {
            if (!IsInWishList)
            {
                await FavoriteService.AddToFavoriteAsync(Info.Id, SelectedVariant?.Id, Info.Name);
                ToastService.ShowInfo("محصول به لیست علاقه مندی ها اضافه شد");
                IsInWishList = true;
            }
            else
            {
                await FavoriteService.RemoveFromFavoritesAsync(Info.Id, SelectedVariant?.Id);
                ToastService.ShowInfo("محصول از لیست علاقه مندی ها حذف شد");
                IsInWishList = false;
            }
         
        }
        catch (Exception ex)
        {
            ToastService.ShowError(ex.Message);
        }
    }

    private async Task RefreshProduct(int productId, string productSlug)
    {
        var product = await Mediator.Send(new GetProductQuery(productId, productSlug));

        if (product is null)
        {
            NavigationManager.NavigateTo("/404", true);
        }
        else
        {
            ProductWeightPrice = await Mediator.Send(new ProductWeightPriceQuery(productId));

            if (product.ProductVariants is not null)
                ProductVariants = product.ProductVariants.Where(x => !x.IsDefault && x.Exist != false).ToList();

            Info = product;
            SetProductInfo();
        }
    }

    private void SetProductInfo()
    {
        _careInfo = Info.GetFullDescriptionObject()?.GetValueOrDefault("CareInfo", "") ?? "";
        _sizeAndFit = Info.GetFullDescriptionObject()?.GetValueOrDefault("SizeAndFit", "") ?? "";
        _productInfo = Info.GetFullDescriptionObject()?.GetValueOrDefault("AboutMe", Info.GetFullDescriptionObject()?.GetValueOrDefault("Info", "") ?? "") ?? "";
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Task.Delay(300);
            await JSRuntime.InvokeVoidAsync("initializeProductSingle");

            await CheckFavoriteStatus();
        }
    }

    private async Task CheckFavoriteStatus()
    {
        var lastStatus = IsInWishList;
        IsInWishList = await FavoriteService.IsInFavoritesAsync(Info.Id);
        
        if (lastStatus != IsInWishList)
            StateHasChanged();
    }

    private async Task GoToCart()
    {
        await JSRuntime.InvokeVoidAsync("tanjameh.bootstrap.modals.hide", AddtoCartModalElement);

        NavigationManager.NavigateTo("/cart");
    }
    
    
    
}
