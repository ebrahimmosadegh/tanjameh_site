using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Entities.Temp;

namespace Tanjameh.Infrastructure.Data;

public partial class TanjamehStoreContext : DbContext
{
    public TanjamehStoreContext()
    {
    }

    public TanjamehStoreContext(DbContextOptions<TanjamehStoreContext> options)
        : base(options)
    {
    }

    #region DbSets

    public virtual DbSet<IwBrand> Brands { get; set; }

    public virtual DbSet<CatIdList> CatIdLists { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<IwAdmin> IwAdmins { get; set; }

    public virtual DbSet<IwAdminAccess> IwAdminAccesses { get; set; }

    public virtual DbSet<IwAdminGroup> IwAdminGroups { get; set; }

    public virtual DbSet<IwAdminNotification> IwAdminNotifications { get; set; }

    public virtual DbSet<IwAdminObserver> IwAdminObservers { get; set; }

    public virtual DbSet<IwAdminProfile> IwAdminProfiles { get; set; }

    public virtual DbSet<IwAdminStatus> IwAdminStatuses { get; set; }

    public virtual DbSet<IwApiAllCat> IwApiAllCats { get; set; }

    public virtual DbSet<IwApiBrand> IwApiBrands { get; set; }

    public virtual DbSet<IwApiProduct> IwApiProducts { get; set; }

    public virtual DbSet<IwApiProductType> IwApiProductTypes { get; set; }

    public virtual DbSet<IwApiProductVariant> IwApiProductVariants { get; set; }

    public virtual DbSet<IwApiUser> IwApiUsers { get; set; }

    public virtual DbSet<IwCatchRoot> IwCatchRoots { get; set; }

    public virtual DbSet<IwCompany> IwCompanies { get; set; }

    public virtual DbSet<IwConnectApi> IwConnectApis { get; set; }

    public virtual DbSet<IwConnectSm> IwConnectSms { get; set; }

    public virtual DbSet<IwCountry> IwCountries { get; set; }

    public virtual DbSet<IwCurrenciesConversion> IwCurrenciesConversions { get; set; }

    public virtual DbSet<IwCurrency> IwCurrencies { get; set; }

    public virtual DbSet<IwNewMenu> IwNewMenus { get; set; }

    public virtual DbSet<IwNewMenu2> IwNewMenu2s { get; set; }

    public virtual DbSet<IwNewMenu3> IwNewMenu3s { get; set; }

    public virtual DbSet<IwNewMenu4> IwNewMenu4s { get; set; }

    public virtual DbSet<IwPanelAdminPage> IwPanelAdminPages { get; set; }

    public virtual DbSet<IwPanelAdminPart> IwPanelAdminParts { get; set; }

    public virtual DbSet<IwPanelUserPage> IwPanelUserPages { get; set; }

    public virtual DbSet<IwPanelUserPart> IwPanelUserParts { get; set; }

    public virtual DbSet<IwPaymentState> IwPaymentStates { get; set; }

    public virtual DbSet<IwProductStatus> IwProductStatuses { get; set; }

    public virtual DbSet<IwProductWeight> IwProductWeights { get; set; }

    public virtual DbSet<IwProductsDeliveryPrice> IwProductsDeliveryPrices { get; set; }

    public virtual DbSet<IwProductsPrice> IwProductsPrices { get; set; }

    public virtual DbSet<IwProductsWeightPrice> IwProductsWeightPrices { get; set; }

    public virtual DbSet<IwShippingProduct> IwShippingProducts { get; set; }

    public virtual DbSet<IwStatusView> IwStatusViews { get; set; }

    public virtual DbSet<IwTicket> IwTickets { get; set; }

    public virtual DbSet<IwTicketsCategory> IwTicketsCategories { get; set; }

    public virtual DbSet<IwTicketsPriority> IwTicketsPriorities { get; set; }

    public virtual DbSet<IwTicketsReply> IwTicketsReplies { get; set; }

    public virtual DbSet<IwTicketsSender> IwTicketsSenders { get; set; }

    public virtual DbSet<IwTicketsStatus> IwTicketsStatuses { get; set; }

    public virtual DbSet<IwUser> IwUsers { get; set; }

    public virtual DbSet<IwUserAccess> IwUserAccesses { get; set; }

    public virtual DbSet<IwUserAddress> IwUserAddresses { get; set; }

    public virtual DbSet<IwUserAddressDetail> IwUserAddressDetails { get; set; }

    public virtual DbSet<IwUserDispatch> IwUserDispatches { get; set; }

    public virtual DbSet<IwUserGroup> IwUserGroups { get; set; }

    public virtual DbSet<IwUserInvoice> IwUserInvoices { get; set; }

    public virtual DbSet<IwUserLookDocument> IwUserLookDocuments { get; set; }

    public virtual DbSet<IwUserLookGroup> IwUserLookGroups { get; set; }

    public virtual DbSet<IwUserLookPage> IwUserLookPages { get; set; }

    public virtual DbSet<IwUserLookPost> IwUserLookPosts { get; set; }

    public virtual DbSet<IwUserObserver> IwUserObservers { get; set; }

    public virtual DbSet<IwUserOrderLine> IwUserOrderLines { get; set; }

    public virtual DbSet<IwUserOrderStatus> IwUserOrderStatuses { get; set; }

    public virtual DbSet<IwUserPacking> IwUserPackings { get; set; }

    public virtual DbSet<IwUserPaymentMethod> IwUserPaymentMethods { get; set; }

    public virtual DbSet<IwUserPaymentType> IwUserPaymentTypes { get; set; }

    public virtual DbSet<IwUserReview> IwUserReviews { get; set; }

    public virtual DbSet<IwUserShopOrder> IwUserShopOrders { get; set; }

    public virtual DbSet<IwUserShoppingCart> IwUserShoppingCarts { get; set; }

    public virtual DbSet<IwUserShoppingMethod> IwUserShoppingMethods { get; set; }

    public virtual DbSet<IwUserTempCart> IwUserTempCarts { get; set; }

    public virtual DbSet<IwViewAdminPanelMenu> IwViewAdminPanelMenus { get; set; }

    public virtual DbSet<IwViewProductNotCheck> IwViewProductNotChecks { get; set; }

    public virtual DbSet<ViewProductRand> IwViewProductRands { get; set; }

    public virtual DbSet<IwViewUserAddress> IwViewUserAddresses { get; set; }

    public virtual DbSet<IwViewUserCart> IwViewUserCarts { get; set; }

    public virtual DbSet<IwViewUserPanelMenu> IwViewUserPanelMenus { get; set; }

    public virtual DbSet<IwWebsiteAlert> IwWebsiteAlerts { get; set; }

    public virtual DbSet<IwWebsiteBannerAdver> IwWebsiteBannerAdvers { get; set; }

    public virtual DbSet<IwWebsiteInfo> IwWebsiteInfos { get; set; }

    public virtual DbSet<IwWebsiteLogo> IwWebsiteLogos { get; set; }

    public virtual DbSet<IwWebsitePage> IwWebsitePages { get; set; }

    public virtual DbSet<IwWebsitePagesPart> IwWebsitePagesParts { get; set; }

    public virtual DbSet<IwWebsiteSpAdver> IwWebsiteSpAdvers { get; set; }

    public virtual DbSet<IwWebsiteTitleAdver> IwWebsiteTitleAdvers { get; set; }

    public virtual DbSet<IwWeightCountry> IwWeightCountries { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<IwProduct> Products { get; set; }

    public virtual DbSet<ProductList> ProductLists { get; set; }

    //public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Variant> Variants { get; set; }

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=554433;database=tanjameh_store", Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.4.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_uca1400_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<IwBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("brands")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BrandId)
                .HasColumnType("int(11)")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Brands)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("brands_ibfk_1");
        });

        modelBuilder.Entity<CatIdList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cat_id_list")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CatId)
                .HasColumnType("int(11)")
                .HasColumnName("cat_id");
            entity.Property(e => e.CountAll)
                .HasColumnType("int(11)")
                .HasColumnName("count_all");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ListProducts).HasColumnName("list_products");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("images")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IsPrimary).HasColumnName("is_primary");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<IwAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_admin")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Username, "Username");

            entity.HasIndex(e => e.IwAdminGroupId, "fk_iw_admin_iw_admin_group1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IwAdminGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_admin_group_id");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);

            entity.HasOne(d => d.IwAdminGroup).WithMany(p => p.IwAdmins)
                .HasForeignKey(d => d.IwAdminGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_admin_iw_admin_group1");
        });

        modelBuilder.Entity<IwAdminAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_admin_access")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwAdminGroupId, "fk_iw_admin_access_iw_admin_group1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AllAccess)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.AllTools)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwAdminGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_admin_group_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwAdminGroup).WithMany(p => p.IwAdminAccesses)
                .HasForeignKey(d => d.IwAdminGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_admin_access_iw_admin_group1");
        });

        modelBuilder.Entity<IwAdminGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_admin_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<IwAdminNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_admin_notification")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwAdminId, "fk_iw_admin_notification_iw_admin1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email).HasColumnType("int(1)");
            entity.Property(e => e.IwAdminId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_admin_id");
            entity.Property(e => e.Sms).HasColumnType("int(1)");

            entity.HasOne(d => d.IwAdmin).WithMany(p => p.IwAdminNotifications)
                .HasForeignKey(d => d.IwAdminId)
                .HasConstraintName("fk_iw_admin_notification_iw_admin1");
        });

        modelBuilder.Entity<IwAdminObserver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_admin_observer")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwAdminId, "fk_iw_admin_observer_iw_admin1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwAdminId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_admin_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Online).HasColumnType("tinyint(1) unsigned");

            entity.HasOne(d => d.IwAdmin).WithMany(p => p.IwAdminObservers)
                .HasForeignKey(d => d.IwAdminId)
                .HasConstraintName("fk_iw_admin_observer_iw_admin1");
        });

        modelBuilder.Entity<IwAdminProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_admin_profile")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwAdminId, "fk_iw_admin_profile_iw_admin1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CellNumber).HasMaxLength(16);
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.IwAdminId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_admin_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.IwAdmin).WithMany(p => p.IwAdminProfiles)
                .HasForeignKey(d => d.IwAdminId)
                .HasConstraintName("fk_iw_admin_profile_iw_admin1");
        });

        modelBuilder.Entity<IwAdminStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iw_admin_status")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwAdminId, "fk_iw_admin_status_iw_admin1_idx");

            entity.Property(e => e.AllCountEnter)
                .HasColumnType("int(11)")
                .HasColumnName("all_count_enter");
            entity.Property(e => e.IwAdminId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_admin_id");

            entity.HasOne(d => d.IwAdmin).WithMany()
                .HasForeignKey(d => d.IwAdminId)
                .HasConstraintName("fk_iw_admin_status_iw_admin1");
        });

        modelBuilder.Entity<IwApiAllCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_api_all_cat")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_api_all_cat_iw_company1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnType("tinytext");
            entity.Property(e => e.CategoryId).HasMaxLength(50);
            entity.Property(e => e.CreateCad).HasColumnType("int(1)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(1)");
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Main).HasMaxLength(100);
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Sub).HasMaxLength(250);
            entity.Property(e => e.Sub2).HasMaxLength(250);
            entity.Property(e => e.Sub3).HasMaxLength(250);
            entity.Property(e => e.Sub4).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.TypeSet)
                .HasMaxLength(120)
                .HasDefaultValueSql("'Product'");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwApiAllCats)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_api_all_cat_iw_company1");
        });

        modelBuilder.Entity<IwApiBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_api_brands")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BrandId)
                .HasColumnType("int(11)")
                .HasColumnName("brand_id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description)
                .HasColumnType("tinytext")
                .HasColumnName("description");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<IwApiProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_api_products")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwApiBrandsId, "fk_iw_api_products_iw_api_brands1_idx");

            entity.HasIndex(e => e.IwApiProductTypeId, "fk_iw_api_products_iw_api_product_type1_idx");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_api_products_iw_company1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.AdminOk)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.CatIds).HasMaxLength(250);
            entity.Property(e => e.Color).HasMaxLength(250);
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasColumnName("gender");
            entity.Property(e => e.ImageSet).HasMaxLength(50);
            entity.Property(e => e.Info)
                .HasColumnType("text")
                .HasColumnName("info");
            entity.Property(e => e.IsDeadProduct)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isDeadProduct");
            entity.Property(e => e.IsInStock)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isInStock");
            entity.Property(e => e.IsNoSize)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isNoSize");
            entity.Property(e => e.IsOneSize)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isOneSize");
            entity.Property(e => e.IwApiBrandsId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("iw_api_brands_id");
            entity.Property(e => e.IwApiProductTypeId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("iw_api_product_type_id");
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ListImageUrl)
                .HasColumnType("text")
                .HasColumnName("listImageUrl");
            entity.Property(e => e.LocalName).HasMaxLength(250);
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasColumnType("tinytext");
            entity.Property(e => e.NoWeightValue).HasColumnType("int(1)");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasColumnType("int(20)");
            entity.Property(e => e.Prop65Risk)
                .HasColumnType("tinyint(4)")
                .HasColumnName("prop65Risk");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Url).HasColumnType("tinytext");
            entity.Property(e => e.UrlCategory)
                .HasMaxLength(250)
                .HasColumnName("url_category");
            entity.Property(e => e.UrlGender)
                .HasMaxLength(250)
                .HasColumnName("url_gender");
            entity.Property(e => e.UrlGroup)
                .HasMaxLength(250)
                .HasColumnName("url_group");
            entity.Property(e => e.UrlGroup2)
                .HasMaxLength(250)
                .HasColumnName("url_group2");

            entity.HasOne(d => d.IwApiBrands).WithMany(p => p.IwApiProducts)
                .HasForeignKey(d => d.IwApiBrandsId)
                .HasConstraintName("fk_iw_api_products_iw_api_brands1");

            entity.HasOne(d => d.IwApiProductType).WithMany(p => p.IwApiProducts)
                .HasForeignKey(d => d.IwApiProductTypeId)
                .HasConstraintName("fk_iw_api_products_iw_api_product_type1");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwApiProducts)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_api_products_iw_company1");
        });

        modelBuilder.Entity<IwApiProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_api_product_type")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.ProductTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("product_type_id");
        });

        modelBuilder.Entity<IwApiProductVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_api_product_variants")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwApiProductsId, "fk_iw_api_product_variants_iw_api_products_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BrandSize)
                .HasMaxLength(255)
                .HasColumnName("brandSize");
            entity.Property(e => e.Colour)
                .HasMaxLength(255)
                .HasColumnName("colour");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.DisplaySizeText)
                .HasMaxLength(255)
                .HasColumnName("displaySizeText");
            entity.Property(e => e.IsAvailable)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isAvailable");
            entity.Property(e => e.IsInStock)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isInStock");
            entity.Property(e => e.IsProp65Risk)
                .HasColumnType("tinyint(4)")
                .HasColumnName("isProp65Risk");
            entity.Property(e => e.IwApiProductsId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("iw_api_products_id");
            entity.Property(e => e.IwCompanyId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PriceCurrent).HasColumnName("price_current");
            entity.Property(e => e.PricePrevious).HasColumnName("price_previous");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SizeDescription)
                .HasMaxLength(255)
                .HasColumnName("sizeDescription");
            entity.Property(e => e.SizeId)
                .HasColumnType("int(11)")
                .HasColumnName("sizeId");
            entity.Property(e => e.SizeOrder)
                .HasColumnType("int(11)")
                .HasColumnName("sizeOrder");

            entity.HasOne(d => d.IwApiProducts).WithMany(p => p.IwApiProductVariants)
                .HasForeignKey(d => d.IwApiProductsId)
                .HasConstraintName("fk_iw_api_product_variants_iw_api_products");
        });

        modelBuilder.Entity<IwApiUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_api_users")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description)
                .HasColumnType("tinytext")
                .HasColumnName("description");
            entity.Property(e => e.Enabled)
                .HasColumnType("int(1)")
                .HasColumnName("enabled");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.SecretKey)
                .HasMaxLength(60)
                .HasColumnName("secret_key");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        modelBuilder.Entity<IwCatchRoot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_catch_root")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Counter)
                .HasColumnType("int(11)")
                .HasColumnName("counter");
            entity.Property(e => e.LastUpdatedDate)
                .HasMaxLength(30)
                .HasColumnName("last_updated_date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Root)
                .HasColumnType("int(1)")
                .HasColumnName("root");
            entity.Property(e => e.RootId)
                .HasColumnType("int(11)")
                .HasColumnName("root_id");
            entity.Property(e => e.TotalProduct)
                .HasColumnType("int(11)")
                .HasColumnName("total_product");
        });

        modelBuilder.Entity<IwCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_company")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwCountryId, "fk_iw_company_iw_country1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_country_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");

            entity.HasOne(d => d.IwCountry).WithMany(p => p.IwCompanies)
                .HasForeignKey(d => d.IwCountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_company_iw_country1");
        });

        modelBuilder.Entity<IwConnectApi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_connect_api")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_connect_api_iw_company1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AllCount)
                .HasColumnType("int(11)")
                .HasColumnName("all_count");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.ExpireDate)
                .HasMaxLength(100)
                .HasColumnName("expire_date");
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwConnectApis)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_connect_api_iw_company1");
        });

        modelBuilder.Entity<IwConnectSm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_connect_sms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_connect_sms_iw_company1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AllCount)
                .HasColumnType("int(11)")
                .HasColumnName("all_count");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.ExpireDate)
                .HasMaxLength(100)
                .HasColumnName("expire_date");
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwConnectSms)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_connect_sms_iw_company1");
        });

        modelBuilder.Entity<IwCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_country")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<IwCurrenciesConversion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_currencies_conversion")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwCurrenciesId1)
                .HasColumnType("int(11)")
                .HasColumnName("iw_currencies_id1");
            entity.Property(e => e.IwCurrenciesId2)
                .HasColumnType("int(11)")
                .HasColumnName("iw_currencies_id2");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
        });

        modelBuilder.Entity<IwCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_currencies")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCountryId, "fk_iw_currencies_iw_country1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_country_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.IwCountry).WithMany(p => p.IwCurrencies)
                .HasForeignKey(d => d.IwCountryId)
                .HasConstraintName("fk_iw_currencies_iw_country1");
        });

        modelBuilder.Entity<IwNewMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_new_menu")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwProductWeightId, "fk_iw_new_menu_iw_products_weight_price1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApiId).HasMaxLength(25);
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.FromApi).HasColumnType("int(1)");
            entity.Property(e => e.Icon).HasMaxLength(250);
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.LinkTo).HasColumnType("tinytext");
            entity.Property(e => e.LocalName).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.IwProductWeight).WithMany(p => p.IwNewMenus)
                .HasForeignKey(d => d.IwProductWeightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_iw_products_weight_price1");
        });

        modelBuilder.Entity<IwNewMenu2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_new_menu_2")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_new_menu_2_iw_company1_idx");

            entity.HasIndex(e => e.IwNewMenuId, "fk_iw_new_menu_2_iw_new_menu1_idx");

            entity.HasIndex(e => e.IwProductWeightId, "fk_iw_new_menu_2_iw_product_weight1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApiId).HasMaxLength(25);
            entity.Property(e => e.CatId).HasMaxLength(100);
            entity.Property(e => e.CreateCad).HasColumnType("int(1)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.FromApi).HasColumnType("int(1)");
            entity.Property(e => e.Icon).HasMaxLength(250);
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.IwNewMenuId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_new_menu_id");
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.LinkTo).HasColumnType("tinytext");
            entity.Property(e => e.LocalName).HasMaxLength(250);
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwNewMenu2s)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_2_iw_company1");

            entity.HasOne(d => d.IwNewMenu).WithMany(p => p.IwNewMenu2s)
                .HasForeignKey(d => d.IwNewMenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_2_iw_new_menu1");

            entity.HasOne(d => d.IwProductWeight).WithMany(p => p.IwNewMenu2s)
                .HasForeignKey(d => d.IwProductWeightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_2_iw_product_weight1");
        });

        modelBuilder.Entity<IwNewMenu3>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_new_menu_3")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_new_menu_3_iw_company1_idx");

            entity.HasIndex(e => e.IwNewMenu2Id, "fk_iw_new_menu_3_iw_new_menu_21_idx");

            entity.HasIndex(e => e.IwProductWeightId, "fk_iw_new_menu_3_iw_product_weight1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApiId).HasMaxLength(25);
            entity.Property(e => e.CatId).HasMaxLength(100);
            entity.Property(e => e.CreateCad).HasColumnType("int(1)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.FromApi).HasColumnType("int(1)");
            entity.Property(e => e.Icon).HasMaxLength(250);
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.IwNewMenu2Id)
                .HasColumnType("int(11)")
                .HasColumnName("iw_new_menu_2_id");
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.LinkTo).HasColumnType("tinytext");
            entity.Property(e => e.LocalName).HasMaxLength(250);
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwNewMenu3s)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_3_iw_company1");

            entity.HasOne(d => d.IwNewMenu2).WithMany(p => p.IwNewMenu3s)
                .HasForeignKey(d => d.IwNewMenu2Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_3_iw_new_menu_21");

            entity.HasOne(d => d.IwProductWeight).WithMany(p => p.IwNewMenu3s)
                .HasForeignKey(d => d.IwProductWeightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_3_iw_product_weight1");
        });

        modelBuilder.Entity<IwNewMenu4>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_new_menu_4")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_new_menu_4_iw_company1_idx");

            entity.HasIndex(e => e.IwNewMenu3Id, "fk_iw_new_menu_4_iw_new_menu_31_idx");

            entity.HasIndex(e => e.IwProductWeightId, "fk_iw_new_menu_4_iw_product_weight1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApiId).HasMaxLength(25);
            entity.Property(e => e.AttributeId).HasColumnType("int(11)");
            entity.Property(e => e.CatId).HasMaxLength(100);
            entity.Property(e => e.CreateCad).HasColumnType("int(1)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.FromApi).HasColumnType("int(1)");
            entity.Property(e => e.Icon).HasMaxLength(250);
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.IwNewMenu3Id)
                .HasColumnType("int(11)")
                .HasColumnName("iw_new_menu_3_id");
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.LinkTo).HasColumnType("tinytext");
            entity.Property(e => e.LocalName).HasMaxLength(250);
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwNewMenu4s)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_4_iw_company1");

            entity.HasOne(d => d.IwNewMenu3).WithMany(p => p.IwNewMenu4s)
                .HasForeignKey(d => d.IwNewMenu3Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_4_iw_new_menu_31");

            entity.HasOne(d => d.IwProductWeight).WithMany(p => p.IwNewMenu4s)
                .HasForeignKey(d => d.IwProductWeightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_new_menu_4_iw_product_weight1");
        });

        modelBuilder.Entity<IwPanelAdminPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_panel_admin_page")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.IwPanelAdminPartId, "fk_iw_panel_admin_page_iw_panel_admin_part1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwPanelAdminPartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_panel_admin_part_id");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PageName).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(120);
            entity.Property(e => e.TopModify)
                .IsRequired()
                .HasDefaultValueSql("'1'");

            entity.HasOne(d => d.IwPanelAdminPart).WithMany(p => p.IwPanelAdminPages)
                .HasForeignKey(d => d.IwPanelAdminPartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_panel_admin_page_iw_panel_admin_part1");
        });

        modelBuilder.Entity<IwPanelAdminPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_panel_admin_part")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.PartName, "PartName");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.FaIcon).HasMaxLength(100);
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PartName).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(120);
        });

        modelBuilder.Entity<IwPanelUserPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_panel_user_page")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.IwPanelUserPartId, "fk_iw_panel_user_page_iw_panel_user_part1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwPanelUserPartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_panel_user_part_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PageName).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(120);
            entity.Property(e => e.TopModify)
                .IsRequired()
                .HasDefaultValueSql("'1'");

            entity.HasOne(d => d.IwPanelUserPart).WithMany(p => p.IwPanelUserPages)
                .HasForeignKey(d => d.IwPanelUserPartId)
                .HasConstraintName("fk_iw_panel_user_page_iw_panel_user_part1");
        });

        modelBuilder.Entity<IwPanelUserPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_panel_user_part")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.PartName, "PartName");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.FaIcon).HasMaxLength(100);
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PartName).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(120);
        });

        modelBuilder.Entity<IwPaymentState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_payment_state")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_payment_state_iw_user1_idx");

            entity.HasIndex(e => e.IwUserShoppingCartId, "fk_iw_payment_state_iw_user_shopping_cart1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasMaxLength(100);
            entity.Property(e => e.AmountRial).HasMaxLength(100);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.Cid)
                .HasMaxLength(100)
                .HasColumnName("CID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.HashedCardNumber).HasMaxLength(200);
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserShoppingCartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_shopping_cart_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Mid)
                .HasMaxLength(100)
                .HasColumnName("MID");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.RefNum).HasMaxLength(100);
            entity.Property(e => e.ResNum).HasMaxLength(100);
            entity.Property(e => e.ResitId).HasMaxLength(250);
            entity.Property(e => e.Rrn)
                .HasMaxLength(200)
                .HasColumnName("RRN");
            entity.Property(e => e.SecurePan).HasMaxLength(100);
            entity.Property(e => e.Secvl).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.StateCode).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TerminalId).HasMaxLength(100);
            entity.Property(e => e.Token).HasMaxLength(250);
            entity.Property(e => e.TraceNo).HasMaxLength(100);
            entity.Property(e => e.Wage).HasMaxLength(100);

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwPaymentStates)
                .HasForeignKey(d => d.IwUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_payment_state_iw_user1");

            entity.HasOne(d => d.IwUserShoppingCart).WithMany(p => p.IwPaymentStates)
                .HasForeignKey(d => d.IwUserShoppingCartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_payment_state_iw_user_shopping_cart1");
        });

        modelBuilder.Entity<IwProductStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iw_product_status")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwApiProductsId, "fk_iw_product_status_iw_api_products1_idx");

            entity.Property(e => e.IwApiProductsId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("iw_api_products_id");
            entity.Property(e => e.Pbuy)
                .HasColumnType("int(14)")
                .HasColumnName("PBuy");
            entity.Property(e => e.Pscore)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(1)")
                .HasColumnName("PScore");
            entity.Property(e => e.Pview)
                .HasColumnType("int(14)")
                .HasColumnName("PView");

            entity.HasOne(d => d.IwApiProducts).WithMany()
                .HasForeignKey(d => d.IwApiProductsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_product_status_iw_api_products1");
        });

        modelBuilder.Entity<IwProductWeight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_product_weight")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
        });

        modelBuilder.Entity<IwProductsDeliveryPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_products_delivery_price")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCompanyId, "fk_iw_products_delivery_price_iw_company1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bigger).HasColumnType("int(15)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Smaller).HasColumnType("int(15)");

            entity.HasOne(d => d.IwCompany).WithMany(p => p.IwProductsDeliveryPrices)
                .HasForeignKey(d => d.IwCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_products_delivery_price_iw_company1");
        });

        modelBuilder.Entity<IwProductsPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_products_price")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCurrenciesConversionId, "fk_iw_products_price_iw_currencies_conversion1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwCurrenciesConversionId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_currencies_conversion_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwCurrenciesConversion).WithMany(p => p.IwProductsPrices)
                .HasForeignKey(d => d.IwCurrenciesConversionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_products_price_iw_currencies_conversion1");
        });

        modelBuilder.Entity<IwProductsWeightPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_products_weight_price")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwProductWeightId, "fk_iw_products_weight_price_iw_product_weight1_idx");

            entity.HasIndex(e => e.IwWeightCountryId, "fk_iw_products_weight_price_iw_weight_country1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwProductWeightId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_product_weight_id");
            entity.Property(e => e.IwWeightCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_weight_country_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwProductWeight).WithMany(p => p.IwProductsWeightPrices)
                .HasForeignKey(d => d.IwProductWeightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_products_weight_price_iw_product_weight1");

            entity.HasOne(d => d.IwWeightCountry).WithMany(p => p.IwProductsWeightPrices)
                .HasForeignKey(d => d.IwWeightCountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_products_weight_price_iw_weight_country1");
        });

        modelBuilder.Entity<IwShippingProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_shipping_product")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AddressId)
                .HasColumnType("int(11)")
                .HasColumnName("address_id");
            entity.Property(e => e.BarcodeNumber)
                .HasColumnType("int(16)")
                .HasColumnName("barcode_number");
            entity.Property(e => e.CartId)
                .HasColumnType("int(11)")
                .HasColumnName("cart_id");
            entity.Property(e => e.CopFile)
                .HasMaxLength(255)
                .HasColumnName("cop_file");
            entity.Property(e => e.InvoiceId)
                .HasColumnType("int(11)")
                .HasColumnName("invoice_id");
            entity.Property(e => e.PackingDescription)
                .HasMaxLength(255)
                .HasColumnName("packing_description");
            entity.Property(e => e.PackingNumber)
                .HasColumnType("int(11)")
                .HasColumnName("packing_number");
            entity.Property(e => e.PackingWeight).HasColumnName("packing_weight");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Size)
                .HasMaxLength(255)
                .HasColumnName("size");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(255)
                .HasColumnName("tracking_number");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<IwStatusView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_status_view")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwWebsitePagesId, "fk_iw_status_view_iw_website_pages1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AllCount)
                .HasColumnType("int(11)")
                .HasColumnName("all_count");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.ExpireDate)
                .HasMaxLength(100)
                .HasColumnName("expire_date");
            entity.Property(e => e.IwWebsitePagesId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_pages_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwWebsitePages).WithMany(p => p.IwStatusViews)
                .HasForeignKey(d => d.IwWebsitePagesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_status_view_iw_website_pages1");
        });

        modelBuilder.Entity<IwTicket>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IwTicketsPrioritiesId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("iw_tickets")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwTicketsCategoriesId, "fk_iw_tickets_iw_tickets_categories1_idx");

            entity.HasIndex(e => e.IwTicketsPrioritiesId, "fk_iw_tickets_iw_tickets_priorities1_idx");

            entity.HasIndex(e => e.IwTicketsSenderId, "fk_iw_tickets_iw_tickets_sender1_idx");

            entity.HasIndex(e => e.IwTicketsStatusId, "fk_iw_tickets_iw_tickets_status1_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IwTicketsPrioritiesId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_tickets_priorities_id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwTicketsCategoriesId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_tickets_categories_id");
            entity.Property(e => e.IwTicketsSenderId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_tickets_sender_id");
            entity.Property(e => e.IwTicketsStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_tickets_status_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.MemberId)
                .HasColumnType("int(11)")
                .HasColumnName("member_id");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Subject)
                .HasMaxLength(250)
                .HasColumnName("subject");

            entity.HasOne(d => d.IwTicketsCategories).WithMany(p => p.IwTickets)
                .HasForeignKey(d => d.IwTicketsCategoriesId)
                .HasConstraintName("fk_iw_tickets_iw_tickets_categories1");

            entity.HasOne(d => d.IwTicketsPriorities).WithMany(p => p.IwTickets)
                .HasForeignKey(d => d.IwTicketsPrioritiesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_tickets_iw_tickets_priorities1");

            entity.HasOne(d => d.IwTicketsSender).WithMany(p => p.IwTickets)
                .HasForeignKey(d => d.IwTicketsSenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_tickets_iw_tickets_sender1");

            entity.HasOne(d => d.IwTicketsStatus).WithMany(p => p.IwTickets)
                .HasForeignKey(d => d.IwTicketsStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_tickets_iw_tickets_status1");
        });

        modelBuilder.Entity<IwTicketsCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_tickets_categories")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<IwTicketsPriority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_tickets_priorities")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<IwTicketsReply>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_tickets_replies")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwTicketsId, "fk_iw_tickets_replies_iw_tickets1_idx");

            entity.HasIndex(e => e.IwTicketsSenderId, "fk_iw_tickets_replies_iw_tickets_sender1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwTicketsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_tickets_id");
            entity.Property(e => e.IwTicketsSenderId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_tickets_sender_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.MemberId)
                .HasColumnType("int(11)")
                .HasColumnName("member_id");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwTicketsSender).WithMany(p => p.IwTicketsReplies)
                .HasForeignKey(d => d.IwTicketsSenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_tickets_replies_iw_tickets_sender1");
        });

        modelBuilder.Entity<IwTicketsSender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_tickets_sender")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(45)
                .HasColumnName("type");
        });

        modelBuilder.Entity<IwTicketsStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_tickets_status")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<IwUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.IwUserGroupId, "fk_iw_user_iw_user_group1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CellNumber).HasMaxLength(15);
            entity.Property(e => e.ChangePass).HasColumnType("int(1)");
            entity.Property(e => e.CountEnter).HasColumnType("int(11)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.IwUserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_group_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.NationalCode).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.PreRefrence)
                .HasMaxLength(255)
                .HasColumnName("pre_refrence");

            entity.HasOne(d => d.IwUserGroup).WithMany(p => p.IwUsers)
                .HasForeignKey(d => d.IwUserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_iw_user_group1");
        });

        modelBuilder.Entity<IwUserAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_access")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwUserGroupId, "fk_iw_user_access_iw_user_group1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AllAccess)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.AllTools)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwUserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_group_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwUserGroup).WithMany(p => p.IwUserAccesses)
                .HasForeignKey(d => d.IwUserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_access_iw_user_group1");
        });

        modelBuilder.Entity<IwUserAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iw_user_address")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwUserAddressDetailsId, "fk_iw_user_address_iw_user_address_details1_idx");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_address_iw_user_idx");

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.IwUserAddressDetailsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_address_details_id");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwUserAddressDetails).WithMany()
                .HasForeignKey(d => d.IwUserAddressDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_address_iw_user_address_details1");

            entity.HasOne(d => d.IwUser).WithMany()
                .HasForeignKey(d => d.IwUserId)
                .HasConstraintName("fk_iw_user_address_iw_user");
        });

        modelBuilder.Entity<IwUserAddressDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_address_details")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwCountryId, "fk_iw_user_address_details_iw_country1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.Family)
                .HasMaxLength(255)
                .HasColumnName("family");
            entity.Property(e => e.Gender)
                .HasMaxLength(45)
                .HasColumnName("gender");
            entity.Property(e => e.IwCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_country_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NicName).HasMaxLength(250);
            entity.Property(e => e.OtherTel).HasMaxLength(20);
            entity.Property(e => e.PostCode).HasMaxLength(25);

            entity.HasOne(d => d.IwCountry).WithMany(p => p.IwUserAddressDetails)
                .HasForeignKey(d => d.IwCountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_address_details_iw_country1");
        });

        modelBuilder.Entity<IwUserDispatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_dispatch")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BasketIdKey).HasMaxLength(25);
            entity.Property(e => e.ChkState).HasMaxLength(50);
            entity.Property(e => e.Count).HasMaxLength(10);
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IdKey).HasMaxLength(25);
            entity.Property(e => e.ModifyDate).HasMaxLength(10);
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(15)
                .HasColumnName("ModifyIP");
            entity.Property(e => e.ModifyStrTime).HasMaxLength(26);
            entity.Property(e => e.ModifyTime).HasMaxLength(8);
            entity.Property(e => e.OrderNu).HasMaxLength(100);
            entity.Property(e => e.PackWeight).HasMaxLength(100);
            entity.Property(e => e.PackingIdKey).HasMaxLength(25);
            entity.Property(e => e.PaymentIdKey).HasMaxLength(25);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasMaxLength(100);
            entity.Property(e => e.ProductSizeId).HasMaxLength(100);
            entity.Property(e => e.Size).HasMaxLength(100);
            entity.Property(e => e.UserAddressId).HasMaxLength(25);
            entity.Property(e => e.UserIdKey).HasMaxLength(25);
        });

        modelBuilder.Entity<IwUserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Name");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<IwUserInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_invoice")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApiProductsId)
                .HasColumnType("int(11)")
                .HasColumnName("api_products_id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.CurrenciesConversionId)
                .HasColumnType("int(11)")
                .HasColumnName("currencies_conversion_id");
            entity.Property(e => e.IwUserAddress)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_address");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.PaymentId)
                .HasColumnType("int(11)")
                .HasColumnName("payment_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.PromoCode)
                .HasMaxLength(100)
                .HasColumnName("promo_code");
            entity.Property(e => e.ShoppingCartId)
                .HasColumnType("int(11)")
                .HasColumnName("shopping_cart_id");
            entity.Property(e => e.Size)
                .HasMaxLength(100)
                .HasColumnName("size");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.UserOrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("user_order_status_id");
        });

        modelBuilder.Entity<IwUserLookDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_look_documents")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AdminComment)
                .HasColumnType("tinytext")
                .HasColumnName("admin_comment");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .HasColumnType("int(1)")
                .HasColumnName("enabled");
            entity.Property(e => e.IdCartBack)
                .HasMaxLength(255)
                .HasColumnName("id_cart_back");
            entity.Property(e => e.IdCartFront)
                .HasMaxLength(255)
                .HasColumnName("id_cart_front");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Stat)
                .HasColumnType("int(1)")
                .HasColumnName("stat");
            entity.Property(e => e.UserFace)
                .HasMaxLength(255)
                .HasColumnName("user_face");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<IwUserLookGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_look_group")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .HasColumnType("int(1)")
                .HasColumnName("enabled");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Root)
                .HasMaxLength(255)
                .HasColumnName("root");
        });

        modelBuilder.Entity<IwUserLookPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_look_page")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AdminComment)
                .HasColumnType("tinytext")
                .HasColumnName("admin_comment");
            entity.Property(e => e.Closet)
                .HasColumnType("int(1)")
                .HasColumnName("closet");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .HasColumnType("int(1)")
                .HasColumnName("enabled");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.LookPageBanner)
                .HasMaxLength(255)
                .HasColumnName("look_page_banner");
            entity.Property(e => e.LookPageColor)
                .HasMaxLength(45)
                .HasColumnName("look_page_color");
            entity.Property(e => e.LookPageDescription)
                .HasColumnType("tinytext")
                .HasColumnName("look_page_description");
            entity.Property(e => e.LookPageName)
                .HasMaxLength(255)
                .HasColumnName("look_page_name");
            entity.Property(e => e.LookPageProfile)
                .HasMaxLength(255)
                .HasColumnName("look_page_profile");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Stat)
                .HasColumnType("int(1)")
                .HasColumnName("stat");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<IwUserLookPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_look_post")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AdminComment)
                .HasColumnType("tinytext")
                .HasColumnName("admin_comment");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .HasColumnType("int(1)")
                .HasColumnName("enabled");
            entity.Property(e => e.Image1)
                .HasMaxLength(255)
                .HasColumnName("image1");
            entity.Property(e => e.Image2)
                .HasMaxLength(255)
                .HasColumnName("image2");
            entity.Property(e => e.Image3)
                .HasMaxLength(255)
                .HasColumnName("image3");
            entity.Property(e => e.Image4)
                .HasMaxLength(255)
                .HasColumnName("image4");
            entity.Property(e => e.Iteml1)
                .HasColumnType("int(11)")
                .HasColumnName("iteml1");
            entity.Property(e => e.Iteml2)
                .HasColumnType("int(11)")
                .HasColumnName("iteml2");
            entity.Property(e => e.Iteml3)
                .HasColumnType("int(11)")
                .HasColumnName("iteml3");
            entity.Property(e => e.Iteml4)
                .HasColumnType("int(11)")
                .HasColumnName("iteml4");
            entity.Property(e => e.Itemm1)
                .HasColumnType("int(11)")
                .HasColumnName("itemm1");
            entity.Property(e => e.Itemm2)
                .HasColumnType("int(11)")
                .HasColumnName("itemm2");
            entity.Property(e => e.Itemm3)
                .HasColumnType("int(11)")
                .HasColumnName("itemm3");
            entity.Property(e => e.Itemm4)
                .HasColumnType("int(11)")
                .HasColumnName("itemm4");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.LookGender)
                .HasMaxLength(45)
                .HasColumnName("look_gender");
            entity.Property(e => e.LookGroup)
                .HasColumnType("int(11)")
                .HasColumnName("look_group");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Stat)
                .HasColumnType("int(1)")
                .HasColumnName("stat");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<IwUserObserver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_observer")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_observer_iw_user1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Online).HasColumnType("tinyint(1) unsigned");

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserObservers)
                .HasForeignKey(d => d.IwUserId)
                .HasConstraintName("fk_iw_user_observer_iw_user1");
        });

        modelBuilder.Entity<IwUserOrderLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_order_line")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwApiProductVariantsId, "fk_iw_user_order_line_iw_api_product_variants1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwApiProductVariantsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_api_product_variants_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Qty)
                .HasColumnType("int(11)")
                .HasColumnName("qty");

            entity.HasOne(d => d.IwApiProductVariants).WithMany(p => p.IwUserOrderLines)
                .HasForeignKey(d => d.IwApiProductVariantsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_order_line_iw_api_product_variants1");
        });

        modelBuilder.Entity<IwUserOrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_order_status")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Status)
                .HasMaxLength(45)
                .HasColumnName("status");
        });

        modelBuilder.Entity<IwUserPacking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_packing")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_packing_iw_user1_idx");

            entity.HasIndex(e => e.IwUserShopOrderId, "fk_iw_user_packing_iw_user_shop_order1_idx");

            entity.HasIndex(e => e.IwUserShoppingCartId, "fk_iw_user_packing_iw_user_shopping_cart1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ChkState).HasMaxLength(50);
            entity.Property(e => e.Count).HasMaxLength(10);
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserShopOrderId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_shop_order_id");
            entity.Property(e => e.IwUserShoppingCartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_shopping_cart_id");
            entity.Property(e => e.ModifyDate).HasMaxLength(10);
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(15)
                .HasColumnName("ModifyIP");
            entity.Property(e => e.ModifyStrTime).HasMaxLength(26);
            entity.Property(e => e.ModifyTime).HasMaxLength(8);
            entity.Property(e => e.OrderNu).HasMaxLength(100);
            entity.Property(e => e.PackWeight).HasMaxLength(100);
            entity.Property(e => e.PackingIdKey).HasMaxLength(25);
            entity.Property(e => e.PaymentIdKey).HasMaxLength(25);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasMaxLength(100);
            entity.Property(e => e.ProductSizeId).HasMaxLength(100);
            entity.Property(e => e.Size).HasMaxLength(100);
            entity.Property(e => e.TrackingNu).HasMaxLength(100);
            entity.Property(e => e.UserAddressId).HasMaxLength(25);

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserPackings)
                .HasForeignKey(d => d.IwUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_packing_iw_user1");

            entity.HasOne(d => d.IwUserShopOrder).WithMany(p => p.IwUserPackings)
                .HasForeignKey(d => d.IwUserShopOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_packing_iw_user_shop_order1");

            entity.HasOne(d => d.IwUserShoppingCart).WithMany(p => p.IwUserPackings)
                .HasForeignKey(d => d.IwUserShoppingCartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_packing_iw_user_shopping_cart1");
        });

        modelBuilder.Entity<IwUserPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_payment_method")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_payment_method_iw_user1_idx");

            entity.HasIndex(e => e.IwUserPaymentTypeId, "fk_iw_user_payment_method_iw_user_payment_type1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(255)
                .HasColumnName("account_number");
            entity.Property(e => e.ExpiryDate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("expiry_date");
            entity.Property(e => e.IsDefault)
                .HasColumnType("int(1)")
                .HasColumnName("is_default");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserPaymentTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_payment_type_id");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserPaymentMethods)
                .HasForeignKey(d => d.IwUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_payment_method_iw_user1");

            entity.HasOne(d => d.IwUserPaymentType).WithMany(p => p.IwUserPaymentMethods)
                .HasForeignKey(d => d.IwUserPaymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_payment_method_iw_user_payment_type1");
        });

        modelBuilder.Entity<IwUserPaymentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_payment_type")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<IwUserReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_review")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_review_iw_user1_idx");

            entity.HasIndex(e => e.IwUserOrderLineId, "fk_iw_user_review_iw_user_order_line1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("tinytext")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserOrderLineId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_order_line_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.RatingValue).HasColumnName("rating_value");

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserReviews)
                .HasForeignKey(d => d.IwUserId)
                .HasConstraintName("fk_iw_user_review_iw_user1");

            entity.HasOne(d => d.IwUserOrderLine).WithMany(p => p.IwUserReviews)
                .HasForeignKey(d => d.IwUserOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_review_iw_user_order_line1");
        });

        modelBuilder.Entity<IwUserShopOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_shop_order")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_shop_order_iw_user1_idx");

            entity.HasIndex(e => e.IwUserAddressDetailsId, "fk_iw_user_shop_order_iw_user_address_details1_idx");

            entity.HasIndex(e => e.IwUserOrderStatusId, "fk_iw_user_shop_order_iw_user_order_status1_idx");

            entity.HasIndex(e => e.IwUserPaymentMethodId, "fk_iw_user_shop_order_iw_user_payment_method1_idx");

            entity.HasIndex(e => e.IwUserShoppingMethodId, "fk_iw_user_shop_order_iw_user_shopping_method1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwUserAddressDetailsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_address_details_id");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserOrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_order_status_id");
            entity.Property(e => e.IwUserPaymentMethodId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_payment_method_id");
            entity.Property(e => e.IwUserShoppingMethodId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_shopping_method_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.OrderTotal)
                .HasColumnType("int(11)")
                .HasColumnName("order_total");

            entity.HasOne(d => d.IwUserAddressDetails).WithMany(p => p.IwUserShopOrders)
                .HasForeignKey(d => d.IwUserAddressDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_shop_order_iw_user_address_details1");

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserShopOrders)
                .HasForeignKey(d => d.IwUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_shop_order_iw_user1");

            entity.HasOne(d => d.IwUserOrderStatus).WithMany(p => p.IwUserShopOrders)
                .HasForeignKey(d => d.IwUserOrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_shop_order_iw_user_order_status1");

            entity.HasOne(d => d.IwUserPaymentMethod).WithMany(p => p.IwUserShopOrders)
                .HasForeignKey(d => d.IwUserPaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_shop_order_iw_user_payment_method1");

            entity.HasOne(d => d.IwUserShoppingMethod).WithMany(p => p.IwUserShopOrders)
                .HasForeignKey(d => d.IwUserShoppingMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_shop_order_iw_user_shopping_method1");
        });

        modelBuilder.Entity<IwUserShoppingCart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_shopping_cart")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_shopping_cart_iw_user1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IwUserAddress)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_address");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserOrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_order_status_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserShoppingCarts)
                .HasForeignKey(d => d.IwUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_shopping_cart_iw_user1");
        });

        modelBuilder.Entity<IwUserShoppingMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_shopping_method")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<IwUserTempCart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_user_temp_cart")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwUserId, "fk_iw_user_temp_cart_iw_user1_idx");

            entity.HasIndex(e => e.IwUserShoppingCartId, "fk_iw_user_temp_cart_iw_user_shopping_cart1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.CurrenciesConversionId)
                .HasColumnType("int(11)")
                .HasColumnName("currencies_conversion_id");
            entity.Property(e => e.IwApiProductsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_api_products_id");
            entity.Property(e => e.IwUserId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_id");
            entity.Property(e => e.IwUserShoppingCartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_shopping_cart_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.PromoCode)
                .HasMaxLength(100)
                .HasColumnName("promo_code");
            entity.Property(e => e.Qty)
                .HasColumnType("int(11)")
                .HasColumnName("qty");
            entity.Property(e => e.SessionId)
                .HasMaxLength(250)
                .HasColumnName("session_id");

            entity.HasOne(d => d.IwUser).WithMany(p => p.IwUserTempCarts)
                .HasForeignKey(d => d.IwUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_iw_user_temp_cart_iw_user1");

            entity.HasOne(d => d.IwUserShoppingCart).WithMany(p => p.IwUserTempCarts)
                .HasForeignKey(d => d.IwUserShoppingCartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_user_temp_cart_iw_user_shopping_cart1");
        });

        modelBuilder.Entity<IwViewAdminPanelMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("iw_view_admin_panel_menu");

            entity.Property(e => e.PageId).HasColumnType("int(11)");
            entity.Property(e => e.PageName)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PagePartId).HasColumnType("int(11)");
            entity.Property(e => e.PagePname)
                .HasMaxLength(100)
                .HasColumnName("PagePName")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PartFaIcon)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PartId).HasColumnType("int(11)");
            entity.Property(e => e.PartName)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PartPname)
                .HasMaxLength(100)
                .HasColumnName("PartPName")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<IwViewProductNotCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("iw_view_product_not_check");

            entity.Property(e => e.AdminOk).HasColumnType("int(1)");
            entity.Property(e => e.Content)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Enabled).HasColumnType("int(1)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ImageSet)
                .HasMaxLength(50)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IwApiBrandsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_api_brands_id");
            entity.Property(e => e.IwApiProductTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_api_product_type_id");
            entity.Property(e => e.IwCompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_company_id");
            entity.Property(e => e.LocalName)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.NoWeightValue).HasColumnType("int(1)");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ProductId).HasColumnType("int(20)");
            entity.Property(e => e.Url)
                .HasColumnType("tinytext")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UrlCategory)
                .HasMaxLength(250)
                .HasColumnName("url_category")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UrlGender)
                .HasMaxLength(250)
                .HasColumnName("url_gender")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UrlGroup)
                .HasMaxLength(250)
                .HasColumnName("url_group")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UrlGroup2)
                .HasMaxLength(250)
                .HasColumnName("url_group2")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<ViewProductRand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("iw_view_product_rand");

            entity.Property(e => e.BrandsId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("brands_id");
            entity.Property(e => e.CatIds)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Color)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CompanyId)
                .HasColumnType("int(11)")
                .HasColumnName("company_id");
            entity.Property(e => e.Content)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ImageSet)
                .HasMaxLength(50)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ProductTypeId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("product_type_id");
            entity.Property(e => e.Sale)
                .HasColumnType("int(1)")
                .HasColumnName("sale");
            entity.Property(e => e.UrlCategory)
                .HasMaxLength(250)
                .HasColumnName("url_category")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UrlGender)
                .HasMaxLength(250)
                .HasColumnName("url_gender")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UrlGroup)
                .HasMaxLength(250)
                .HasColumnName("url_group")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<IwViewUserAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("iw_view_user_address");

            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressDescription)
                .HasColumnType("tinytext")
                .HasColumnName("address_description")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressNicname)
                .HasMaxLength(250)
                .HasColumnName("address_nicname")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressOtherTel)
                .HasMaxLength(20)
                .HasColumnName("address_other_tel")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressPostCode)
                .HasMaxLength(25)
                .HasColumnName("address_post_code")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressUserFamily)
                .HasMaxLength(255)
                .HasColumnName("address_user_family")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressUserGender)
                .HasMaxLength(45)
                .HasColumnName("address_user_gender")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AddressUserName)
                .HasMaxLength(255)
                .HasColumnName("address_user_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CountryName)
                .HasMaxLength(250)
                .HasColumnName("country_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.IwCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_country_id");
            entity.Property(e => e.IwUserAddressDetailsId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_user_address_details_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<IwViewUserCart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("iw_view_user_cart");

            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Amount)
                .HasMaxLength(100)
                .HasColumnName("amount")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ApiProductsId)
                .HasColumnType("int(11)")
                .HasColumnName("api_products_id");
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.BarcodeNumber)
                .HasColumnType("int(16)")
                .HasColumnName("barcode_number");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Colour)
                .HasMaxLength(255)
                .HasColumnName("colour")
                .UseCollation("utf8mb4_general_ci");
            entity.Property(e => e.CompanyCountryId)
                .HasColumnType("int(11)")
                .HasColumnName("company_country_id");
            entity.Property(e => e.CompanyCountryName)
                .HasMaxLength(250)
                .HasColumnName("company_country_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("company_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("company_name")
                .UseCollation("utf8mb4_general_ci");
            entity.Property(e => e.CopFile)
                .HasMaxLength(255)
                .HasColumnName("cop_file")
                .UseCollation("utf8mb4_general_ci");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(250)
                .HasColumnName("country_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrenciesConversionId)
                .HasColumnType("int(11)")
                .HasColumnName("currencies_conversion_id");
            entity.Property(e => e.CurrenciesId1)
                .HasColumnType("int(11)")
                .HasColumnName("currencies_id1");
            entity.Property(e => e.CurrenciesId2)
                .HasColumnType("int(11)")
                .HasColumnName("currencies_id2");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(250)
                .HasColumnName("currency_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .HasColumnName("group_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Images)
                .HasColumnName("images")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.InvoiceId)
                .HasColumnType("int(11)")
                .HasColumnName("invoice_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .HasColumnName("mobile")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.NationalCode)
                .HasMaxLength(10)
                .HasColumnName("national_code")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PackingNumber)
                .HasColumnType("int(11)")
                .HasColumnName("packing_number");
            entity.Property(e => e.PackingWeight).HasColumnName("packing_weight");
            entity.Property(e => e.PaymentId)
                .HasColumnType("int(11)")
                .HasColumnName("payment_id");
            entity.Property(e => e.PostCode)
                .HasMaxLength(25)
                .HasColumnName("post_code")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(100)
                .HasColumnName("product_code")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasColumnType("tinytext")
                .HasColumnName("product_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.SecurePan)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Size)
                .HasMaxLength(100)
                .HasColumnName("size")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.SizeOrder)
                .HasColumnType("int(11)")
                .HasColumnName("size_order");
            entity.Property(e => e.SizeText)
                .HasMaxLength(255)
                .HasColumnName("size_text")
                .UseCollation("utf8mb4_general_ci");
            entity.Property(e => e.Status)
                .HasMaxLength(45)
                .HasColumnName("status")
                .UseCollation("utf8mb4_general_ci");
            entity.Property(e => e.TraceNo)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(255)
                .HasColumnName("tracking_number")
                .UseCollation("utf8mb4_general_ci");
            entity.Property(e => e.Url)
                .HasColumnType("tinytext")
                .HasColumnName("url")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserAddress)
                .HasColumnType("int(11)")
                .HasColumnName("user_address");
            entity.Property(e => e.UserAddressDescription)
                .HasColumnType("tinytext")
                .HasColumnName("user_address_description")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserAddressFamily)
                .HasMaxLength(255)
                .HasColumnName("user_address_family")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserAddressGender)
                .HasMaxLength(45)
                .HasColumnName("user_address_gender")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserAddressName)
                .HasMaxLength(255)
                .HasColumnName("user_address_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserAddressOthertel)
                .HasMaxLength(20)
                .HasColumnName("user_address_othertel")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("user_group_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .HasColumnName("user_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UserOrderStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("user_order_status_id");
            entity.Property(e => e.UserShoppingCartId)
                .HasColumnType("int(11)")
                .HasColumnName("user_shopping_cart_id");
        });

        modelBuilder.Entity<IwViewUserPanelMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("iw_view_user_panel_menu");

            entity.Property(e => e.PageId).HasColumnType("int(11)");
            entity.Property(e => e.PageName)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PagePartId).HasColumnType("int(11)");
            entity.Property(e => e.PagePname)
                .HasMaxLength(100)
                .HasColumnName("PagePName")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PartFaIcon)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PartId).HasColumnType("int(11)");
            entity.Property(e => e.PartName)
                .HasMaxLength(250)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.PartPname)
                .HasMaxLength(100)
                .HasColumnName("PartPName")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<IwWebsiteAlert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_alert")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwWebsiteInfoId, "fk_iw_website_alert_iw_website_info_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AlertContent)
                .HasMaxLength(255)
                .HasColumnName("alert_content");
            entity.Property(e => e.AlertName)
                .HasMaxLength(255)
                .HasColumnName("alert_name");
            entity.Property(e => e.AlertType)
                .HasMaxLength(255)
                .HasColumnName("alert_type");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.IdKey).HasMaxLength(11);
            entity.Property(e => e.IwWebsiteInfoId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_info_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");

            entity.HasOne(d => d.IwWebsiteInfo).WithMany(p => p.IwWebsiteAlerts)
                .HasForeignKey(d => d.IwWebsiteInfoId)
                .HasConstraintName("website");
        });

        modelBuilder.Entity<IwWebsiteBannerAdver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_banner_adver")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwWebsitePagesPartId, "fk_iw_banner_adver_iw_web_pages_part1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BottomCaption)
                .HasMaxLength(255)
                .HasColumnName("bottom_caption");
            entity.Property(e => e.BottomLink)
                .HasMaxLength(255)
                .HasColumnName("bottom_link");
            entity.Property(e => e.ConditionStatement)
                .HasColumnType("tinytext")
                .HasColumnName("condition_statement");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IdKey).HasMaxLength(11);
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IwWebsitePagesPartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_pages_part_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.MainColor)
                .HasMaxLength(45)
                .HasColumnName("main_color");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.SecondColor)
                .HasMaxLength(45)
                .HasColumnName("second_color");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.IwWebsitePagesPart).WithMany(p => p.IwWebsiteBannerAdvers)
                .HasForeignKey(d => d.IwWebsitePagesPartId)
                .HasConstraintName("fk_iw_banner_adver_iw_web_pages_part1");
        });

        modelBuilder.Entity<IwWebsiteInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_info")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("company");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.IdKey).HasMaxLength(11);
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.MainPhone)
                .HasMaxLength(255)
                .HasColumnName("main_phone");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.WebsiteAddress)
                .HasMaxLength(255)
                .HasColumnName("website_address");
            entity.Property(e => e.WebsiteName)
                .HasMaxLength(255)
                .HasColumnName("website_name");
            entity.Property(e => e.WebsiteTitle)
                .HasMaxLength(255)
                .HasColumnName("website_title");
        });

        modelBuilder.Entity<IwWebsiteLogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_logo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IwWebsitePagesId, "fk_iw_website_logo_iw_website_pages1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnType("tinytext");
            entity.Property(e => e.Icon).HasMaxLength(250);
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.IwWebsitePagesId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_pages_id");
            entity.Property(e => e.Line1).HasMaxLength(250);
            entity.Property(e => e.LinkTo).HasColumnType("tinytext");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");

            entity.HasOne(d => d.IwWebsitePages).WithMany(p => p.IwWebsiteLogos)
                .HasForeignKey(d => d.IwWebsitePagesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_website_logo_iw_website_pages1");
        });

        modelBuilder.Entity<IwWebsitePage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_pages")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwWebsiteInfoId, "fk_iw_web_pages_iw_website_info1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IdKey).HasMaxLength(11);
            entity.Property(e => e.IwWebsiteInfoId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_info_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.IwWebsiteInfo).WithMany(p => p.IwWebsitePages)
                .HasForeignKey(d => d.IwWebsiteInfoId)
                .HasConstraintName("fk_iw_web_pages_iw_website_info1");
        });

        modelBuilder.Entity<IwWebsitePagesPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_pages_part")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwWebsitePagesId, "fk_iw_web_pages_part_iw_web_pages1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.IdKey).HasMaxLength(11);
            entity.Property(e => e.IwWebsitePagesId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_pages_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.IwWebsitePages).WithMany(p => p.IwWebsitePagesParts)
                .HasForeignKey(d => d.IwWebsitePagesId)
                .HasConstraintName("fk_iw_web_pages_part_iw_web_pages1");
        });

        modelBuilder.Entity<IwWebsiteSpAdver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_sp_adver")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwWebsitePagesPartId, "fk_iw_website_sp_adver_iw_website_pages_part1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BottomCaption)
                .HasMaxLength(255)
                .HasColumnName("bottom_caption");
            entity.Property(e => e.BottomLink)
                .HasMaxLength(255)
                .HasColumnName("bottom_link");
            entity.Property(e => e.ConditionStatement)
                .HasColumnType("tinytext")
                .HasColumnName("condition_statement");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IwWebsitePagesPartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_website_pages_part_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.MainColor)
                .HasMaxLength(45)
                .HasColumnName("main_color");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.SecondColor)
                .HasMaxLength(45)
                .HasColumnName("second_color");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.IwWebsitePagesPart).WithMany(p => p.IwWebsiteSpAdvers)
                .HasForeignKey(d => d.IwWebsitePagesPartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_iw_website_sp_adver_iw_website_pages_part1");
        });

        modelBuilder.Entity<IwWebsiteTitleAdver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_website_title_adver")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IwWebPagesPartId, "fk_iw_banner_adver_iw_web_pages_part1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BottomCaption)
                .HasMaxLength(255)
                .HasColumnName("bottom_caption");
            entity.Property(e => e.BottomLink)
                .HasMaxLength(255)
                .HasColumnName("bottom_link");
            entity.Property(e => e.ConditionStatement)
                .HasColumnType("tinytext")
                .HasColumnName("condition_statement");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IwWebPagesPartId)
                .HasColumnType("int(11)")
                .HasColumnName("iw_web_pages_part_id");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.MainColor)
                .HasMaxLength(45)
                .HasColumnName("main_color");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
            entity.Property(e => e.SecondColor)
                .HasMaxLength(45)
                .HasColumnName("second_color");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<IwWeightCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("iw_weight_country")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Free)
                .HasColumnType("int(1)")
                .HasColumnName("free");
            entity.Property(e => e.Internal)
                .HasColumnType("int(1)")
                .HasColumnName("internal");
            entity.Property(e => e.IwCountryId1)
                .HasColumnType("int(11)")
                .HasColumnName("iw_country_id1");
            entity.Property(e => e.IwCountryId2)
                .HasColumnType("int(11)")
                .HasColumnName("iw_country_id2");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.ModifyId)
                .HasMaxLength(45)
                .HasColumnName("modify_id");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(45)
                .HasColumnName("modify_ip");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("prices")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ConversionId)
                .HasMaxLength(50)
                .HasColumnName("conversion_id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasColumnName("currency");
            entity.Property(e => e.IsMarkedDown).HasColumnName("is_marked_down");
            entity.Property(e => e.IsOutletPrice).HasColumnName("is_outlet_price");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.LowestPriceInLast30DaysEndDate)
                .HasColumnType("datetime")
                .HasColumnName("lowest_price_in_last_30_days_end_date");
            entity.Property(e => e.LowestPriceInLast30DaysPercentage)
                .HasPrecision(5, 2)
                .HasColumnName("lowest_price_in_last_30_days_percentage");
            entity.Property(e => e.LowestPriceInLast30DaysText)
                .HasMaxLength(20)
                .HasColumnName("lowest_price_in_last_30_days_text");
            entity.Property(e => e.LowestPriceInLast30DaysValue)
                .HasPrecision(10, 2)
                .HasColumnName("lowest_price_in_last_30_days_value");
            entity.Property(e => e.PreviousEndDate)
                .HasColumnType("datetime")
                .HasColumnName("previous_end_date");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.StartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("start_date_time");
            entity.Property(e => e.Text)
                .HasMaxLength(20)
                .HasColumnName("text");
            entity.Property(e => e.Value)
                .HasPrecision(10, 2)
                .HasColumnName("value");
            entity.Property(e => e.VersionId)
                .HasMaxLength(50)
                .HasColumnName("version_id");
            entity.Property(e => e.WasPriceStartDate)
                .HasColumnType("datetime")
                .HasColumnName("was_price_start_date");

            entity.HasOne(d => d.Product).WithMany(p => p.Prices)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("prices_ibfk_1");
        });

        modelBuilder.Entity<IwProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("products")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ProductTypeId, "product_type_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CountryOfManufacture)
                .HasMaxLength(50)
                .HasColumnName("country_of_manufacture");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.HasVariantsWithProp65Risk).HasColumnName("has_variants_with_prop65_risk");
            entity.Property(e => e.IsDeadProduct).HasColumnName("is_dead_product");
            entity.Property(e => e.IsInStock).HasColumnName("is_in_stock");
            entity.Property(e => e.IsNoSize).HasColumnName("is_no_size");
            entity.Property(e => e.IsOneSize).HasColumnName("is_one_size");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PdpLayout)
                .HasMaxLength(50)
                .HasColumnName("pdp_layout");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(20)
                .HasColumnName("product_code");
            entity.Property(e => e.ProductListId)
                .HasColumnType("int(11)")
                .HasColumnName("product_list_id");
            entity.Property(e => e.ProductTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("product_type_id");
            entity.Property(e => e.Rating)
                .HasColumnType("int(11)")
                .HasColumnName("rating");
            entity.Property(e => e.ShippingRestriction)
                .HasColumnType("text")
                .HasColumnName("shipping_restriction");
            entity.Property(e => e.SizeGuide)
                .HasColumnType("text")
                .HasColumnName("size_guide");
            entity.Property(e => e.SizeGuideApiUrl)
                .HasMaxLength(255)
                .HasColumnName("size_guide_api_url");

            //entity.HasOne(d => d.ProductType).WithMany(p => p.Products)
            //    .HasForeignKey(d => d.ProductTypeId)
            //    .HasConstraintName("products_ibfk_1");
        });

        modelBuilder.Entity<ProductList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("product_list")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("brand_name");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.Colour)
                .HasMaxLength(50)
                .HasColumnName("colour");
            entity.Property(e => e.ColourWayId)
                .HasColumnType("int(11)")
                .HasColumnName("colour_way_id");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasColumnName("currency");
            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("group_id");
            entity.Property(e => e.HasMultiplePrices).HasColumnName("has_multiple_prices");
            entity.Property(e => e.HasVariantColours).HasColumnName("has_variant_colours");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("image_url");
            entity.Property(e => e.IsMarkedDown).HasColumnName("is_marked_down");
            entity.Property(e => e.IsOutletPrice).HasColumnName("is_outlet_price");
            entity.Property(e => e.IsSellingFast).HasColumnName("is_selling_fast");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PriceCurrentText)
                .HasMaxLength(20)
                .HasColumnName("price_current_text");
            entity.Property(e => e.PriceCurrentValue)
                .HasPrecision(10, 2)
                .HasColumnName("price_current_value");
            entity.Property(e => e.PricePreviousText)
                .HasMaxLength(20)
                .HasColumnName("price_previous_text");
            entity.Property(e => e.PricePreviousValue)
                .HasPrecision(10, 2)
                .HasColumnName("price_previous_value");
            entity.Property(e => e.PriceRrpText)
                .HasMaxLength(20)
                .HasColumnName("price_rrp_text");
            entity.Property(e => e.PriceRrpValue)
                .HasPrecision(10, 2)
                .HasColumnName("price_rrp_value");
            entity.Property(e => e.ProductCode)
                .HasColumnType("int(11)")
                .HasColumnName("product_code");
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .HasColumnName("product_type");
            entity.Property(e => e.ShowVideo).HasColumnName("show_video");
            entity.Property(e => e.SponsoredCampaignId)
                .HasColumnType("int(11)")
                .HasColumnName("sponsored_campaign_id");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(255)
                .HasColumnName("video_url");
        });

        //modelBuilder.Entity<ProductType>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PRIMARY");

        //    entity
        //        .ToTable("product_types")
        //        .UseCollation("utf8mb4_general_ci");

        //    entity.Property(e => e.Id)
        //        .ValueGeneratedNever()
        //        .HasColumnType("int(11)")
        //        .HasColumnName("id");
        //    entity.Property(e => e.CreatedTime)
        //        .HasDefaultValueSql("current_timestamp()")
        //        .HasColumnType("timestamp")
        //        .HasColumnName("created_time");
        //    entity.Property(e => e.LastModify)
        //        .HasDefaultValueSql("current_timestamp()")
        //        .HasColumnType("timestamp")
        //        .HasColumnName("last_modify");
        //    entity.Property(e => e.Name)
        //        .HasMaxLength(50)
        //        .HasColumnName("name");
        //});

        modelBuilder.Entity<Variant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("variants")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BrandSize)
                .HasMaxLength(20)
                .HasColumnName("brand_size");
            entity.Property(e => e.ColourWayId)
                .HasColumnType("int(11)")
                .HasColumnName("colour_way_id");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_time");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasColumnName("currency");
            entity.Property(e => e.DisplaySizeText)
                .HasMaxLength(50)
                .HasColumnName("display_size_text");
            entity.Property(e => e.Ean)
                .HasMaxLength(20)
                .HasColumnName("ean");
            entity.Property(e => e.IsAvailable).HasColumnName("is_available");
            entity.Property(e => e.IsInStock).HasColumnName("is_in_stock");
            entity.Property(e => e.IsLowInStock).HasColumnName("is_low_in_stock");
            entity.Property(e => e.IsPrimary).HasColumnName("is_primary");
            entity.Property(e => e.IsProp65Risk).HasColumnName("is_prop65_risk");
            entity.Property(e => e.LastModify)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("last_modify");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PriceCurrentText)
                .HasMaxLength(20)
                .HasColumnName("price_current_text");
            entity.Property(e => e.PriceCurrentValue)
                .HasPrecision(10, 2)
                .HasColumnName("price_current_value");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Seller)
                .HasMaxLength(255)
                .HasColumnName("seller");
            entity.Property(e => e.SizeDescription)
                .HasMaxLength(20)
                .HasColumnName("size_description");
            entity.Property(e => e.SizeId)
                .HasColumnType("int(11)")
                .HasColumnName("size_id");
            entity.Property(e => e.SizeOrder)
                .HasColumnType("int(11)")
                .HasColumnName("size_order");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("sku");

            entity.HasOne(d => d.Product).WithMany(p => p.Variants)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("variants_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
