using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;

public record ProductPriceQuery(int ProductId, int? ProductVariantId = null) : IRequest<ProductPriceDto?>;


//todo boolean with update
public class ProductPriceQueryHandler : IRequestHandler<ProductPriceQuery, ProductPriceDto?>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public ProductPriceQueryHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<ProductPriceDto?> Handle(ProductPriceQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _contextFactory.CreateDbContextAsync(cancellationToken))
        {
            var localProduct = context.ChangeTracker.Entries<Core.Entities.Product>()
             .FirstOrDefault(e => e.Entity.Id == request.ProductId);

            if (localProduct != null)
            {
                localProduct.State = EntityState.Detached;
            }

            if (request.ProductVariantId != null)
            {
                var localProductVariant = context.ChangeTracker.Entries<Core.Entities.ProductVariant>()
                     .FirstOrDefault(e => e.Entity.Id == request.ProductVariantId);

                if (localProductVariant == null)
                {
                    return null;
                }
            }

            return await context.Products
                .Where(x => x.Id == request.ProductId && x.Exist).Select(x => new ProductPriceDto()
                {
                    Id = request.ProductId,
                    Price = x.Price,
                    OldPrice = x.OldPrice,
                    CustomePriceKey = x.CustomePriceKey,
                    PriceCurrencyId = x.PriceCurrencyId,
                }).FirstOrDefaultAsync(cancellationToken);

        }
    }
}
