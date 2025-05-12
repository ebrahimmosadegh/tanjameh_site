using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Weight.Services;
using Tanjameh.Features.Currency.Services;
using Tanjameh.Features.Admin.Currency.Services;

namespace Tanjameh.Features.Admin.Weight.Pages;

public partial class ProductWeightPrice
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
    public WeightService WeightService { get; set; }

    [Inject]
    public AdminCurrencyService CurrencyService { get; set; }

    protected IEnumerable<Core.Entities.ProductWeightPrice> productWeightPrices;

    protected RadzenDataGrid<Core.Entities.ProductWeightPrice> grid0;

    protected IEnumerable<Core.Entities.Currency> currenciesForCurrencyId;
    protected IEnumerable<Core.Entities.WeightSource> WeightSourcesForWeightId;

    private bool Editing = false;


    private bool errorVisible;
    private string errorText = "Cannot save Category";

    protected override async Task OnInitializedAsync()
    {
        productWeightPrices = await WeightService.GetProductWeightPrices();
        WeightSourcesForWeightId = await WeightService.GetWeightSources();
        currenciesForCurrencyId = await CurrencyService.GetCurrencies();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await grid0.InsertRow(new Core.Entities.ProductWeightPrice());
    }

    protected async Task GridRowUpdate(Core.Entities.ProductWeightPrice args)
    {
        try
        {
            await WeightService.UpdateProductWeightPrice(args.Id, args);
            await grid0.Reload();
        }
        catch (Exception ex)
        {
            errorText = ex.Message;
            errorVisible = true;
        }

    }

    protected async Task GridRowCreate(Core.Entities.ProductWeightPrice args)
    {
        try
        {
            await WeightService.CreateProductWeightPrice(args);
            await grid0.Reload();
        }
        catch (Exception ex)
        {
            errorText = ex.Message;
            errorVisible = true;
        }


    }

    protected async Task EditButtonClick(MouseEventArgs args, Core.Entities.ProductWeightPrice data)
    {
        await grid0.EditRow(data);
        Editing = true;
    }

    protected async Task SaveButtonClick(MouseEventArgs args, Core.Entities.ProductWeightPrice data)
    {
        await grid0.UpdateRow(data);
        Editing = false;
    }

    protected async Task CancelButtonClick(MouseEventArgs args, Core.Entities.ProductWeightPrice data)
    {
        grid0.CancelEditRow(data);
        await WeightService.CancelProductWeightPriceChanges(data);

        Editing = false;
    }
}