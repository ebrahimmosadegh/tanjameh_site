using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.BrandAndType.Queries;


public record GetBrandsQuery(int Take = 16, bool Randomize = true) : IRequest<IReadOnlyCollection<CatalogBrand>>;

internal class GetBrandsQueryHandler : IRequestHandler<GetBrandsQuery, IReadOnlyCollection<CatalogBrand>>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GetBrandsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<IReadOnlyCollection<CatalogBrand>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            var query = dbContext.CatalogBrands.AsNoTracking().AsQueryable();

            if (request.Randomize)
                query = query.OrderBy(r => EF.Functions.Random());
            else
                query = query.OrderBy(x => x.Name);

          return await query.Take(request.Take).ToListAsync(cancellationToken);

        }
    }


}

