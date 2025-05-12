

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;


internal class CurrencyConfig : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.HasData(new Currency
        {
            Id = 1,
            CurrencyCode = "IRR",
            CurrencyName = "تومان ایران",
            CurrencySign = " تومان ",
            CustomStringFormat = "N0",
            DefaultCultureName = "fa-IR",
        },
        new Currency
        {
            Id = 2,
            CurrencyCode = "GBP",
            CurrencyName = "Pound Sterling",
            CurrencySign = "£",
            CustomStringFormat = "N2",
        }
        );

    }
}
