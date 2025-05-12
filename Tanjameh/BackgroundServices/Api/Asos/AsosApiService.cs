using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Tanjameh.BackgroundServices.ViewModel;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.BackgroundServices.Api.Asos;

public partial class AsosApiService
{
    //private readonly string _imageSavePath = "path/to/your/image/directory";
    private readonly DataTansferService _asosDataTansferService;
    private readonly ILogger<AsosApiService> _logger;
    private readonly IOptions<AsosRapidApiConfig> _configs;
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly AsosApiServiceHelper _helper;
    private readonly FileManager _fileManager;



    public AsosApiService(
        DataTansferService asosDataTansferService,
        ILogger<AsosApiService> logger,
        IOptions<AsosRapidApiConfig> configs,
        IDbContextFactory<ApplicationDbContext> dbContextFactory,
        IHttpClientFactory httpClientFactory)
    {
        _asosDataTansferService = asosDataTansferService;
        _logger = logger;
        _configs = configs;
        _dbContextFactory = dbContextFactory;
        _httpClientFactory = httpClientFactory;

        _helper = new AsosApiServiceHelper(dbContextFactory);
        _helper.InitProductTypeIdMap();

        _fileManager = new FileManager(httpClientFactory, logger, asosDataTansferService);
    }


    public Task StartCallApi(AsosGetFormat asosGetFormat, CancellationToken cancellationToken)
        =>
            asosGetFormat.AsosApiType switch
            {
                AsosApiType.ProductList => CallProductListApi(asosGetFormat, cancellationToken),
                AsosApiType.Category => CallCategoryApi(asosGetFormat, cancellationToken),
                AsosApiType.ProductDetail => throw new NotImplementedException(),
                AsosApiType.Country => throw new NotImplementedException(),
                AsosApiType.Price => throw new NotImplementedException(),
                _ => throw new NotImplementedException()
            };
}

//todo color variant
//{
//      "products": [{ "productId": 205944487 }, { "productId": 205944558 }],
//      "type": "SupplierColour"
//    }