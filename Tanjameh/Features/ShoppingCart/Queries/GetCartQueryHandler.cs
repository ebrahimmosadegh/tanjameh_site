using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.ShoppingCart.Queries;


public record GetCartQuery(long UserId) : IRequest<Core.Entities.ShoppingCart>;

public class GetCartQueryHandler : IRequestHandler<GetCartQuery, Core.Entities.ShoppingCart>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public GetCartQueryHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public async Task<Core.Entities.ShoppingCart> Handle(GetCartQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _contextFactory.CreateDbContextAsync())
        {
            var cart = await context.ShoppingCarts.Include(x => x.Items).OrderByDescending(x => x.Id).FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

            if (cart is null)
            {
                return new Core.Entities.ShoppingCart();
            }
            else
            {
                return cart;
            }
        }
    }
}

