using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record SaleProductsQuery(
    GenderType Gender,
    PagingRequest PagingRequest,
    ProductFiltersDto? FilterRequest = null)
    : IRequest<ProductsDto>;



internal class SaleProductsQueryHandler :
    IRequestHandler<SaleProductsQuery, ProductsDto>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;


    public SaleProductsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<ProductsDto> Handle(SaleProductsQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            IQueryable<Core.Entities.Product> query = ProductQueryShared.InitQuery(dbContext);


            query = query.Where(x => x.OldPrice > 0 || x.InSale);

            if (request.Gender is GenderType.Women or GenderType.Men)
            {
                query = query.Where(x => x.GenderTypeId == (int)request.Gender);
            }

            var title = $"حراج {(request.Gender == GenderType.Men ? "آقایان" : "بانوان")}";

            return await ProductQueryShared.ProjectProductPreview(dbContext, request.PagingRequest, request.FilterRequest, query, title, cancellationToken);

        }


    }

}
