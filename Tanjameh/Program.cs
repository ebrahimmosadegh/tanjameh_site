using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.JSInterop;
using Radzen;
using Tanjameh.BackgroundServices;
using Tanjameh.BlazorServices;
using Tanjameh.Features;
using Tanjameh.Features.Account;
using Tanjameh.Features.Admin.Banner.Services;
using Tanjameh.Features.Admin.Category.Services;
using Tanjameh.Features.Admin.Currency.Services;
using Tanjameh.Features.Admin.Media.Services;
using Tanjameh.Features.Admin.Weight.Services;
using Tanjameh.Features.Currency.Services;
using Tanjameh.Features.Customer.Services;
using Tanjameh.Features.Search.Services;
// Use specific namespaces to resolve ambiguity
using CoreInterfaces = Tanjameh.Core.Interfaces;
using InfrastructureServices = Tanjameh.Infrastructure.Services;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Infrastructure.Data.Helper;
using Serilog;
using Serilog.Events;
using Blazored.Toast;
using Tanjameh.Features.Admin.Product.Services;
// Use specific namespaces to resolve ambiguity
using FeatureFavorite = Tanjameh.Features.Favorite.Services;
using FeatureShoppingCart = Tanjameh.Features.ShoppingCart.Services;
using Tanjameh.Infrastructure.Data; // Ensure this is present for ApplicationUser
using Tanjameh.Core.Settings; // Added for PricingSettings


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSerilog((services, lc) => lc
    .ReadFrom.Configuration(builder.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.Logger(l => l
        .Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Debug || e.Level == LogEventLevel.Information)
        .WriteTo.File(
            path: "logs/debug_info_.log",
            rollingInterval: RollingInterval.Day,
            rollOnFileSizeLimit: true,
            fileSizeLimitBytes: 10 * 1024 * 1024, // 10 MB
            retainedFileCountLimit: 31,
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
        )
    )
    .WriteTo.Logger(l => l
        .Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Error || e.Level == LogEventLevel.Fatal)
        .WriteTo.File(
            path: "logs/error_.log",
            rollingInterval: RollingInterval.Day,
            rollOnFileSizeLimit: true,
            fileSizeLimitBytes: 10 * 1024 * 1024, // 10 MB
            retainedFileCountLimit: 31,
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
        )
    )
);

// Add services to the container.
builder.Services.AddRazorComponents(config =>
{
    if (builder.Environment.IsDevelopment())
    {
        config.DetailedErrors = true;
    }
}
)
    .AddInteractiveServerComponents()
    .AddCircuitOptions(config =>
    {
        if (builder.Environment.IsDevelopment())
        {
            config.DetailedErrors = true;
        }
    })
    .AddHubOptions(options => options.MaximumReceiveMessageSize = 10 * 1024 * 1024); ;

builder.Services.AddRadzenComponents();
builder.Services.AddRadzenCookieThemeService(options =>
{
    options.Name = "Tanjameh.AdminTheme";
    options.Duration = TimeSpan.FromDays(365);
});

builder.Services.AddBlazoredToast();

builder.Services.AddHttpClient();
builder.Services.AddLocalization();

// Add API Controllers support
builder.Services.AddControllers();

builder.Services.AddScoped<ILocalStorageService>(sp =>
    new LocalStorageService(
        sp.GetRequiredService<IJSRuntime>(),
        sp.GetRequiredService<IHttpContextAccessor>().HttpContext.Request.Headers["User-Agent"].Any(h => h.Contains("Prerender"))
    )
);

// --- Configure Settings --- 
builder.Services.Configure<PricingSettings>(builder.Configuration.GetSection(PricingSettings.SectionName));
// --- End Configure Settings ---

builder.Services.AddScoped<CurrencyService>();

builder.Services.AddScoped<AdminCategoryService>();
builder.Services.AddScoped<AdminBannerService>();
builder.Services.AddScoped<AdminCurrencyService>();
builder.Services.AddScoped<WeightService>();
builder.Services.AddScoped<MediaService>();
builder.Services.AddScoped<ProductService>();


builder.Services.AddCascadingAuthenticationState();
//builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<AuthenticationService>();

