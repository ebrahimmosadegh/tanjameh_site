using DocumentFormat.OpenXml.InkML;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record ProductWeightPriceQuery(int ProductId) : IRequest<ProductWeightPriceDto>;

public class ProductWeightPriceQueryHandler : IRequestHandler<ProductWeightPriceQuery, ProductWeightPriceDto>
{
    //todo er
    const int RollNumber = 65;
    const decimal CoverPrice = 1.1M;
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private int _productId;

    public ProductWeightPriceQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<ProductWeightPriceDto> Handle(ProductWeightPriceQuery request, CancellationToken cancellationToken)
    {
        using (var context = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            _productId = request.ProductId;

            var product = await context.Products.FirstOrDefaultAsync(x => x.Id == _productId, cancellationToken);
            if (product is null)
            {
                throw new Exception("Product not exist");
            }


            Func<ApplicationDbContext, int?>[] calcMethods = [GetByProduct, GetByProductType, GetByProductCategory];

            int? weightId = null;
            foreach (var item in calcMethods)
            {
                var weightIdResult = item.Invoke(context);
                if (weightIdResult != null)
                {
                    weightId = weightIdResult;
                    break;
                }
            }

            if (weightId == null)
                weightId = 2;

            var weightSource = await context.WeightSource.FirstOrDefaultAsync(x => x.Id == weightId.Value, cancellationToken);

            var productWeightPrice = await context.ProductWeightPrice.FirstOrDefaultAsync(x => x.WeightId == weightId.Value, cancellationToken);

            if (weightSource is null || productWeightPrice is null)
                throw new Exception();

            if (product.Price < RollNumber)
            {
                return new ProductWeightPriceDto() { ProductId = _productId, Price = productWeightPrice.ExtraPrice * CoverPrice, WeightSource = weightSource };
            }
            else
            {
                return new ProductWeightPriceDto() { ProductId = _productId, Price = productWeightPrice.NormalPrice * CoverPrice, WeightSource = weightSource };
            }
        }
    }


    private int? GetByProduct(ApplicationDbContext context)
    {
        return context.Products.Where(x => x.Id == _productId).Select(x => x.WeightId).FirstOrDefault();
    }
    private int? GetByProductType(ApplicationDbContext context)
    {
        return context.Products.
            Include(x => x.ProductType).
            Where(x => x.Id == _productId && x.ProductType != null).
            Select(x => x.ProductType!.WeightId).FirstOrDefault();
    }

    private int? GetByProductCategory(ApplicationDbContext context)
    {
        var product = context.Products.First(x => x.Id == _productId);
        var categories = product.ProductCategories.ToList();

        foreach (var category in categories)
        {
            var w = category.Category.WeightId;
            if (w != null)
                return w;
        }
        return null;
    }

}
