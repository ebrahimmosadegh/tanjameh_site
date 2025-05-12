using Microsoft.EntityFrameworkCore;
using Tanjameh.BackgroundServices.Constants;
using Tanjameh.BackgroundServices.ViewModel;
using Tanjameh.Core.Constants;
using Tanjameh.Core.Entities;
using System.Collections.Concurrent;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Core.Helper;

namespace Tanjameh.BackgroundServices.Api.Asos;

public partial class AsosApiService
{
    private readonly object _lock = new();

    private int? _currentItrateTotalProductImage = null;

    private async Task CallProductListApi(AsosGetFormat asosGetFormat, CancellationToken cancellationToken)
    {
        using HttpClient httpClient = _httpClientFactory.CreateClient(HttpClientNames.AsosApi);
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        try
        {
            var categoryApis = await GetFilteredCategoryApis(dbContext, cancellationToken);
            var imageDownloadTasks = new ConcurrentBag<Task>();

            var categoriesCount = categoryApis.Count() * asosGetFormat.IterateCount;
            int steps = 1;
            foreach (var category in categoryApis)
            {
                int? totalProducts = null;
                bool lastItrate = false;

                for (int i = 0; i < asosGetFormat.IterateCount; i++)
                {
                    _asosDataTansferService.UpdateProgress(DataTansferService.FetchCategoryKey,
                        new ProgressValue(steps, categoriesCount));
                    steps++;

                    asosGetFormat.Skip = i * asosGetFormat.Take;

                    if (totalProducts != null && asosGetFormat.Skip + asosGetFormat.Take > totalProducts)
                    {
                        asosGetFormat.Take = asosGetFormat.IterateCount - asosGetFormat.Skip;
                        steps -= asosGetFormat.IterateCount - i - 1;
                        lastItrate = true;
                    }

                    var queryParams = BuildQueryParams(asosGetFormat);
                    if (category.ApiId == null)
                    {
                        _logger.LogWarning("api category id is null,  {CategoryDbId}", category.Id);
                        continue;
                    }

                    var url = BuildApiUrl(category.ApiId.Value, queryParams);
                    var response = await FetchProductListResponse(httpClient, url, cancellationToken);
                    totalProducts = response?.ItemCount;

                    SetCatgoryIdOnApiResult(category, response);

                    if (response?.Products != null)
                    {
                        await ProcessProducts(dbContext, response.Products, imageDownloadTasks, cancellationToken);
                    }


                    await dbContext.SaveChangesAsync(cancellationToken);
                    await Task.WhenAll(imageDownloadTasks);

                    await dbContext.ProductMediaFile.AddRangeAsync(_fileManager.ProductMediaFiles);
                    _fileManager.ProductMediaFiles = new List<ProductMediaFile>();
                }

                await dbContext.SaveChangesAsync(cancellationToken);

                if (lastItrate)
                    break;
            }
        }
        catch (Exception ex)
        {
            _asosDataTansferService.UpdateData("ex",
                new ServiceWorkerDataUpdate(ServiceWorkerStatusEnum.Error, ex.Message));
            LogError(ex);
            throw;
        }

        _asosDataTansferService.UpdateData("done", new ServiceWorkerDataUpdate(ServiceWorkerStatusEnum.None, "done"));
    }

    private void SetCatgoryIdOnApiResult(CategoryApi category, AsosApiProductListResponse? response)
    {
        foreach (var product in response?.Products ?? Enumerable.Empty<AsosApiProduct>())
        {
            product.ApiCategoryId = category.ApiId;
            product.ApiCategoryGenderTypeId = category.GenderTypeId;
        }
    }

