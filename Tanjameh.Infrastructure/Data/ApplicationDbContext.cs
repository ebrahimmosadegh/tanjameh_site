using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data.Configs;


namespace Tanjameh.Infrastructure.Data;

public class ApplicationDbContext
    : IdentityDbContext<ApplicationUser, IdentityRole<long>, long>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected ApplicationDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Category> Categories => Set<Category>();

    public DbSet<Banner> Banners => Set<Banner>();

    public DbSet<Country> Countries => Set<Country>();

    public DbSet<Currency> Currencies => Set<Currency>();

    public DbSet<CurrencyConversion> CurrencyConversions => Set<CurrencyConversion>();

    public DbSet<Customer> Customers => Set<Customer>();
    
    public DbSet<CustomerAddress> CustomerAddress => Set<CustomerAddress>();

    public DbSet<LegacyCustomerOrder> CustomerOrders => Set<LegacyCustomerOrder>();

    public DbSet<ShippingInfo> ShippingInfo => Set<ShippingInfo>();

    public DbSet<MediaFile> MediaFiles => Set<MediaFile>();

    public DbSet<Payment> Payments => Set<Payment>();

    public DbSet<Product> Products => Set<Product>();

    public DbSet<ProductSpecification> ProductSpecifications => Set<ProductSpecification>();

    public DbSet<ProductTag> ProductTags => Set<ProductTag>();

    public DbSet<ProductVariant> ProductVariants => Set<ProductVariant>();

    public DbSet<CategoryApi> CategoryApis => Set<CategoryApi>();

    public DbSet<SiteCategoryToApi> SiteCategoryToApis => Set<SiteCategoryToApi>();

    public DbSet<RawProductData> RawProductData => Set<RawProductData>();

    public DbSet<CatalogBrand> CatalogBrands => Set<CatalogBrand>();

    public DbSet<ProductType> ProductTypes => Set<ProductType>();


    public DbSet<WeightSource> WeightSource => Set<WeightSource>();
    public DbSet<ProductWeightPrice> ProductWeightPrice => Set<ProductWeightPrice>();

   
    public DbSet<ShoppingCart> ShoppingCarts => Set<ShoppingCart>();
    public DbSet<ProductMediaFile> ProductMediaFile => Set<ProductMediaFile>();

    public DbSet<EventLog> EventLogs => Set<EventLog>();

    // Order System Entities
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    // Shipping Module Entities
    public DbSet<ShippingMethod> ShippingMethods => Set<ShippingMethod>();


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(BannerConfig).Assembly);

    }

    protected override void ConfigureConventions(
         ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>()
           .HavePrecision(20, 4);
    }

    //add final migration : 
}
