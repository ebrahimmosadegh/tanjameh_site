using Tanjameh.BackgroundServices.ViewModel;
using Tanjameh.BackgroundServices;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;

namespace Tanjameh.Features.Admin.Category.Pages;

public partial class FetchApiCategories
{
    [Inject]
    protected DialogService DialogService { get; set; }

    [Inject]
    protected IServiceProvider ServiceProvider { get; set; }


    public async Task FetchAction()
    {
        var result = await DialogService.Confirm("آیا میخواهید دسته بندی ها را از api asos بروز کنید  ؟");

        if (result == true)
            StartNow();
    }

    public void StartNow()
    {
        StaticConfigs<AsosGetFormat>.StartWorkerService = true;
        StaticConfigs<AsosGetFormat>.GetFormat
        = new AsosGetFormat
        {
            AsosApiType = AsosApiType.Category
        };

        var allBackgroundServices = ServiceProvider.GetServices<IHostedService>();
        allBackgroundServices.FirstOrDefault(x => x.GetType() == typeof(MainWorkerService))?.StartAsync(CancellationToken.None);
    }
}