    private async Task<List<CategoryApi>> GetFilteredCategoryApis(ApplicationDbContext dbContext,
        CancellationToken cancellationToken)
    {
        var categoryApis = await dbContext.CategoryApis.Where(x => x.ApiId != null).ToListAsync(cancellationToken);

        var existCategoryId = await dbContext.SiteCategoryToApis.AsNoTracking().Select(x => x.ApiCategoryId)
            .ToListAsync(cancellationToken);

        categoryApis = categoryApis.Where(x => existCategoryId.Contains(x.Id)).DistinctBy(x => x.ApiId).ToList();

        //todo temp limit
        //categoryApis = categoryApis.Take(4).ToList();
        return categoryApis;
    }

    private Dictionary<string, string> BuildQueryParams(AsosGetFormat asosGetFormat)
    {
        var queryParams = new Dictionary<string, string>
        {
            { "country", "GB" },
            { "lang", "en-GB" },
            { "store", "COM" },
            { "currency", "GBP" },
            { "offset", asosGetFormat.Skip.ToString() },
            { "limit", asosGetFormat.Take.ToString() },
            //{"categoryId", category.ApiId.ToString()},
        };

        if (asosGetFormat.AdditionalFilters != null)
        {
            foreach (var filter in asosGetFormat.AdditionalFilters)
            {
                queryParams.Add(filter.Key, filter.Value);
            }
        }

        if (!queryParams.ContainsKey("sort"))
        {
            queryParams.Add("sort", "freshness");
        }

        return queryParams;
    }

    private string BuildApiUrl(long categoryId, Dictionary<string, string> queryParams)
    {
        var queryString = string.Join("&", queryParams.Select(x => $"{x.Key}={x.Value}"));
        return $"api/product/search/v2/categories/{categoryId}?{queryString}";
    }

    private async Task<AsosApiProductListResponse?> FetchProductListResponse(HttpClient httpClient, string url,
        CancellationToken cancellationToken)
    {
        return await httpClient.GetFromJsonAsync<AsosApiProductListResponse>(url, cancellationToken);
    }

    private async Task ProcessProducts(ApplicationDbContext dbContext, List<AsosApiProduct> products,
        ConcurrentBag<Task> imageDownloadTasks, CancellationToken cancellationToken)
    {
        var productIds = products.Select(x => x.Id).ToList();
        var existingProducts = await dbContext.Products.Where(x => productIds.Contains(x.ApiId.Value))
            .ToListAsync(cancellationToken);

        List<int> updatedProductIds = new();

        _fileManager._downloadCount = 0;
        _currentItrateTotalProductImage = products.Sum((x => (x.AdditionalImageUrls?.Count() * 2) + 2));
        _fileManager._currentItrateTotalProductImage = _currentItrateTotalProductImage ?? 1;

        foreach (var product in products)
        {
            var existingProduct = existingProducts.FirstOrDefault(x => x.ApiId == product.Id);
            if (existingProduct != null)
            {
                await UpdateExistingProduct(dbContext, existingProduct, product, imageDownloadTasks, cancellationToken);
                updatedProductIds.Add(existingProduct.Id);
            }
            else
            {
                await AddNewProduct(dbContext, product, imageDownloadTasks, cancellationToken);
            }
        }

        var notExistProducts = existingProducts.Where(x => !updatedProductIds.Contains(x.Id)).ToList();

        foreach (var notExistProduct in notExistProducts)
        {
            notExistProduct.Exist = false;
        }
    }

    private async Task UpdateExistingProduct(ApplicationDbContext dbContext, Product existingProduct,
        AsosApiProduct product, ConcurrentBag<Task> imageDownloadTasks, CancellationToken cancellationToken)
    {
        await UpdateProductDetails(dbContext, existingProduct, product, cancellationToken);
        await UpdateRawProductData(dbContext, product, cancellationToken);
        // AddImageDownloadTasks(imageDownloadTasks, product, existingProduct, cancellationToken);
    }