builder.Services.AddTransient<SearchBoxService>();
// Resolve ambiguity using specific namespaces
builder.Services.AddScoped<CoreInterfaces.IShoppingCartService, InfrastructureServices.ShoppingCartService>();
builder.Services.AddScoped<CoreInterfaces.IFavoriteService, InfrastructureServices.FavoriteService>();
builder.Services.AddScoped<CoreInterfaces.IOrderService, InfrastructureServices.OrderService>();
builder.Services.AddScoped<CoreInterfaces.IShippingService, InfrastructureServices.ShippingService>();
builder.Services.AddScoped<CoreInterfaces.IPaymentService, InfrastructureServices.PaymentService>();
builder.Services.AddScoped<CoreInterfaces.INotificationService, InfrastructureServices.NotificationService>();
builder.Services.AddScoped<CoreInterfaces.IWeightEstimationService, InfrastructureServices.WeightEstimationService>();
builder.Services.AddScoped<CoreInterfaces.IAmazonScraperService, InfrastructureServices.AmazonScraperService>();
builder.Services.AddScoped<CoreInterfaces.IRuleBasedWeightEstimator, InfrastructureServices.RuleBasedWeightEstimator>();
builder.Services.AddScoped<CoreInterfaces.IProductBlacklistService, InfrastructureServices.ProductBlacklistService>();
builder.Services.AddScoped<CoreInterfaces.ICategoryClassificationService, InfrastructureServices.CategoryClassificationService>();
builder.Services.AddScoped<CoreInterfaces.IShippingCostCalculator, InfrastructureServices.ShippingCostCalculator>();
builder.Services.AddScoped<CoreInterfaces.IPriceCalculatorService, InfrastructureServices.PriceCalculatorService>(); // Added Price Calculator Service

// Register Scraper/Updater services and resolver
builder.Services.AddScoped<InfrastructureServices.Scraping.ProductUpdaterResolver>();
builder.Services.AddScoped<InfrastructureServices.Scraping.Grabbers.AsosProductGrabber>();
builder.Services.AddScoped<InfrastructureServices.Scraping.Updaters.AsosProductUpdater>();
builder.Services.AddScoped<InfrastructureServices.Scraping.Grabbers.ZalandoProductGrabber>();
builder.Services.AddScoped<InfrastructureServices.Scraping.Updaters.ZalandoProductUpdater>();
builder.Services.AddScoped<InfrastructureServices.Scraping.Grabbers.NextProductGrabber>();
builder.Services.AddScoped<InfrastructureServices.Scraping.Updaters.NextProductUpdater>();


builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

//string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));
//ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
{
    // Use InMemory database instead of MySQL for temporary deployment
    options.UseInMemoryDatabase("TanjamehDb");
    // options.UseMySql(connectionString, serverVersion);

    if (builder.Environment.IsDevelopment())
    {

        options.LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
    }

});



builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Use Infrastructure.Data.ApplicationUser for Identity
builder.Services.AddIdentityCore<ApplicationUser>(options =>
{
    //options.SignIn.RequireConfirmedAccount = true,
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;

})
    .AddRoles<IdentityRole<long>>()
    .AddEntityFrameworkStores<ApplicationDbContext>() // This should work with InMemory provider
    .AddSignInManager()
    .AddDefaultTokenProviders();

//builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

builder.Services.AddBackgroundServices(builder.Configuration);

builder.Services.AddHostedService<StartupService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRequestLocalization(options => options.AddSupportedCultures("fa-IR").AddSupportedUICultures("fa-IR").SetDefaultCulture("fa-IR"));

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

// Map API controllers
app.MapControllers();

app.UseStatusCodePagesWithReExecute("/404.html");

app.UseStaticFiles();


// EnsureMigration might not be applicable or needed for InMemory database
// EnsureMigration.EnsureMigrationOfContext<ApplicationDbContext>(app).Wait();

// Seed admin user - This might need adjustment for InMemory or run conditionally
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.EnsureCreated(); // Ensure the InMemory database is created
    UserSeed.SeedAdminUser(scope.ServiceProvider).Wait();
}

app.Run();


// DesignTimeDbContextFactory might not be needed or should be adjusted for InMemory if kept
/*
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        // This configuration is for MySQL, adjust if needed for design-time operations with InMemory
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseInMemoryDatabase("DesignTimeDb"); 

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
*/

