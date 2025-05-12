using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Currency.Services;

namespace Tanjameh.Features.Admin.Currency.Pages;

public partial class CurrencyConversions
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
    public AdminCurrencyService AdminCurrencyService { get; set; }

    protected IEnumerable<Core.Entities.CurrencyConversion> currencyConversions;

    protected RadzenDataGrid<Core.Entities.CurrencyConversion> grid0;

    protected IEnumerable<Core.Entities.Currency> currenciesForFromCurrencyId;

    protected IEnumerable<Core.Entities.Currency> currenciesForToCurrencyId;


    protected override async Task OnInitializedAsync()
    {
        currencyConversions = await AdminCurrencyService.GetCurrencyConversions(new Query { Expand = "FromCurrency,ToCurrency" });

        currenciesForFromCurrencyId = await AdminCurrencyService.GetCurrencies();

        currenciesForToCurrencyId = await AdminCurrencyService.GetCurrencies();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await grid0.InsertRow(new Core.Entities.CurrencyConversion());
    }

    protected async Task GridRowUpdate(Core.Entities.CurrencyConversion args)
    {
        await AdminCurrencyService.UpdateCurrencyConversion(args.Id, args);
    }

    protected async Task GridRowCreate(Core.Entities.CurrencyConversion args)
    {
        await AdminCurrencyService.CreateCurrencyConversion(args);
        await grid0.Reload();
    }

    protected async Task EditButtonClick(MouseEventArgs args, Core.Entities.CurrencyConversion data)
    {
        await grid0.EditRow(data);
    }

    protected async Task SaveButtonClick(MouseEventArgs args, Core.Entities.CurrencyConversion data)
    {
        await grid0.UpdateRow(data);
    }

    protected async Task CancelButtonClick(MouseEventArgs args, Core.Entities.CurrencyConversion data)
    {
        grid0.CancelEditRow(data);
        await AdminCurrencyService.CancelCurrencyConversionChanges(data);
    }
}