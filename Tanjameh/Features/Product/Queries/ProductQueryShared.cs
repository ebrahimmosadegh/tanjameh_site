using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Tanjameh.Core.Constants;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;

public static class ProductQueryShared
{
    public static IQueryable<Core.Entities.Product> InitQuery(ApplicationDbContext dbContext)
    {
        var query = dbContext.Products
            .AsNoTracking()
            .Include(x => x.ProductType)
            //.Include(x => x.ProductMediaFiles).ThenInclude(x => x.MediaFile)
            .AsQueryable();
        return query;
    }

    public static AllProductQueryble CommonFilter(ProductFiltersDto? filterRequest, IQueryable<Core.Entities.Product> query)
    {
        AllProductQueryble result = new AllProductQueryble();
        if (filterRequest is not null)
        {

            if (filterRequest.Colors?.Length > 0)
            {
                result.Where.Add("color", x => x.ProductVariants.Any(a => filterRequest.Colors.Contains(a.Colour)));
            }
            if (filterRequest.Brands?.Length > 0)
            {
                result.Where.Add("brand", x => filterRequest.Brands.Contains(x.CatalogBrandId));
            }

            // todo handle currency imp
            if (filterRequest.HasPriceFilter)
            {
                if (filterRequest.MaxPrice > 0)
                {
                    //todo currency reverse
                    result.Where.Add("minPrice", x => x.Price < filterRequest.MaxPrice);
                }
                if (filterRequest.MinPrice > 0)
                {
                    result.Where.Add("maxPrice", x => x.Price > filterRequest.MinPrice);
                }

            }

        }

        //todo handle order system
        return result;
    }

    public static async Task<ProductsDto> ProjectProductPreview(ApplicationDbContext dbContext, PagingRequest pagingRequest, ProductFiltersDto? filterRequest, IQueryable<Core.Entities.Product> query, string title, CancellationToken cancellationToken)
    {
        var filterQueries = CommonFilter(filterRequest, query);

        AllFilterView filterView = new();
        filterView.Price = await PriceFilterView(query);
        filterView.Color = await CountColor(dbContext, query, filterQueries);
        filterView.Brand = await CountBrands(query, filterQueries);

        var lastQuery = filterQueries.ApplyAll(query);

        lastQuery = ApplyOrder(lastQuery, filterRequest?.OrderBy);

        var ItemCount = lastQuery.Count();

        lastQuery = lastQuery.ApplyPaging(pagingRequest);

        var productsPreview = await lastQuery.Select(x => new ProductPreviewDto()
        {
            ProductId = x.Id,
            Name = x.Name,
            Url = x.Url,
            ThumbnailImageUrl = x.WebPictureUrl,
            //ThumbnailImageUrls = x.ProductMediaFiles.Select(x => x.MediaFile.WebUrl).Take(2).ToArray(),
            Price = x.Price,
            OldPrice = x.OldPrice,
            CurrencyId = x.PriceCurrencyId,
            ProductTypeName = x.ProductType.Name
        }).ToListAsync(cancellationToken);


        foreach (var product in productsPreview)
        {
            product.ThumbnailImageUrls = await dbContext
                .Products.Where(x => x.Id == product.ProductId)
                .SelectMany(x => x.ProductMediaFiles)
                .Where(x=>x.ThumbnailFile != null)
                .Select(x => x.ThumbnailFile.WebUrl).Take(2).ToArrayAsync(cancellationToken);
        }

        return new ProductsDto(new PagingResponse<ProductPreviewDto>(productsPreview,
            pagingRequest.PageNumber,
            pagingRequest.PageSize > ItemCount ? ItemCount : pagingRequest.PageSize,
            ItemCount / pagingRequest.PageSize + 1,
            ItemCount), title, filterView);
    }

    private static IQueryable<Core.Entities.Product> ApplyOrder(IQueryable<Core.Entities.Product> lastQuery, ProductsOrderBy? orderBy)
    {
        var defaultOrder = lastQuery.OrderByDescending(x => x.Id).ThenByDescending(x => x.UpdatedOnUtc);
        switch (orderBy)
        {
            case ProductsOrderBy.Default:
                return defaultOrder;
            case ProductsOrderBy.New:
                return lastQuery.OrderByDescending(x => x.UpdatedOnUtc);
            case ProductsOrderBy.PriceAscending:
                return lastQuery.OrderBy(x => x.Price);
            case ProductsOrderBy.PriceDescending:
                return lastQuery.OrderByDescending(x => x.Price);
            case ProductsOrderBy.Popular:
                return lastQuery.OrderByDescending(x => x.Rating).ThenBy(x => x.Id);
            case ProductsOrderBy.Sale:
                return lastQuery.Where(x => x.OldPrice != null).OrderByDescending(x => x.Price - x.OldPrice);
            case null:
                return defaultOrder;
        }


        return lastQuery;
    }

    private static async Task<List<ColorFilterView>> CountColor(ApplicationDbContext dbContext, IQueryable<Core.Entities.Product> query, AllProductQueryble allProductQueryble)
    {
        var applyQuery = allProductQueryble.Apply(query, "brand", "minPrice", "maxPrice");
        var colorsQuery = from product in applyQuery
                          join variant in dbContext.ProductVariants.Where(x => x.IsDefault)
                          on product.Id equals variant.ProductId
                          group variant by variant.Colour into variantColour
                          select new ColorFilterView(variantColour.Key, variantColour.Count());

        var colors = await colorsQuery.ToListAsync();
        return await colorsQuery.ToListAsync();
    }


    private static async Task<List<BrandFilterView>> CountBrands(IQueryable<Core.Entities.Product> query, AllProductQueryble allProductQueryble)
    {
        var applyQuery = allProductQueryble.Apply(query, "color", "minPrice", "maxPrice");
        var brandsQuery = applyQuery.Include(x => x.CatalogBrand).GroupBy(x => new { x.CatalogBrand.Id, x.CatalogBrand.Name })
            .Select(x => new BrandFilterView(x.Key.Name, x.Key.Id, x.Count()));

        return await brandsQuery.ToListAsync();
    }


    private static async Task<PriceFilterView> PriceFilterView(IQueryable<Core.Entities.Product> query)
    {
        if (query.FirstOrDefault() is null)
        {
            return new PriceFilterView(0, 0, 2);
        }
        var min = await query.MinAsync(x => x.Price);
        var max = await query.MaxAsync(x => x.Price);
        var currency = await query.Select(x => x.PriceCurrencyId).FirstOrDefaultAsync();

        //todo handle currency exchange
        return new PriceFilterView(min, max, currency ?? 2);
    }
}





public class AllProductQueryble
{
    public Dictionary<string, Expression<Func<Core.Entities.Product, bool>>> Where = new();

    public IQueryable<Core.Entities.Product> ApplyAll(IQueryable<Core.Entities.Product> query)
    {
        foreach (var item in Where)
        {
            query = query.Where(item.Value);
        }

        return query;
    }
    public IQueryable<Core.Entities.Product> Apply(IQueryable<Core.Entities.Product> query, params string[] filterName)
    {
        foreach (var filter in filterName)
        {
            if (Where.TryGetValue(filter, out var item))
            {
                query = query.Where(item);
            }
        }

        return query;
    }

}
