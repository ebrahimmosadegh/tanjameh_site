using Microsoft.EntityFrameworkCore;
using Tanjameh.BackgroundServices.Constants;
using Tanjameh.BackgroundServices.ViewModel;
using Tanjameh.Core.Entities;

namespace Tanjameh.BackgroundServices.Api.Asos;

public partial class AsosApiService
{
    private async Task CallCategoryApi(AsosGetFormat asosGetFormat, CancellationToken cancellationToke)
    {

        using HttpClient httpClient = _httpClientFactory.CreateClient(HttpClientNames.AsosRapidApi);
        try
        {
            var result = await httpClient.GetFromJsonAsync<AsosCategoryResponse>("categories/list?country=GB&lang=en-GB&store=COM");

            if (result is null)
                return;

            using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToke))
            {
                var dbCategories = await dbContext.CategoryApis.Include(x => x.SubCategories).ToListAsync();

                var dbCategoriesCount = dbCategories.Count();

                SetCatData(result.Navigation, dbCategories);

                if (dbCategoriesCount == 0)
                    await dbContext.AddRangeAsync(dbCategories);

                await dbContext.SaveChangesAsync(cancellationToke);
            }


        }
        catch (Exception ex)
        {
            //todo make update data name const
            _asosDataTansferService.UpdateData("asosCategory", new ServiceWorkerDataUpdate(ServiceWorkerStatusEnum.Error, ex.Message));
        }

    }

    private static void SetCatData(List<MenuItem> menuItems, IList<CategoryApi> dbCategories)
    {
        foreach (var menuItem in menuItems)
        {


            if (menuItem.Link?.LinkType == "category")
            {
                if (menuItem?.Link?.WebUrl == null)
                    continue;

                GenderType gender = GenderType.None;
                var webUrl = menuItem.Link.WebUrl.Replace("https://www.asos.com/", "");
                var urlParts = webUrl.Split('/').ToList();
                if (urlParts.Count >= 4)
                {
                    urlParts.RemoveRange(urlParts.Count - 2, 2);

                    if (urlParts[0] == "men")
                        gender = GenderType.Men;
                    else if (urlParts[0] == "women")
                        gender = GenderType.Women;

                    var parentList = dbCategories;
                    var dbCat = dbCategories.FirstOrDefault(x => x.Slug == urlParts[0]);
                    for (int i = 0; i < urlParts.Count; i++)
                    {
                        var urlPart = urlParts[i];

                        if (dbCat is null)
                        {
                            dbCat = new CategoryApi()
                            {
                                GenderType = gender,
                                Name = urlPart,
                                Slug = urlPart,
                            };

                            parentList?.Add(dbCat);
                        }
                        else
                        {
                            dbCat.GenderType = gender;
                            dbCat.Name = urlPart;
                            dbCat.Slug = urlPart;
                        }

                        if (i == urlParts.Count - 1)
                        {
                            dbCat.Name = menuItem.Content?.Title ?? "";
                            dbCat.Description = menuItem.Content?.SubTitle ?? "";
                            dbCat.MainPictureFileName = menuItem.Content?.WebLargeImageUrl?.Replace("https://images.asos-media.com/navigation", "") ?? "";
                            dbCat.ApiId = menuItem.Link?.CategoryId;
                            dbCat.FullPath = menuItem.Link?.WebUrl ?? "";
                        }
                        else
                        {
                            if (dbCat.SubCategories is null)
                            {
                                dbCat.SubCategories = new List<CategoryApi>();
                            }
                            parentList = dbCat.SubCategories;
                            dbCat = dbCat.SubCategories?.FirstOrDefault(x => x.Slug == urlParts[i + 1]);

                        }

                    }
                }
            }

            if (menuItem.Children?.Count > 0)
            {
                SetCatData(menuItem.Children, dbCategories);
            }
        }
    }
}
