using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Advers.Queries;



public record GetBannersQuery(string? BaseUrl) : IRequest<IReadOnlyCollection<Banner>>;


internal class GetBannersQueryHandler : IRequestHandler<GetBannersQuery, IReadOnlyCollection<Banner>>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GetBannersQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<IReadOnlyCollection<Banner>> Handle(GetBannersQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            return await dbContext.Banners.AsNoTracking()
                .Where(x => request.BaseUrl == null || x.BaseUrl == request.BaseUrl).ToListAsync(cancellationToken);
        }
    }


}
