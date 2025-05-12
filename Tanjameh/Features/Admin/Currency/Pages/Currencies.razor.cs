using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Currency.Services;

namespace Tanjameh.Features.Admin.Currency.Pages;

public partial class Currencies
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

    protected IEnumerable<Core.Entities.Currency> currencies;

    protected RadzenDataGrid<Core.Entities.Currency> grid0;

    private bool Editing = false;

    protected override async Task OnInitializedAsync()
    {
        currencies = await AdminCurrencyService.GetCurrencies();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await grid0.InsertRow(new Core.Entities.Currency());
    }

    protected async Task GridRowUpdate(Core.Entities.Currency args)
    {
        await AdminCurrencyService.UpdateCurrency(args.Id, args);
    }

    protected async Task GridRowCreate(Core.Entities.Currency args)
    {
        await AdminCurrencyService.CreateCurrency(args);
        await grid0.Reload();
    }

    protected async Task EditButtonClick(MouseEventArgs args, Core.Entities.Currency data)
    {
        await grid0.EditRow(data);
        Editing = true;
    }

    protected async Task SaveButtonClick(MouseEventArgs args, Core.Entities.Currency data)
    {
        await grid0.UpdateRow(data);
        Editing = false;
    }

    protected async Task CancelButtonClick(MouseEventArgs args, Core.Entities.Currency data)
    {
        grid0.CancelEditRow(data);
        await AdminCurrencyService.CancelCurrencyChanges(data);

        Editing = false;
    }
}