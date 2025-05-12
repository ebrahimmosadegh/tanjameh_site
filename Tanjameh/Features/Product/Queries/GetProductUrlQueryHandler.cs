
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record GetProductUrlQuery(int Id) : IRequest<string?>;

public class GetProductUrlQueryHandler : IRequestHandler<GetProductUrlQuery, string?>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public GetProductUrlQueryHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public async Task<string?> Handle(GetProductUrlQuery request, CancellationToken cancellationToken)
    {
        using(var context = await _contextFactory.CreateDbContextAsync(cancellationToken)) {

            var product =
                await context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            return product?.Url;
        }
    }
}


