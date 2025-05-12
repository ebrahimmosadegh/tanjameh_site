using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record BrandProductsQuery(
    GenderType Gender,
    string BrandSlug,
    PagingRequest PagingRequest,
    ProductFiltersDto? FilterRequest = null)
    : IRequest<ProductsDto>;


internal class BrandProductsQueryHandler :
    IRequestHandler<BrandProductsQuery, ProductsDto>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public BrandProductsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }

    public async Task<ProductsDto> Handle(BrandProductsQuery request, CancellationToken cancellationToken)
    {
        //todo handle exception
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            IQueryable<Core.Entities.Product> query = ProductQueryShared.InitQuery(dbContext);

            var catalogBrand = await dbContext.CatalogBrands.AsNoTracking().FirstOrDefaultAsync(x => x.Slug == request.BrandSlug, cancellationToken);

            if (catalogBrand == null)
            {
                throw new Exception("");
            }

            if (request.Gender is GenderType.Women or GenderType.Men)
            {
                query = query.Where(x => x.GenderTypeId == (int)request.Gender);
            }

            query = query.Where(x => x.CatalogBrandId == catalogBrand.Id);

            return await ProductQueryShared.ProjectProductPreview(dbContext, request.PagingRequest, request.FilterRequest, query, catalogBrand.Name, cancellationToken);

        }


    }

}
