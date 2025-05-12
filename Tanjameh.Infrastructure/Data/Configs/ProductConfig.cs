

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

internal class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasQueryFilter(x => !x.Hidden);

        builder.HasIndex(b => b.Name, "IX_Names");
        builder.HasIndex(b => b.Name, "IX_Names_Descending")
         .IsDescending();

        builder.HasIndex(b => new { b.Price, b.OldPrice }, "IX_Price");
        builder.HasIndex(b => new { b.Price, b.OldPrice }, "IX_Price_Descending")
             .IsDescending();

        builder.HasIndex(b => b.Exist, "IX_Exist");
        builder.HasIndex(b => b.UpdatedOnUtc, "IX_Update");
        builder.HasIndex(b => b.UpdatedOnUtc, "IX_Update_Descending").IsDescending();

        builder.HasIndex(b => b.Rating, "IX_Rating_Descending").IsDescending(); 

    }


}
