using Tanjameh.BackgroundServices.Api;
using Tanjameh.BackgroundServices.Api.Asos;
using Tanjameh.BackgroundServices.Constants;
using Tanjameh.BackgroundServices.ViewModel;

namespace Tanjameh.BackgroundServices;

public static class RegisterService
{
    public static void AddBackgroundServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHostedService<MainWorkerService>();
        services.AddSingleton<DataTansferService>();
        services.AddSingleton<AsosApiService>();

        var asosRapidApiConfig = configuration.GetSection(AsosRapidApiConfig.RapidApiConfig);
        services.Configure<AsosRapidApiConfig>(asosRapidApiConfig);

        services.AddHttpClient(HttpClientNames.AsosRapidApi, client =>
        {
            var config = asosRapidApiConfig.Get<AsosRapidApiConfig>();
            if (config is null)
                throw new Exception("AsosRapidApiConfig is null");
            client.BaseAddress = new Uri("https://asos2.p.rapidapi.com/");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", config.Key);
            client.DefaultRequestHeaders.Add("x-rapidapi-host", config.Host);
        });

        services.AddHttpClient(HttpClientNames.AsosApi, client =>
        {
            client.BaseAddress = new Uri("https://www.asos.com/");

            //todo use proxy in future
            //client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:118.0) Gecko/20100101 Firefox/118.0");
        });
    }
}

