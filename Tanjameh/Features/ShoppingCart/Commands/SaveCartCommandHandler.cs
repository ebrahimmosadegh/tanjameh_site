using DocumentFormat.OpenXml.InkML;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.ShoppingCart.Commands;



public record SaveCartCommand(long UserId, Core.Entities.ShoppingCart Cart) : IRequest;

public class SaveCartCommandHandler : IRequestHandler<SaveCartCommand>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public SaveCartCommandHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task Handle(SaveCartCommand request, CancellationToken cancellationToken)
    {
        using (var context = await _contextFactory.CreateDbContextAsync())
        {
            request.Cart.UserId = request.UserId;
            var itemToUpdate = context.ShoppingCarts.Include(x=>x.Items).FirstOrDefault(x => x.UserId == request.UserId);

            if (itemToUpdate != null)
            {
                itemToUpdate.Items.Clear();
                foreach (var item in request.Cart.Items)
                {
                    itemToUpdate.Items.Add(item);
                }
            }
            else
            {
               await context.AddAsync(request.Cart);
            }



            await context.SaveChangesAsync(cancellationToken);
        }
    }
}