    private async Task UpdateProductDetails(ApplicationDbContext dbContext, Product existingProduct,
        AsosApiProduct product, CancellationToken cancellationToken)
    {
        existingProduct.Name = product.Name!;
        existingProduct.Price = product.Price!.Current!.Value;
        existingProduct.OldPrice = product.Price.Previous?.Value;
        existingProduct.ShortDescription = product.Name!;
        existingProduct.CatalogBrandId = await GetOrCreateBrandId(dbContext, product.BrandName!, cancellationToken);
        existingProduct.GenderTypeId = product.ApiCategoryGenderTypeId;
        existingProduct.ProductTypeId = _helper.FindFirstProductTypeInSentence(product.Name ?? "");
        existingProduct.UpdatedOnUtc = DateTime.UtcNow;
        //todo 
        existingProduct.PriceCurrencyId = 2;

        var productVariants = existingProduct.ProductVariants?.FirstOrDefault(x => x.IsDefault);
        if (productVariants != null)
        {
            CreateOrUpdateDefaultVariant(productVariants, product);
        }
        else
        {
            existingProduct.ProductVariants?.Add(CreateOrUpdateDefaultVariant(null, product));
        }

        var categoryId = await GetCategoryId(dbContext, product, cancellationToken);
        var existCategory = existingProduct.ProductCategories.FirstOrDefault(x => x.CategoryId == categoryId);

        if (existCategory is null)
        {
            existingProduct.ProductCategories.Add(new ProductCategory { CategoryId = categoryId });
        }
    }

    private ProductVariant CreateOrUpdateDefaultVariant(ProductVariant? existProductVariant, AsosApiProduct product)
    {
        ProductVariant? productVariant = null;

        if (productVariant is null)
        {
            productVariant = new ProductVariant()
            {
                IsDefault = true
            };
        }

        productVariant.Colour = product.Colour?.ToLower();
        productVariant.ColourWayId = product.ColourWayId;

        return productVariant;
    }

    private async Task UpdateRawProductData(ApplicationDbContext dbContext, AsosApiProduct product,
        CancellationToken cancellationToken)
    {
        var existingRawData =
            await dbContext.RawProductData.FirstOrDefaultAsync(
                x => x.ApiProductId == product.Id && x.ApiName == ApiNames.Asos, cancellationToken);
        if (existingRawData != null)
        {
            existingRawData.RawListData = System.Text.Json.JsonSerializer.Serialize(product);

            if (!string.IsNullOrEmpty(existingRawData.RawListData) && product.ApiCategoryId != null)
            {
                var cats = existingRawData.ApiCategoryIds.Split(',').ToList();
                if (!cats.Contains(product.ApiCategoryId.ToString()))
                {
                    cats.Add(product.ApiCategoryId.ToString());

                    existingRawData.ApiCategoryIds = string.Join(',', cats);
                }
            }
        }
        else
        {
            var newRawProductData = new RawProductData
            {
                ApiProductId = product.Id,
                RawListData = System.Text.Json.JsonSerializer.Serialize(product),
                ApiName = ApiNames.Asos,
                ApiCategoryIds = product.ApiCategoryId.ToString()
            };
            dbContext.RawProductData.Add(newRawProductData);
        }
    }

    private async Task AddNewProduct(ApplicationDbContext dbContext, AsosApiProduct product,
        ConcurrentBag<Task> imageDownloadTasks, CancellationToken cancellationToken)
    {
        var newProduct = await CreateNewProduct(dbContext, product, cancellationToken);
        dbContext.Products.Add(newProduct);

        await AddProductCategories(dbContext, newProduct, product, cancellationToken);
        AddRawProductData(dbContext, product);
        AddImageDownloadTasks(imageDownloadTasks, product, newProduct, cancellationToken);
    }

