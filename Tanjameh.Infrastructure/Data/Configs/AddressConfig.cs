using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

public class AddressConfig : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FullName).IsRequired().HasMaxLength(100);
        builder.Property(a => a.StreetAddress).IsRequired().HasMaxLength(200);
        builder.Property(a => a.ApartmentSuiteEtc).HasMaxLength(100);
        builder.Property(a => a.City).IsRequired().HasMaxLength(50);
        builder.Property(a => a.StateProvince).IsRequired().HasMaxLength(50);
        builder.Property(a => a.PostalCode).IsRequired().HasMaxLength(20);
        builder.Property(a => a.Country).IsRequired().HasMaxLength(50);
        builder.Property(a => a.PhoneNumber).IsRequired().HasMaxLength(20);

        // Relationship with User (UserId property exists, but navigation property removed from Core entity)
        // builder.HasOne(a => a.User)
        //        .WithMany()
        //        .HasForeignKey(a => a.UserId)
        //        .OnDelete(DeleteBehavior.Cascade); // Or Restrict depending on requirements

        // Relationships for orders are configured in OrderConfig
    }
}
