using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Features.Category.Models;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Category.Queries;


public record GetCategoriesByTypeQuery(HomeMenuType HomeMenuType) : IRequest<IReadOnlyCollection<Core.Entities.Category>>;


internal class GetCategoriesByTypeQueryHandler : IRequestHandler<GetCategoriesByTypeQuery, IReadOnlyCollection<Core.Entities.Category>>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GetCategoriesByTypeQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<IReadOnlyCollection<Core.Entities.Category>> Handle(GetCategoriesByTypeQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            var query = dbContext.Categories
                .Include(x => x.SubCategories)
                .AsNoTracking()
                .Where(x => x.ParentCategory == null);

            if (request.HomeMenuType == HomeMenuType.Men)
            {
                query = query.Where(x => x.GenderTypeId == (int)GenderType.Men);
            }
            else if (request.HomeMenuType == HomeMenuType.Women)
            {
                query = query.Where(x => x.GenderTypeId == (int)GenderType.Women);
            }
            else if (request.HomeMenuType == HomeMenuType.Sale)
            {
                //todo handle menu on sale
                return [
                    new Core.Entities.Category() { GenderType = GenderType.Men, Name = "مردانه", Slug = "men"},
                    new Core.Entities.Category() { GenderType = GenderType.Women, Name = "زنانه", Slug = "women"}
                ];
            }

            return await query.ToListAsync(cancellationToken);

        }
    }


}
