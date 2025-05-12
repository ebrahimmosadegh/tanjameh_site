using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Category.Services;
using Tanjameh.Core.Entities;

namespace Tanjameh.Features.Admin.Category.Pages;

public partial class EditCategory
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

    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        category = await AdminCategoryService.GetCategoryById(Id);

        categoriesForParentCategoryId = await AdminCategoryService.GetCategories();
    }
    protected bool errorVisible;
    protected Core.Entities.Category category;

    protected IEnumerable<Core.Entities.Category> categoriesForParentCategoryId;

    protected async Task FormSubmit()
    {
        try
        {
            await AdminCategoryService.UpdateCategory(Id, category);
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