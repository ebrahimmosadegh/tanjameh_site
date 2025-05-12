using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Category.Components;
using Tanjameh.Features.Admin.Category.Services;


namespace Tanjameh.Features.Admin.Category.Pages;


public partial class Categories
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

    protected IEnumerable<Core.Entities.Category> categories;

    protected RadzenDataGrid<Core.Entities.Category> grid0;
    protected override async Task OnInitializedAsync()
    {
        categories = await AdminCategoryService.GetCategories(new Query { Expand = "ParentCategory" });
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await DialogService.OpenAsync<AddCategory>("Add Category", null);
        await grid0.Reload();
    }
    
    protected async Task ImportButtonClick(MouseEventArgs args)
    {
        await DialogService.OpenAsync<ImportCategories>("Import Category", null);
        await grid0.Reload();
    }


    protected async Task EditRow(Core.Entities.Category args)
    {
        await DialogService.OpenAsync<EditCategory>("Edit Category", new Dictionary<string, object> { { "Id", args.Id } });
    }

    protected async Task GridDeleteButtonClick(MouseEventArgs args, Core.Entities.Category category)
    {
        try
        {
            if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
            {
                var deleteResult = await AdminCategoryService.DeleteCategory(category.Id);

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
                Detail = $"Unable to delete Category"
            });
        }
    }
}

