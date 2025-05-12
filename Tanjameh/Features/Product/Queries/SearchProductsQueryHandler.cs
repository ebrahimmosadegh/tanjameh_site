using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record SearchProductsQuery(
    string Text,
    PagingRequest PagingRequest,
    ProductFiltersDto? FilterRequest = null)
    : IRequest<ProductsDto>;


internal class SearchProductsQueryHandler :
    IRequestHandler<SearchProductsQuery, ProductsDto>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;


    public SearchProductsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<ProductsDto> Handle(SearchProductsQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            IQueryable<Core.Entities.Product> query = ProductQueryShared.InitQuery(dbContext);


            var searchKey = request.Text.Trim();

            query = query.Where(x => x.Name.Contains(searchKey));


            return await ProductQueryShared.ProjectProductPreview(dbContext, request.PagingRequest, request.FilterRequest, query, request.Text, cancellationToken);

        }


    }

}
