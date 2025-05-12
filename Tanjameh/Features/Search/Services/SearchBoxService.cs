using Microsoft.EntityFrameworkCore;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Search.Services;

public class SearchBoxService
{
    private readonly ApplicationDbContext _dbContext;

    public SearchBoxService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<QuickSearchResult>> AutoComplete(string input)
    {
        input = input.ToLower().Trim();

        var productTypes =
        await _dbContext.ProductTypes.Where(pt => pt.Name.ToLower().Contains(input))
        .Select(pt => new QuickSearchResult(pt.Name, pt.Url, "نوع محصول")).Take(10).ToListAsync();

        var categories =
        await _dbContext.Categories.Where(c => c.Name.ToLower().Contains(input))
        .Select(c => new QuickSearchResult(c.Name, c.Url, "دسته بندی")).Take(10).ToListAsync();

        var brands =
       await _dbContext.CatalogBrands.Where(b => b.Name.ToLower().Contains(input))
       .Select(b => new QuickSearchResult(b.Name, b.Url, "برند")).Take(10).ToListAsync();

        var result = productTypes.Concat(categories).Concat(brands).Take(10).ToList();

        return result;
    }
}
