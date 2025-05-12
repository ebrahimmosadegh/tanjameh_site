using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;

public record ProductThumbnailQuery(params int[] ProductIds) : IRequest<ProductThumbnial[]>;


public class ProductThumbnailQueryHandler : IRequestHandler<ProductThumbnailQuery, ProductThumbnial[]>
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public ProductThumbnailQueryHandler(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<ProductThumbnial[]> Handle(ProductThumbnailQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _contextFactory.CreateDbContextAsync(cancellationToken))
        {
            return await context.Products
                .Where(x => request.ProductIds.Contains(x.Id) && x.Exist)
                .Select(x => new ProductThumbnial(x.Id, x.WebPictureUrl))
                .ToArrayAsync(cancellationToken);

        }
    }
}

public record struct ProductThumbnial(int ProductId, string? WebPictureUrl);
