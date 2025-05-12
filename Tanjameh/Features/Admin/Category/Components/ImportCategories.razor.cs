using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Tanjameh.Dtos;
using Tanjameh.Features.Admin.Category.Services;

namespace Tanjameh.Features.Admin.Category.Components;

public partial class ImportCategories : ComponentBase
{
    [Inject] protected DialogService DialogService { get; set; }
    [Inject] public AdminCategoryService AdminCategoryService { get; set; }


    protected bool errorVisible;
    protected JsonImportDto? JsonImport;


    protected override void OnInitialized()
    {
        base.OnInitialized();
        JsonImport = new JsonImportDto();
    }

    protected async Task FormSubmit()
    {
        try
        {
            var result = await AdminCategoryService.ImportCategories(JsonImport!.Content);
            if (!result)
            {
                errorVisible = true;
                return;
            }

            DialogService.Close(JsonImport);
        }
        catch (Exception ex)
        {
            errorVisible = true;
        }

        StateHasChanged();
    }

    protected async Task CancelButtonClick(MouseEventArgs args)
    {
        DialogService.Close(null);
    }
}