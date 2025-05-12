using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Banner.Services;
using Tanjameh.Core.Entities;

namespace Tanjameh.Features.Admin.Banner.Pages;

public partial class Banners
{
    [Inject]
    protected IJSRuntime JSRuntime { get; set; }

    [Inject]
    protected NavigationManager NavigationManager { get; set; }

    [Inject]
    protected DialogService DialogService { get; set; }

    [Inject]
    protected TooltipService TooltipService { get; set; }

    [Inject]
    protected ContextMenuService ContextMenuService { get; set; }

    [Inject]
    protected NotificationService NotificationService { get; set; }

    [Inject]
    public AdminBannerService AdminBannerService { get; set; }

    protected IEnumerable<Core.Entities.Banner> banners;

    protected RadzenDataGrid<Core.Entities.Banner> grid0;
    protected bool isEdit = true;

    protected override async Task OnInitializedAsync()
    {
        banners = await AdminBannerService.GetBanners();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        isEdit = false;
        banner = new Core.Entities.Banner();
    }

    protected async Task EditRow(Core.Entities.Banner args)
    {
        isEdit = true;
        banner = args;
    }

    protected async Task GridDeleteButtonClick(MouseEventArgs args, Core.Entities.Banner banner)
    {
        try
        {
            if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
            {
                var deleteResult = await AdminBannerService.DeleteBanner(banner.Id);

                if (deleteResult != null)
                {
                    await grid0.Reload();
                }
            }
        }
        catch (Exception ex)
        {
            NotificationService.Notify(new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = $"Error",
                Detail = $"Unable to delete Banner"
            });
        }
    }
    protected bool errorVisible;
    protected Core.Entities.Banner banner;

    protected async Task FormSubmit()
    {
        try
        {
            var result = isEdit ? await AdminBannerService.UpdateBanner(banner.Id, banner) : await AdminBannerService.CreateBanner(banner);

            if (result != null)
            {
                await grid0.Reload();
            }

        }
        catch (Exception ex)
        {
            errorVisible = true;
        }
    }

    protected async Task CancelButtonClick(MouseEventArgs args)
    {

    }

    private IEnumerable<Enum> genderTypes = Enum.GetValues<GenderType>().Cast<Enum>();
    private IEnumerable<Enum> bannerProductType = Enum.GetValues<BannerProductType>().Cast<Enum>();
}


//RadzenDataGridColumn Color