

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

internal class ProductProductTagConfig : IEntityTypeConfiguration<ProductProductTag>
{
    public void Configure(EntityTypeBuilder<ProductProductTag> builder)
    {
        builder.HasKey(x => new { x.ProductId, x.ProductTagId });
    }
}

