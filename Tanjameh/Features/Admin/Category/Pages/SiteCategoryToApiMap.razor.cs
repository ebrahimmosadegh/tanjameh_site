using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen.Blazor;
using Radzen;
using Tanjameh.Core.Entities;
using Tanjameh.Features.Admin.Category.Services;

namespace Tanjameh.Features.Admin.Category.Pages;


public partial class SiteCategoryToApiMap
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
    public AdminCategoryService AdminCategoryService { get; set; }

    protected IEnumerable<SiteCategoryToApi> siteCategoryToApis;

    protected RadzenDataGrid<SiteCategoryToApi> grid0;

    protected List<Core.Entities.Category> categoriesForSiteCategoryId;

    protected List<Core.Entities.CategoryApi> categoryApisForApiCategoryId;
    protected override async Task OnInitializedAsync()
    {
        siteCategoryToApis = await AdminCategoryService.GetSiteCategoryToApis(new Query { Expand = "SiteCategory,ApiCategory" });

        categoriesForSiteCategoryId = (await AdminCategoryService.GetCategories()).ToList();

        categoryApisForApiCategoryId = (await AdminCategoryService.GetCategoryApis( new Query { Filter = "FullPath != null"})).ToList();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await grid0.InsertRow(new SiteCategoryToApi());
    }

    protected async Task GridDeleteButtonClick(MouseEventArgs args, SiteCategoryToApi siteCategoryToApi)
    {
        try
        {
            if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
            {
                var deleteResult = await AdminCategoryService.DeleteSiteCategoryToApi(siteCategoryToApi.Id);

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
                Detail = $"Unable to delete SiteCategoryToApi"
            });
        }
    }

    protected async Task GridRowUpdate(SiteCategoryToApi args)
    {
        await AdminCategoryService.UpdateSiteCategoryToApi(args.Id, args);
    }

    protected async Task GridRowCreate(SiteCategoryToApi args)
    {
        await AdminCategoryService.CreateSiteCategoryToApi(args);
        await grid0.Reload();
    }

    protected async Task EditButtonClick(MouseEventArgs args, SiteCategoryToApi data)
    {
        await grid0.EditRow(data);
    }

    protected async Task SaveButtonClick(MouseEventArgs args, SiteCategoryToApi data)
    {
        await grid0.UpdateRow(data);
    }

    protected async Task CancelButtonClick(MouseEventArgs args, SiteCategoryToApi data)
    {
        grid0.CancelEditRow(data);
        await AdminCategoryService.CancelSiteCategoryToApiChanges(data);
    }
}