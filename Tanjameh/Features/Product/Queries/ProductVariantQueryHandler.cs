using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;

public record ProductVariantQuery(params int[] ProductVariantIds) : IRequest<ProductVariant[]>;


public class ProductVariantQueryHandler : IRequestHandler<ProductVariantQuery, ProductVariant[]>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public ProductVariantQueryHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<ProductVariant[]> Handle(ProductVariantQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _contextFactory.CreateDbContextAsync(cancellationToken))
        {
            return await context.ProductVariants
                .Where(x => request.ProductVariantIds.Contains(x.Id))
                .ToArrayAsync(cancellationToken);

        }
    }
}

