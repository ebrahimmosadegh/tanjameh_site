
using System.Timers;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Tanjameh.Dtos;
using Tanjameh.Features.Search.Services;

namespace Tanjameh.Features.Search.Components;

public partial class SearchBox : IDisposable
{
    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public SearchBoxService SearchBoxService { get; set; }


    [Parameter]
    [SupplyParameterFromQuery(Name = "q")]
    public string SearchText { get; set; } = "";

    private bool ShowResults { get; set; }

    private List<QuickSearchResult>? SearchResults { get; set; }

    private System.Timers.Timer debounceTimer;
    private const int DebounceDelay = 300; // میلی‌ثانیه

    protected override void OnInitialized()
    {
        debounceTimer = new System.Timers.Timer(DebounceDelay);
        debounceTimer.Elapsed += OnDebounceElapsed;
        debounceTimer.AutoReset = false;
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("initializeSearchBox");
        }
    }

    public void KeyUp(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            NavigationManager.NavigateTo("search?q=" + SearchText);
            return;
        }
    }

    public void Input(ChangeEventArgs e)
    {
        var input = e.Value.ToString();
        SearchText = input;

        debounceTimer.Stop();
        debounceTimer.Start();
    }

    private async void OnDebounceElapsed(object sender, ElapsedEventArgs e)
    {
        await InvokeAsync(async () =>
        {
            if (SearchText.Trim().Length > 2)
            {
                SearchResults = await PerformSearch(SearchText);
                ShowResults = true;
            }
            else
            {
                SearchResults = null;
                ShowResults = false;
            }
            StateHasChanged();
        });
    }

    private async Task<List<QuickSearchResult>> PerformSearch(string query)
    {
        return await SearchBoxService.AutoComplete(query);
    }

    public void Dispose()
    {
        debounceTimer?.Dispose();
    }
}
