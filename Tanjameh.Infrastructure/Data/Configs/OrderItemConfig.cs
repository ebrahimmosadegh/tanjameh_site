using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.Property(oi => oi.Quantity).IsRequired();

        builder.Property(oi => oi.PriceAtTimeOfOrder).IsRequired().HasColumnType("decimal(18, 2)");

        // Relationship with Order (already configured in OrderConfig via HasMany)

        // Relationship with Product (ProductId property exists, but navigation property removed from Core entity)
        // builder.HasOne(oi => oi.Product)
        //        .WithMany() // Assuming Product doesn't need a direct navigation back to OrderItems
        //        .HasForeignKey(oi => oi.ProductId)
        //        .OnDelete(DeleteBehavior.Restrict); // Prevent deleting product if it's part of an order item
    }
}
