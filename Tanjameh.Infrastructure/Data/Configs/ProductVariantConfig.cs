

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

internal class ProductVariantConfig : IEntityTypeConfiguration<ProductVariant>
{
    public void Configure(EntityTypeBuilder<ProductVariant> builder)
    {

        builder.HasIndex(b => b.Name, "IX_Names");
        builder.HasIndex(b => b.Name, "IX_Names_Descending")
         .IsDescending();

        builder.HasIndex(b =>  b.Colour, "IX_Color");

        builder.HasIndex(b => new {b.BrandSize , b.DisplaySizeText, b.SizeId}, "IX_Size");

    }


}