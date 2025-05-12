using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Advers.Queries;


public record GetBannerByIdQuery(int BannerId) : IRequest<Banner?>;

internal class GetBannerByIdQueryHandler : IRequestHandler<GetBannerByIdQuery, Banner?>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GetBannerByIdQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<Banner?> Handle(GetBannerByIdQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            return await dbContext.Banners.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.BannerId);
        }
    }

  
}
