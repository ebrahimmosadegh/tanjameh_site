using Tanjameh.Features.Currency.Services;

namespace Tanjameh.BackgroundServices;

public class StartupService : IHostedService
{
    private readonly IServiceProvider _serviceProvider;

    public StartupService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var currencyService = scope.ServiceProvider.GetRequiredService<CurrencyService>();
            currencyService.RefreshConversions();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        // Handle cleanup here if necessary
        return Task.CompletedTask;
    }
}