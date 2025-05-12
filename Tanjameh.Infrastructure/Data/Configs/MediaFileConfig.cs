using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

internal class MediaFileConfig : IEntityTypeConfiguration<MediaFile>
{
    public void Configure(EntityTypeBuilder<MediaFile> builder)
    {
        builder.HasQueryFilter(x => x.Hidden == false);
    }
}

