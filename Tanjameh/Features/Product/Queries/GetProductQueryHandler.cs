
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record GetProductQuery(int Id, string Slug) : IRequest<ProductDetailsDto?>;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDetailsDto?>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public GetProductQueryHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public async Task<ProductDetailsDto?> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        using(var context = await _contextFactory.CreateDbContextAsync(cancellationToken)) {
            var localProduct = context.ChangeTracker.Entries<Core.Entities.Product>()
             .FirstOrDefault(e => e.Entity.Id == request.Id);

            if (localProduct != null)
            {
                localProduct.State = EntityState.Detached;
            }

            var product = await context.Products.Include(x => x.ProductVariants).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (product == null || product.Slug != request.Slug)
            {
                return null;
            }
            return product.ToProductDetailsDto();
        }
    }
}


