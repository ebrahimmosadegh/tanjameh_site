using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.BrandAndType.Queries;


public record GetProductTypesQuery(int Take = 16, bool Randomize = true) : IRequest<IReadOnlyCollection<ProductType>>;

internal class GetProductTypesQueryHandler : IRequestHandler<GetProductTypesQuery, IReadOnlyCollection<ProductType>>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GetProductTypesQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<IReadOnlyCollection<ProductType>> Handle(GetProductTypesQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            var query = dbContext.ProductTypes.AsNoTracking().AsQueryable();

            if (request.Randomize)
                query = query.OrderBy(r => EF.Functions.Random());
            else
                query = query.OrderBy(x => x.Name);

            return await query.Take(request.Take).ToListAsync(cancellationToken);

        }
    }


}