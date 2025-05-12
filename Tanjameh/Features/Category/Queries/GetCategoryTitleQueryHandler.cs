using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Category.Queries;


public record GetCategoryTitleQuery(GenderType Gender, string Slug) : IRequest<string?>;


internal class GetCategoryTitleQueryHandler : IRequestHandler<GetCategoryTitleQuery, string?>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GetCategoryTitleQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<string?> Handle(GetCategoryTitleQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            return await dbContext.Categories
                .Where(x => x.Slug == request.Slug)
                .Select(x => x.Name)
                .FirstOrDefaultAsync(cancellationToken);

        }
    }


}
