

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq.Expressions;
using System.Text.Json;


namespace Tanjameh.Infrastructure.Data.Configs;

internal class BannerConfig : IEntityTypeConfiguration<Banner>
{
    public void Configure(EntityTypeBuilder<Banner> builder)
    {

        //fucking json that not support in mysql
        //builder.OwnsOne(x => x.BannerInfo, ba =>
        //{
        //    ba.ToJson();
        //});

        builder.Property(x => x.BannerInfo).HasColumnType("json")
            .HasConversion<MySqlJsonMicrosoftPocoValueConverter<BannerInfo>>();
    }
}


public class MySqlJsonMicrosoftPocoValueConverter<T> : ValueConverter<T, string>
{
    public MySqlJsonMicrosoftPocoValueConverter()
        : base((Expression<Func<T, string>>)((T v) => ConvertToProviderCore(v)), (Expression<Func<string, T>>)((string v) => ConvertFromProviderCore(v)), (ConverterMappingHints?)null)
    {
    }

    public static string ConvertToProviderCore(T v)
    {
        return JsonSerializer.Serialize(v);
    }

    public static T ConvertFromProviderCore(string v)
    {
        return JsonSerializer.Deserialize<T>(v);
    }
}

