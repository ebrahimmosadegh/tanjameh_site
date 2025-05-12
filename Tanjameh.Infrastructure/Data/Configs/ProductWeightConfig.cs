

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

internal class ProductWeightConfig : IEntityTypeConfiguration<ProductWeightPrice>
{
    public void Configure(EntityTypeBuilder<ProductWeightPrice> builder)
    {
        builder.HasOne(e => e.Weight)
        .WithOne(e => e.ProductWeightPrice)
        .HasForeignKey<ProductWeightPrice>(x => x.WeightId)
        .IsRequired();

        builder.HasData(
            new ProductWeightPrice
            {
                Id = 1,
                WeightId = 1,
                NormalPrice = 1,
                ExtraPrice = 1,
                CurrencyId = 2,
            },
            new ProductWeightPrice
            {
                Id = 2,
                WeightId = 2,
                NormalPrice = 15.75M,
                ExtraPrice = 18.3M,
                CurrencyId = 2,
            }, new ProductWeightPrice
            {
                Id = 3,
                WeightId = 3,
                NormalPrice = 22.2M,
                ExtraPrice = 24.7M,
                CurrencyId = 2,
            }, new ProductWeightPrice
            {
                Id = 4,
                WeightId = 4,
                NormalPrice = 26.7M,
                ExtraPrice = 29.1M,
                CurrencyId = 2,
            }, new ProductWeightPrice
            {
                Id = 5,
                WeightId = 5,
                NormalPrice = 27.15M,
                ExtraPrice = 29.55M,
                CurrencyId = 2,
            }
        );
    }
}
