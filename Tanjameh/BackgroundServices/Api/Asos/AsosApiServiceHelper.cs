using Microsoft.EntityFrameworkCore;
using Pluralize.NET;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.BackgroundServices.Api.Asos;

internal class AsosApiServiceHelper
{
    public AsosApiServiceHelper(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly Dictionary<string, int> _productTypeIdMap = new Dictionary<string, int>(300, StringComparer.OrdinalIgnoreCase);

    public int? FindFirstProductTypeInSentence(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return null;

        var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (_productTypeIdMap.TryGetValue(word, out int id))
            {
                return id;
            }
        }

        return null;
    }


    public void InitProductTypeIdMap()
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {

            IPluralize pluralizer = new Pluralizer();
            context.ProductTypes.Select(x => new { x.Name, x.Id }).ToList()
                .ForEach(x =>
                {
                    _productTypeIdMap.Add(pluralizer.Singularize(x.Name), x.Id);
                });
        }
    }
}
