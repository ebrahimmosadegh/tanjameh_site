using Blazored.Toast.Services;
using DocumentFormat.OpenXml.EMMA;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Tanjameh.Dtos;
using Tanjameh.Features.BrandAndType.Models;
using Tanjameh.Features.Favorite.Services;

namespace Tanjameh.Features.Product.Components;

public partial class ProductCell
{
    [Inject]
    public IMediator Mediator { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }
    
    [Inject]
    public IFavoriteService FavoriteService { get; set; }
    
    [Inject]
    public IToastService ToastService { get; set; }


    [Parameter(CaptureUnmatchedValues = false), EditorRequired]
    public ProductPreviewDto ProductPreview { get; set; }


    protected async override Task OnInitializedAsync()
    {
        
    }

    private bool IsInWishList { get; set; }
    private async Task ToggleWishList()
    {
        try
        {
            if (!IsInWishList)
            {
                await FavoriteService.AddToFavoriteAsync(ProductPreview.ProductId, null, ProductPreview.Name);
                ToastService.ShowInfo("محصول به لیست علاقه مندی ها اضافه شد");
                IsInWishList = true;
            }
            else
            {
                await FavoriteService.RemoveFromFavoritesAsync(ProductPreview.ProductId, null);
                ToastService.ShowInfo("محصول از لیست علاقه مندی ها حذف شد");
                IsInWishList = false;
            }
         
        }
        catch (Exception ex)
        {
            ToastService.ShowError(ex.Message);
        }
    }

}
