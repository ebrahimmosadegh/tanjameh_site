using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Entities;
using Tanjameh.Dtos;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Product.Queries;


public record BannerProductQuery(BannerInfo BannerInfo) : IRequest<IReadOnlyCollection<ProductPreviewDto>>;


internal class BannerProductsQueryHandler :
    IRequestHandler<BannerProductQuery, IReadOnlyCollection<ProductPreviewDto>>
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;


    public BannerProductsQueryHandler(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }


    public async Task<IReadOnlyCollection<ProductPreviewDto>> Handle(BannerProductQuery request, CancellationToken cancellationToken)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken))
        {
            var query = dbContext.Products.AsQueryable();

            if (request.BannerInfo.GenderType is GenderType.Women or GenderType.Men)
            {
                query = query.Where(x => x.GenderTypeId == (int)request.BannerInfo.GenderType);
            }

            if (!string.IsNullOrEmpty(request.BannerInfo.Filter))
            {
                query = query.Where(request.BannerInfo.Filter!);
            }

            //todo handle Product Type

            query = query.OrderBy(r => EF.Functions.Random());


            query = query.Take(request.BannerInfo.Take);


            var productsPreview = await query.Select(x => new ProductPreviewDto()
            {
                ProductId = x.Id,
                Name = x.Name,
                Url = x.Url,
                Price = x.Price,
                OldPrice = x.OldPrice,
                CurrencyId = x.PriceCurrencyId,
                ThumbnailImageUrl = x.WebPictureUrl
            }).ToListAsync(cancellationToken);

            //todo handle price

            return productsPreview;

        }


    }
}
