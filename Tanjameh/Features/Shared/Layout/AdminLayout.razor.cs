using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;

namespace Tanjameh.Features.Shared.Layout;

public partial class AdminLayout
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

    private bool sidebarExpanded = true;

    void SidebarToggleClick()
    {
        sidebarExpanded = !sidebarExpanded;
    }

    [CascadingParameter]
    private HttpContext? HttpContext { get; set; }

    protected override void OnParametersSet()
    {
        //if (HttpContext is null)
        //{
        //    NavigationManager.Refresh(forceReload: true);
        //}
    }

    private IconStatus IconStatus { get; set; } = IconStatus.NotLoaded;

    [JSInvokable("SetIconLoaded")]
    public async Task<bool> SetIconLoaded()
    {
        IconStatus = IconStatus.Loading;
        StateHasChanged();

        await Task.Delay(50);

        IconStatus = IconStatus.Loaded;
        StateHasChanged();

        return true;
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var lDotNetReference = DotNetObjectReference.Create(this);
            await JSRuntime.InvokeVoidAsync("GLOBAL.SetDotnetReference", lDotNetReference);
            await JSRuntime.InvokeVoidAsync("initIcons");
        }


    }
}

enum IconStatus
{
    NotLoaded,
    Loading,
    Loaded
}
