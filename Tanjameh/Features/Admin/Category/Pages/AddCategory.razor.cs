using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using Tanjameh.Features.Admin.Category.Services;
using Tanjameh.Core.Entities;
using System.Linq;

namespace Tanjameh.Features.Admin.Category.Pages;

public partial class AddCategory
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

    protected override async Task OnInitializedAsync()
    {
        category = new Core.Entities.Category();

        categoriesForParentCategoryId = await AdminCategoryService.GetCategories();
    }
    protected bool errorVisible;
    protected Core.Entities.Category category;

    protected IEnumerable<Core.Entities.Category> categoriesForParentCategoryId;

    protected async Task FormSubmit()
    {
        try
        {
            await AdminCategoryService.CreateCategory(category);
            DialogService.Close(category);
        }
        catch (Exception ex)
        {
            errorVisible = true;
        }
    }

    protected async Task CancelButtonClick(MouseEventArgs args)
    {
        DialogService.Close(null);
    }

    private IEnumerable<Enum> genderTypes = Enum.GetValues<GenderType>().Cast<Enum>();
}