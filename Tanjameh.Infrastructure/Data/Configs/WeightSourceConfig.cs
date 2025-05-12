

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;



internal class WeightSourceConfig : IEntityTypeConfiguration<WeightSource>
{
    public void Configure(EntityTypeBuilder<WeightSource> builder)
    {

        builder.HasData(
            new WeightSource
            {
                Id = 1,
                Weight = 0f,
            },
            new WeightSource
            {
                Id = 2,
                Weight = 0.5f,
            }, new WeightSource
            {
                Id = 3,
                Weight = 1f,
            },
            new WeightSource
            {
                Id = 4,
                Weight = 1.5f,
            },
            new WeightSource
            {
                Id = 5,
                Weight = 2f,
            }
        );
    }
}

