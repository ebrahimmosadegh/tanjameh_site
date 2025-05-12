using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Constants;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record TypeProductsQuery(
    GenderType Gender,
    string ProductTypeSlug,
    PagingRequest PagingRequest,
    ProductFiltersDto? FilterRequest = null)
    : IRequest<ProductsDto>;


//todo handle exception

internal class TypeProductsQueryHandler :
    IRequestHandler<TypeProductsQuery, ProductsDto>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;


    public TypeProductsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<ProductsDto> Handle(TypeProductsQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            IQueryable<Core.Entities.Product> query = ProductQueryShared.InitQuery(dbContext);

            var productType = await dbContext.ProductTypes
                .AsNoTracking().FirstOrDefaultAsync(x => x.Slug == request.ProductTypeSlug, cancellationToken);

            if (productType == null)
            {
                throw new Exception("");
            }

            if (request.Gender is GenderType.Women or GenderType.Men)
            {
                query = query.Where(x => x.GenderTypeId == (int)request.Gender);
            }

            query = query.Where(x => x.ProductTypeId == productType.Id);


            return await ProductQueryShared.ProjectProductPreview(dbContext, request.PagingRequest, request.FilterRequest, query, ProductTypeTranslate.GetTranslate(productType.Name), cancellationToken);

        }


    }

}
