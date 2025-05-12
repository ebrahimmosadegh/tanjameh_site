using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Features.Admin.Weight.Services;

namespace Tanjameh.Features.Admin.Weight.Pages;

public partial class WeightSource
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

    protected IEnumerable<Core.Entities.WeightSource> weightSources;

    protected RadzenDataGrid<Core.Entities.WeightSource> grid0;

    private bool Editing = false;

    protected override async Task OnInitializedAsync()
    {
        weightSources = await WeightService.GetWeightSources();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await grid0.InsertRow(new Core.Entities.WeightSource());
    }

    protected async Task GridRowUpdate(Core.Entities.WeightSource args)
    {
        await WeightService.UpdateWeightSource(args.Id, args);
    }

    protected async Task GridRowCreate(Core.Entities.WeightSource args)
    {
        await WeightService.CreateWeightSource(args);
        await grid0.Reload();
    }

    protected async Task EditButtonClick(MouseEventArgs args, Core.Entities.WeightSource data)
    {
        await grid0.EditRow(data);
        Editing = true;
    }

    protected async Task SaveButtonClick(MouseEventArgs args, Core.Entities.WeightSource data)
    {
        await grid0.UpdateRow(data);
        Editing = false;
    }

    protected async Task CancelButtonClick(MouseEventArgs args, Core.Entities.WeightSource data)
    {
        grid0.CancelEditRow(data);
        await WeightService.CancelWeightSourceChanges(data);

        Editing = false;
    }
}