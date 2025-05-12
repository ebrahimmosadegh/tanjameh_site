using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Infrastructure;

// This factory is used by the EF Core tools (e.g., for migrations) when creating a DbContext instance at design time.
// It allows us to configure the DbContext independently of the application's runtime configuration.
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        // Use a simple configuration setup just for design time.
        // It's often better to use a dummy connection string or an in-memory database
        // to avoid needing a real database connection during migrations.
        // However, let's try using the appsettings file first, assuming it might work
        // if the connection issue was related to the host builder.

        // Build configuration
        IConfigurationRoot configuration = new ConfigurationBuilder()
            // Adjust the base path to find the appsettings.json in the startup project (Tanjameh)
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Tanjameh"))
            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
            .Build();

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

        // Get connection string
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Configure DbContext to use MySQL
        // Using ServerVersion.AutoDetect might still require a connection.
        // Let's explicitly use a known version to potentially avoid the auto-detection connection.
        builder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))); // Specify a common MySQL 8 version

        return new ApplicationDbContext(builder.Options);
    }
}
