using System.Collections.Concurrent;
using System.Net.Http;
using Tanjameh.BackgroundServices.ViewModel;
using Tanjameh.Core.Entities;

namespace Tanjameh.BackgroundServices.Api.Asos;

internal class FileManager
{
    private readonly SemaphoreSlim _imageSemaphore = new(8, 8);
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<AsosApiService> _logger;
    private readonly DataTansferService _dataTansferService;

    public List<ProductMediaFile> ProductMediaFiles = new();
    
    public int _currentItrateTotalProductImage = 1;
    public int _downloadCount = 0;
    public FileManager(IHttpClientFactory httpClientFactory,
        ILogger<AsosApiService> logger,
        DataTansferService dataTansferService)
    {
        _httpClientFactory = httpClientFactory;
        _logger = logger;
        _dataTansferService = dataTansferService;
    }


    public async Task DownloadAndSaveImageAsync(string imageUrl, string productId, Product product,
        CancellationToken cancellationToken)
    {
        await _imageSemaphore.WaitAsync(cancellationToken);
        try
        {
            string fullImageUrl = $"{imageUrl}?wid=1400";
            string thumbnailImageUrl = $"{imageUrl}?wid=300";

            string fileKey = Guid.NewGuid().ToString();
            string? fullImagePath =
                await DownloadAndSaveImage(fullImageUrl, productId, "full", fileKey, cancellationToken);
            string? thumbnailImagePath =
                await DownloadAndSaveImage(thumbnailImageUrl, productId, "thumbnail", fileKey, cancellationToken);

            if (fullImagePath != null && thumbnailImagePath != null)
            {
                product.MainPictureFileName = thumbnailImagePath;
                ProductMediaFiles.Add(new ProductMediaFile
                {
                    ProductId = product.Id,
                    MediaFile = new MediaFile
                    {
                        Name = Path.GetFileName(fullImagePath),
                        MediaFolder = Path.GetDirectoryName(fullImagePath),
                        MediaType = MediaType.Image,
                        Extension = Path.GetExtension(fullImagePath),
                        IsThumbnial = false
                    },
                    ThumbnailFile = new MediaFile
                    {
                        Name = Path.GetFileName(thumbnailImagePath),
                        MediaFolder = Path.GetDirectoryName(thumbnailImagePath),
                        MediaType = MediaType.Image,
                        Extension = Path.GetExtension(thumbnailImagePath),
                        IsThumbnial = true
                    },
                });
            }
        }
        finally
        {
            _imageSemaphore.Release();
        }
    }

    public async Task DownloadAndSaveAdditionalImageAsync(string imageUrl, string productId, Product product,
        CancellationToken cancellationToken)
    {
        await _imageSemaphore.WaitAsync(cancellationToken);
        try
        {
            string fullImageUrl = $"{imageUrl}?wid=1400";
            string thumbnailImageUrl = $"{imageUrl}?wid=300";

            string fileKey = Guid.NewGuid().ToString();

            string? fullImagePath =
                await DownloadAndSaveImage(fullImageUrl, productId, "full", fileKey, cancellationToken);
            string? thumbnailImagePath =
                await DownloadAndSaveImage(thumbnailImageUrl, productId, "thumbnail", fileKey, cancellationToken);

            if (fullImagePath != null && thumbnailImagePath != null)
                ProductMediaFiles.Add(new ProductMediaFile
                {
                    ProductId = product.Id,
                    MediaFile = new MediaFile
                    {
                        Name = Path.GetFileName(fullImagePath),
                        MediaFolder = Path.GetDirectoryName(fullImagePath),
                        MediaType = MediaType.Image,
                        Extension = Path.GetExtension(fullImagePath),
                        IsThumbnial = false
                    },
                    ThumbnailFile = new MediaFile
                    {
                        Name = Path.GetFileName(thumbnailImagePath),
                        MediaFolder = Path.GetDirectoryName(thumbnailImagePath),
                        MediaType = MediaType.Image,
                        Extension = Path.GetExtension(thumbnailImagePath),
                        IsThumbnial = true
                    }
                });
        }
        finally
        {
            _imageSemaphore.Release();
        }
    }

    private async Task<string?> DownloadAndSaveImage(string imageUrl, string productId, string imageType,
        string? key = null, CancellationToken cancellationToken = default)
    {
        try
        {
            if (!imageUrl.StartsWith("https://"))
                imageUrl = "https://" + imageUrl;

            using var httpClient = _httpClientFactory.CreateClient();
            var imageBytes = await httpClient.GetByteArrayAsync(imageUrl, cancellationToken);
            if (string.IsNullOrEmpty(Path.GetExtension(imageUrl)))
            {
                imageUrl = imageUrl + ".webp";
            }

            string fileName =
                $"{productId}_{imageType}_{key ?? Guid.NewGuid().ToString()}{Path.GetExtension(imageUrl)}";
            string localPath = Path.Combine("wwwroot", "images", "products", fileName);
            await File.WriteAllBytesAsync(localPath, imageBytes, cancellationToken);
            PlusOneDownloadCount();
            return localPath;
        }
        catch (System.Exception ex)
        {
            _logger.LogError(ex, "Error downloading image: {ImageUrl}", imageUrl);
            return null;
        }
    }

    private readonly object _lock = new object();
    private void PlusOneDownloadCount()
    {
        lock (_lock)
        {
            _downloadCount++;
            _dataTansferService.UpdateProgress(DataTansferService.DownloadImageKey, new ProgressValue(_downloadCount,_currentItrateTotalProductImage));
        }
    }
}