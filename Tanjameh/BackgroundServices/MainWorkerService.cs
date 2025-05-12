using Tanjameh.BackgroundServices.Api;
using Tanjameh.BackgroundServices.Api.Asos;
using Tanjameh.BackgroundServices.ViewModel;

namespace Tanjameh.BackgroundServices;

public class MainWorkerService : BackgroundService
{

    private readonly AsosApiService _asosApiService;
    private readonly DataTansferService _dataTansferService;
    private readonly ILogger<MainWorkerService> _logger;

    public MainWorkerService(AsosApiService asosApiService,
        DataTansferService dataTansferService,
            ILogger<MainWorkerService> logger)
    {
        this._asosApiService = asosApiService;
        this._dataTansferService = dataTansferService;
        this._logger = logger;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        DoWork(stoppingToken);

        return Task.CompletedTask;
    }




    private async void DoWork(CancellationToken stoppingToken)
    {
        if (stoppingToken.IsCancellationRequested || !StaticConfigs<AsosGetFormat>.StartWorkerService)
            return;

        try
        {
            await _asosApiService.StartCallApi(StaticConfigs<AsosGetFormat>.GetFormat, stoppingToken);
        }
        catch (OperationCanceledException ex)
        {
            _dataTansferService.UpdateData("all", new ServiceWorkerDataUpdate(ServiceWorkerStatusEnum.Stop, "Operaion Stop ex"));
            _logger.LogInformation(ex, "Worker Stop");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Worker Error");
            _dataTansferService.UpdateData("all", new ServiceWorkerDataUpdate(ServiceWorkerStatusEnum.Error, ex.Message));
        }
    }
}