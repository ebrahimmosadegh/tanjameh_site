using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Enums;

namespace Tanjameh.Infrastructure.Data.Configs;

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.OrderDate).IsRequired();

        builder.Property(o => o.Subtotal).IsRequired().HasColumnType("decimal(18, 2)");
        builder.Property(o => o.ShippingCost).IsRequired().HasColumnType("decimal(18, 2)");
        builder.Property(o => o.TotalAmount).IsRequired().HasColumnType("decimal(18, 2)");

        builder.Property(o => o.Status)
               .IsRequired()
               .HasConversion(
                   v => v.ToString(),
                   v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v));

        builder.Property(o => o.PaymentIntentId).HasMaxLength(100);

        // Relationship with User (UserId property exists, but navigation property removed from Core entity)
        // builder.HasOne(o => o.User)
        //        .WithMany()
        //        .HasForeignKey(o => o.UserId)
        //        .OnDelete(DeleteBehavior.Restrict); // Prevent deleting user if they have orders

        // Relationship with Shipping Address (ShippingAddressId property exists, but navigation property removed from Core entity)
        // builder.HasOne(o => o.ShippingAddress)
        //        .WithMany(a => a.ShippingOrders) // ShippingOrders was also removed from Address
        //        .HasForeignKey(o => o.ShippingAddressId)
        //        .OnDelete(DeleteBehavior.Restrict); // Prevent deleting address if used in orders

        // Relationship with Billing Address (Optional) (BillingAddressId property exists, but navigation property removed from Core entity)
        // builder.HasOne(o => o.BillingAddress)
        //        .WithMany(a => a.BillingOrders) // BillingOrders was also removed from Address
        //        .HasForeignKey(o => o.BillingAddressId)
        //        .OnDelete(DeleteBehavior.Restrict); // Prevent deleting address if used in orders

        // Relationship with OrderItems
        builder.HasMany(o => o.OrderItems)
               // .WithOne(oi => oi.Order) // Order navigation property removed from OrderItem
               .WithOne() // Define the relationship without the navigation property back
               .HasForeignKey(oi => oi.OrderId)
               .OnDelete(DeleteBehavior.Cascade); // Delete order items if order is deleted
    }
}