    private async Task<Product> CreateNewProduct(ApplicationDbContext dbContext, AsosApiProduct product,
        CancellationToken cancellationToken)
    {
        //todo set price currency
        var result = new Product
        {
            Name = product.Name!,
            Price = product.Price!.Current!.Value,
            OldPrice = product.Price.Previous?.Value,
            ApiId = product.Id,

            ShortDescription = product.Name!,
            CatalogBrandId = await GetOrCreateBrandId(dbContext, product.BrandName!, cancellationToken),
            GenderTypeId = product.ApiCategoryGenderTypeId,

            //todo check PriceCurrency base on values
            PriceCurrencyId = 2,

            ProductTypeId = _helper.FindFirstProductTypeInSentence(product.Name ?? ""),
            UpdatedOnUtc = DateTime.UtcNow,

            Hidden = true,
        };


        result.ProductCategories.Add(new ProductCategory
            { CategoryId = await GetCategoryId(dbContext, product, cancellationToken) });

        result.ProductVariants?.Add(CreateOrUpdateDefaultVariant(null, product));

        return result;
    }


    private void AddRawProductData(ApplicationDbContext dbContext, AsosApiProduct product)
    {
        var rawProductData = new RawProductData
        {
            ApiProductId = product.Id,
            RawListData = System.Text.Json.JsonSerializer.Serialize(product),
            ApiName = ApiNames.Asos
        };

        dbContext.RawProductData.Add(rawProductData);
    }

    #region Category

    private async Task<int> GetCategoryId(ApplicationDbContext dbContext, AsosApiProduct product,
        CancellationToken cancellationToken)
    {
        return (await dbContext.SiteCategoryToApis.Include(x => x.ApiCategory)
            .FirstAsync(b => b.ApiCategory.ApiId == product.ApiCategoryId, cancellationToken)).SiteCategoryId;
    }

    private async Task AddProductCategories(ApplicationDbContext dbContext, Product newProduct, AsosApiProduct product,
        CancellationToken cancellationToken)
    {
        var siteCategoryToApi = await dbContext.SiteCategoryToApis
            .Where(x => x.ApiCategoryId == product.ApiCategoryId && x.ApiCategory.ApiName == ApiNames.Asos)
            .ToListAsync(cancellationToken);

        foreach (var mapping in siteCategoryToApi)
        {
            var productCategory = new ProductCategory
            {
                Product = newProduct,
                CategoryId = mapping.SiteCategoryId
            };


            var sCateogry = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == mapping.SiteCategoryId);
            while (sCateogry != null)
            {
                sCateogry = sCateogry.ParentCategory;

                if (sCateogry != null)
                {
                    newProduct.ProductCategories.Add(new ProductCategory
                    {
                        Product = newProduct,
                        CategoryId = sCateogry.Id
                    });
                }
            }


            newProduct.ProductCategories.Add(productCategory);
        }
    }

    private async Task<int> GetOrCreateBrandId(ApplicationDbContext dbContext, string brandName,
        CancellationToken cancellationToken)
    {
        var brand = await dbContext.CatalogBrands.FirstOrDefaultAsync(b => b.Name == brandName, cancellationToken);
        if (brand == null)
        {
            brand = new CatalogBrand { Name = brandName, Slug = brandName.ToSlug() };
            dbContext.Set<CatalogBrand>().Add(brand);
            await dbContext.SaveChangesAsync(cancellationToken);
        }

        return brand.Id;
    }

    #endregion

    #region ManageFile

    private void AddImageDownloadTasks(ConcurrentBag<Task> imageDownloadTasks, AsosApiProduct product,
        Product dbProduct, CancellationToken cancellationToken)
    {
        imageDownloadTasks.Add(_fileManager.DownloadAndSaveImageAsync(product.ImageUrl, product.Id.ToString(),
            dbProduct, cancellationToken));

        if (product.AdditionalImageUrls != null)
        {
            foreach (var additionalImageUrl in product.AdditionalImageUrls)
            {
                imageDownloadTasks.Add(_fileManager.DownloadAndSaveAdditionalImageAsync(additionalImageUrl,
                    product.Id.ToString(), dbProduct, cancellationToken));
            }
        }
    }

    #endregion

    private void LogError(Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}