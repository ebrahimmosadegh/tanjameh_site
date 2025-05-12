using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record CategoryProductsQuery(
    GenderType Gender,
    string CategorySlug,
    PagingRequest PagingRequest,
    ProductFiltersDto? FilterRequest = null)
    : IRequest<ProductsDto>;



internal class CategoryProductsQueryHandler :
    IRequestHandler<CategoryProductsQuery, ProductsDto>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;


    public CategoryProductsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<ProductsDto> Handle(CategoryProductsQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            IQueryable<Core.Entities.Product> query = ProductQueryShared.InitQuery(dbContext);

            var category = await dbContext.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Slug == request.CategorySlug, cancellationToken);

            if (category == null)
            {
                throw new ArgumentException("Category not found");
            }

            if (request.Gender is GenderType.Women or GenderType.Men)
            {
                query = query.Where(x => x.GenderTypeId == (int)request.Gender);
            }

            query = query.Where(x => x.ProductCategories.Any(x => x.CategoryId == category.Id));


            return await ProductQueryShared.ProjectProductPreview(dbContext, request.PagingRequest, request.FilterRequest, query, category.Name, cancellationToken);

        }


    }

}
