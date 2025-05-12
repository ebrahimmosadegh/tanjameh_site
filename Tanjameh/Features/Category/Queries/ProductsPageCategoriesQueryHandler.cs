using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Category.Queries;


public record ProductsPageCategoriesQuery(string CategorySlug) : IRequest<Core.Entities.Category?>;


internal class ProductsPageCategoriesQueryHandler : IRequestHandler<ProductsPageCategoriesQuery, Core.Entities.Category?>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public ProductsPageCategoriesQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<Core.Entities.Category?> Handle(ProductsPageCategoriesQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            var categories = await dbContext.Categories
                .Include(x=>x.ParentCategory)
                .ThenInclude(x=>x.SubCategories)
                .ToListAsync();

            var currentCategory = categories.FirstOrDefault(x => x.Slug == request.CategorySlug);


            if (currentCategory.ParentCategory == null)
            {
                foreach (var item in currentCategory?.SubCategories ?? [])
                {
                    item.Mark = true;
                }
            }
            else
            {
                int deepLevel = 0;
                // Core.Entities.Category? topCategory = null;

                while (deepLevel <= 2)
                {
                    deepLevel++;
                    currentCategory.Mark = true;
                    if (currentCategory.ParentCategoryId == null)
                    {
                        break;
                    }
                    var parent = currentCategory.ParentCategory;
                    foreach (var item in parent.SubCategories!)
                    {
                        item.Mark = true;
                    }
                    currentCategory = parent;

                }

            }

            return currentCategory;

        }
    }


}
