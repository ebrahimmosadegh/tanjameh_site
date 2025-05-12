

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Tanjameh.Infrastructure.Data.Helper;

public static class EnsureMigration
{
    public async static Task EnsureMigrationOfContext<T>(this IApplicationBuilder app) where T : DbContext
    {
        using (var context = app.ApplicationServices.GetService<IDbContextFactory<T>>().CreateDbContext())
        await context.Database.MigrateAsync();
    }
}