using Tanjameh.BackgroundServices.ViewModel;
using Tanjameh.BackgroundServices;
using Microsoft.AspNetCore.Components;
using Radzen;
using Tanjameh.BackgroundServices.Api;

namespace Tanjameh.Features.Admin.Product.Pages;

public partial class FetchApiProducts
{
    [Inject]
    protected DialogService DialogService { get; set; }

    [Inject]
    protected IServiceProvider ServiceProvider { get; set; }
    
    
    [Inject]
    protected DataTansferService DataTansferService { get; set; }

    int take = 100;
    int iterateCount = 1;

    protected async override Task OnInitializedAsync()
    {
        DataTansferService.ProgressUpdated += UpdateProgress;
        DataTansferService.DataUpdated += UpdateData;
    }

    public string Message = String.Empty;
    
    public ProgressValue RequestCount = new ProgressValue(0, 1);
    public ProgressValue DownloadedImage = new ProgressValue(0, 1);

    private string RequestCountUnit = "";
    private string DownloadedImageUnit = "";
    private async void UpdateData(object? sender, KeyValuePair<string, ServiceWorkerDataUpdate> e)
    {
        await InvokeAsync(() =>
        {
            Message = $"{e.Key}: {e.Value.Message}";
            StateHasChanged();
        });
    }

    private async void UpdateProgress(object? sender, KeyValuePair<string, ProgressValue> e)
    {
        await InvokeAsync(() =>
        {
            if (e.Key == DataTansferService.FetchCategoryKey)
            {
                RequestCount = e.Value;
                RequestCountUnit = $" request out of {RequestCount.Total})";
                StateHasChanged();
            }

            if (e.Key == DataTansferService.DownloadImageKey)
            {
                DownloadedImage = e.Value;
                DownloadedImageUnit = $" image out of {DownloadedImage.Total})";
                StateHasChanged();
            }
        });
    }    public async Task FetchAction()
    {
        var result = await DialogService.Confirm("آیا میخواهید محصولات را از api asos بروز کنید  ؟");

        if (result == true)
            StartNow();
    }

    public void StartNow()
    {
        StaticConfigs<AsosGetFormat>.StartWorkerService = true;
        StaticConfigs<AsosGetFormat>.GetFormat
        = new AsosGetFormat
        {
            AsosApiType = AsosApiType.ProductList,
            Take = take,
            IterateCount = iterateCount,
            StartDate = DateOnly.FromDateTime(DateTime.Now),
        };

        var allBackgroundServices = ServiceProvider.GetServices<IHostedService>();
        allBackgroundServices.FirstOrDefault(x => x.GetType() == typeof(MainWorkerService))?.StartAsync(CancellationToken.None);
    }
}
