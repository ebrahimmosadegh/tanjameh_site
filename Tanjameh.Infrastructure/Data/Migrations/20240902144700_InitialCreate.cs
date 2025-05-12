using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tanjameh.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Link = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TextLink = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MainColor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecondaryColor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BannerInfo = table.Column<string>(type: "json", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    BaseUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CatalogBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(900)", maxLength: 900, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoFileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HomeUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OgType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogBrands", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "varchar(110)", maxLength: 110, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    GenderTypeId = table.Column<int>(type: "int", nullable: true),
                    MainPictureFileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasPreviewPicture = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoryApis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "varchar(110)", maxLength: 110, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    GenderTypeId = table.Column<int>(type: "int", nullable: true),
                    MainPictureFileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasPreviewPicture = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ApiId = table.Column<long>(type: "bigint", nullable: true),
                    ApiName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullPath = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryApis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryApis_CategoryApis_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "CategoryApis",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CultureName = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CurrencyCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrencyName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrencySign = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomStringFormat = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultCultureName = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModify = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MediaFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MediaFolder = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alt = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Extension = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MediaType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Width = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Hidden = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsThumbnial = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFiles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WeightId = table.Column<int>(type: "int", nullable: true),
                    ApiId = table.Column<long>(type: "bigint", nullable: true),
                    Slug = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RawProductData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApiProductId = table.Column<long>(type: "bigint", nullable: true),
                    RawDetailData = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RawListData = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiCategoryIds = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawProductData", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WeightSource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Weight = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightSource", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CatalogBrandApi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModify = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ApiId = table.Column<long>(type: "bigint", nullable: true),
                    ApiName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CatalogBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogBrandApi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogBrandApi_CatalogBrands_CatalogBrandId",
                        column: x => x.CatalogBrandId,
                        principalTable: "CatalogBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SiteCategoryToApis",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SiteCategoryId = table.Column<int>(type: "int", nullable: false),
                    ApiCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteCategoryToApis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteCategoryToApis_Categories_SiteCategoryId",
                        column: x => x.SiteCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteCategoryToApis_CategoryApis_ApiCategoryId",
                        column: x => x.ApiCategoryId,
                        principalTable: "CategoryApis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CurrencyConversions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FromCurrencyId = table.Column<int>(type: "int", nullable: false),
                    ToCurrencyId = table.Column<int>(type: "int", nullable: false),
                    ExchangeRate = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Notes = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyConversions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyConversions_Currencies_FromCurrencyId",
                        column: x => x.FromCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrencyConversions_Currencies_ToCurrencyId",
                        column: x => x.ToCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CurrencyCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyCountry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyCountry_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrencyCountry_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDefault = table.Column<bool>(type: "tinyint(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModify = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModify = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullDescription = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShortDescription = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: true),
                    CustomePriceKey = table.Column<long>(type: "bigint", nullable: true),
                    PriceCurrencyId = table.Column<int>(type: "int", nullable: true),
                    MainPictureFileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasPreviewPicture = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InSale = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GenderTypeId = table.Column<int>(type: "int", nullable: true),
                    CatalogBrandId = table.Column<int>(type: "int", nullable: true),
                    Visibility = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ApiId = table.Column<long>(type: "bigint", nullable: true),
                    Exist = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hidden = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    WeightId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CatalogBrands_CatalogBrandId",
                        column: x => x.CatalogBrandId,
                        principalTable: "CatalogBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Currencies_PriceCurrencyId",
                        column: x => x.PriceCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductWeightPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeightId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    NormalPrice = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false),
                    ExtraPrice = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWeightPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductWeightPrice_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductWeightPrice_WeightSource_WeightId",
                        column: x => x.WeightId,
                        principalTable: "WeightSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductVariantId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_CustomerOrders_CustomerOrderId",
                        column: x => x.CustomerOrderId,
                        principalTable: "CustomerOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerOrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    TransactionId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModify = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_CustomerOrders_CustomerOrderId",
                        column: x => x.CustomerOrderId,
                        principalTable: "CustomerOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShippingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerOrderId = table.Column<int>(type: "int", nullable: false),
                    ShippingMethod = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrackingNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EstimatedDeliveryDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ShippingAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingCity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingCountry = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingZipCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingInfo_CustomerOrders_CustomerOrderId",
                        column: x => x.CustomerOrderId,
                        principalTable: "CustomerOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductMediaFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MediaFileId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ProductVarientId = table.Column<int>(type: "int", nullable: false),
                    TypeHelp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMediaFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMediaFile_MediaFiles_MediaFileId",
                        column: x => x.MediaFileId,
                        principalTable: "MediaFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductMediaFile_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductProductTag",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTagId = table.Column<int>(type: "int", nullable: false),
                    ApiId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductTag", x => new { x.ProductId, x.ProductTagId });
                    table.ForeignKey(
                        name: "FK_ProductProductTag_ProductTags_ProductTagId",
                        column: x => x.ProductTagId,
                        principalTable: "ProductTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductTag_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AllowFiltering = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ShowOnProductPage = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpecifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    BrandSize = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SizeDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplaySizeText = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SizeOrder = table.Column<int>(type: "int", nullable: true),
                    Sku = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsLowInStock = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsInStock = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Colour = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColourWayId = table.Column<int>(type: "int", nullable: true),
                    PriceCurrentValue = table.Column<decimal>(type: "decimal(20,4)", precision: 20, scale: 4, nullable: true),
                    PriceCurrentText = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Currency = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPrimary = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsProp65Risk = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Ean = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seller = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GenderTypeId = table.Column<int>(type: "int", nullable: true),
                    ApiId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CatalogBrands",
                columns: new[] { "Id", "ApiId", "CreatedOnUtc", "Description", "HomeUrl", "LogoFileName", "LogoUrl", "Name", "OgType", "Slug", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { 1, 14644L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8270), "Inspired by beaches, blue skies and sunshine, Southern California label <strong>Hollister</strong> champions an endless summer. Never taking itself too seriously, its laid-back style is infused ", null, "", null, "Hollister", null, "hollister", null },
                    { 2, 53L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8278), "This is <strong>ASOS DESIGN</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is her", null, "", null, "ASOS DESIGN", null, "asos-design", null },
                    { 3, 3682L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8281), "The youngest child of the Carhartt family, <strong>Carhartt WIP</strong> launched in London in 1989 with fresh ideas. Paying homage to its workwear roots, the brand serves utility designs with a s", null, "", null, "Carhartt WIP", null, "carhartt-wip", null },
                    { 4, 2986L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8284), "Key players in everything activewear-related, it doesn’t get more iconic than <strong>Nike</strong>. Sporting some of the most wanted trainers in the game, browse Air Max 90s and Air Force 1s, as ", null, "", null, "Nike", null, "nike", null },
                    { 5, 12983L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8286), "High-street favourite <strong>River Island</strong> has been a go-to for decades. Known for adding signature detailing to its designs, expect to see classic looks with an RI twist from our ... ", null, "", null, "River Island", null, "river-island", null },
                    { 6, 14920L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8289), "<strong>Sixth June</strong> launched in Paris in 2008, breathing fresh air into street style. With its innovative and reactive approach, its longline tees, bomber jackets and sweats have helped", null, "", null, "Sixth June", null, "sixth-june", null },
                    { 7, 16522L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8292), "", null, "", null, "Gramicci", null, "gramicci", null },
                    { 8, 12461L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8295), "Founded in the 90s as a jeanswear brand, Danish label <strong>Jack & Jones</strong> has since gone on to expand its sartorial offering to include everything from jumpers, jackets and T-shirts to", null, "", null, "Jack & Jones", null, "jack-&-jones", null },
                    { 9, 401L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8298), "Since creating the first ever pair of blue jeans back in 1873, American label <strong>Levi's</strong> has gone on to become one of the world’s most iconic denim brands – but you already knew that", null, "", null, "Levi's", null, "levi's", null },
                    { 10, 14370L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8327), "The modern <strong>Abercrombie & Fitch</strong> is the next generation of effortless all-American style. The essence of laidback sophistication with an element of simplicity, A&F sets th", null, "", null, "Abercrombie & Fitch", null, "abercrombie-&-fitch", null },
                    { 11, 3253L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8331), "With over 90 years of manufacturing experience, <strong>Dickies</strong> traces its reputation for durability and performance back to its workwear roots. Rounding up a selection of everyday stap", null, "", null, "Dickies", null, "dickies", null },
                    { 12, 3312L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8333), "Born from two hikers’ love for adventure, <strong>The North Face</strong> has become one of the best-known brands for outdoor clothing and equipment. Look to our ... ", null, "", null, "The North Face", null, "the-north-face", null },
                    { 13, 18L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8336), "<strong>adidas Originals</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ", null, "", null, "adidas Originals", null, "adidas-originals", null },
                    { 14, 12769L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8338), "If your aesthetic is part on-trend, part throwback vibes, then you’ll love <strong>Reclaimed Vintage</strong>. With two distinct collections, ... ", null, "", null, "Reclaimed Vintage", null, "reclaimed-vintage", null },
                    { 15, 14441L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8345), "Bringing you classic menswear with a twist, <strong>ONLY & SONS</strong> is all about elevating your fav’ everyday pieces. Serve some serious laidback looks with fresh white T-shirts and graph", null, "", null, "ONLY & SONS", null, "only-&-sons", null },
                    { 16, 14403L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8350), "", null, "", null, "Element", null, "element", null },
                    { 17, 2943L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8352), "Founded by triple Wimbledon champion <strong>Fred Perry</strong> in 1952, the eponymous clothing brand blends classic British street style with an athletic twist. Our ... ", null, "", null, "Fred Perry", null, "fred-perry", null },
                    { 18, 75L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8354), "Adopted by the Mod movement of the 1960s, <strong>Ben Sherman</strong> channel their Mod roots to a contemporary range of menswear, including everything from their iconic check shirts to polos ", null, "", null, "Ben Sherman", null, "ben-sherman", null },
                    { 19, 14159L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8355), "A staple wardrobe doesn’t have to be basic, so upgrade your everyday edit with <strong>Selected Homme</strong>. Embracing a minimalist aesthetic, the brand puts a Scandi twist on contemporary s", null, "", null, "Selected Homme", null, "selected-homme", null },
                    { 20, 16545L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8357), "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now", null, "", null, "Nike Golf", null, "nike-golf", null },
                    { 21, 15176L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8360), "Key players in everything activewear-related, it doesn’t get more iconic than Nike. Sporting some of the most wanted trainers in the game, browse Air Max 90s and Air Force 1s, as well as Cortez and Joyride styles. Get off-duty looks down with tracksuits", null, "", null, "Nike Running", null, "nike-running", null },
                    { 22, 16123L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8362), "Founded in 1974 in Shoeburyness (yes, it&rsquo;s a real place), England, innovative brand <strong>Hi-Tec</strong> set out to build a comfortable squash shoe with a lightweight feel. From there, Hi-T", null, "", null, "Hi-Tec", null, "hi-tec", null },
                    { 23, 3497L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8364), "From their birth in the 1920s, <strong>Farah</strong> has been adopted by subcultures across the board; from Mods to Skins and Rockabillies. Renowned for their classic canvas slacks and sharp", null, "", null, "Farah", null, "farah", null },
                    { 24, 15127L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8366), "First thought up in the shadow of Europe’s highest peak, the Monte Bianco, outdoors-loving brand <strong>Napapijri</strong> has been combining innovative materials with close attention to st", null, "", null, "Napapijri", null, "napapijri", null },
                    { 25, 12791L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8367), "East London born and bred, <strong>AllSaints</strong> turned heads in the mid-90s with its investment leather jackets. Today, a collection of worn-in denim, vintage-inspired shirts and classic j", null, "", null, "AllSaints", null, "allsaints", null },
                    { 26, 3029L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8369), "Whether it’s an embroidered logo, a bold graphic print or its iconic red, white and blue colour-blocking, there’s no mistaking <strong>Tommy Hilfiger</strong>. Flying the flag for all th", null, "", null, "Tommy Hilfiger", null, "tommy-hilfiger", null },
                    { 27, 14758L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8370), "For a low-effort, high-reward wardrobe, check out clothing brand <strong>ADPT</strong>. We’re talking new levels of casj excellence with washed-out T-shirts, brushed shirts and teddy sweatshirts. T", null, "", null, "ADPT", null, "adpt", null },
                    { 28, 15370L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8372), "Taking inspiration from the latest music, technology and social media trends, <strong>Bershka</strong> serves up fresh new fashion and wardrobe staples you’ll want to rotate on the regular. We", null, "", null, "Bershka", null, "bershka", null },
                    { 29, 14512L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8373), "", null, "", null, "Le Breve", null, "le-breve", null },
                    { 30, 12136L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8375), "One of the most iconic names in fashion history, Giorgio Armani launched <strong>Armani Exchange</strong> in 1991 as a youthful, sportier sub-label of his eponymous brand. Inspired by the l", null, "", null, "Armani Exchange", null, "armani-exchange", null },
                    { 31, 16236L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8377), "Welcome to the new chapter of <strong>Topman</strong>. Championing the very best of its heritage, this next phase celebrates cherished pieces, while embracing the new, and retaining that unique Lon", null, "", null, "Topman", null, "topman", null },
                    { 32, 691L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8379), "<strong>Superdry</strong> merges Japanese-inspired graphics with vintage Americana styling. The result? Expect quality fabrics, hand-drawn prints and tailored fits to slot into your everyday line-", null, "", null, "Superdry", null, "superdry", null },
                    { 33, 14126L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8381), "Champions of the casual capsule wardrobe, make <strong>Pull&Bear</strong> your new must-scroll brand. With a focus on laid-back Californian style, the brand mixes grunge, sports and streetwear re", null, "", null, "Pull&Bear", null, "pull&bear", null },
                    { 34, 15878L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8382), "A new brand for the coming-of-age generation that refuses to compromise on principle or style, <strong>Collusion</strong> believes clothes that celebrate self-expression and inclusivity should", null, "", null, "Collusion", null, "collusion", null },
                    { 35, 12077L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8384), "BOSS offers an authentic and understated wardrobe for the modern man. Crafted from super-soft fabrics, BOSS bodywear, loungewear and accessory collections offer ultimate comfort and enduring style.", null, "", null, "BOSS by Hugo Boss", null, "boss-by-hugo-boss", null },
                    { 36, 14712L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8386), "Combining fine Italian style and craftsmanship with modern British design, footwear brand <strong>WALK LONDON</strong> takes its inspiration from its local surroundings and London’s culture.", null, "", null, "WALK LONDON", null, "walk-london", null },
                    { 37, 14550L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8387), "Founded in 1984 with the motto, “Strap in and go,” footwear brand <strong>Teva</strong> offers an iconic selection of hard-wearing designs. Inspired by an active lifestyle, their collection of hi", null, "", null, "Teva", null, "teva", null },
                    { 38, 14287L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8389), "With Scandi roots and a street-style vibe, <strong>Weekday</strong> offers up that coveted laid-back, minimal look. Founded in 2002, the Swedish brand draws inspiration from art, pop and youth c", null, "", null, "Weekday", null, "weekday", null },
                    { 39, 3062L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8390), "Originally a cowboy jean, <strong>Wrangler</strong> grew to be one of the defining American denim brands. Today, ... ", null, "", null, "Wrangler", null, "wrangler", null },
                    { 40, 79L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8392), "It’s not all about new – sometimes you can’t beat a classic, and <strong>Birkenstock</strong> is exactly that. Starting out way back in 1774, the footwear brand soon became known for its", null, "", null, "Birkenstock", null, "birkenstock", null },
                    { 41, 396L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8393), "Founded in 1889 by Henry David Lee, <strong>Lee</strong> are a denim brand that utilise their rich history to make jeans and workwear inspired clothing with an authentic edge. ... ", null, "", null, "Lee", null, "lee", null },
                    { 42, 14468L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8395), "The designers behind <strong>Nicce</strong> look to the streets of London for inspiration, and with its diverse culture and rich music scene, it’s not hard to see why. Expect T-shirts and h", null, "", null, "Nicce", null, "nicce", null },
                    { 43, 20903L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8396), "", null, "", null, "Sol de Janeiro", null, "sol-de-janeiro", null },
                    { 44, 15829L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8398), "", null, "", null, "Isle of Paradise", null, "isle-of-paradise", null },
                    { 45, 16511L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8399), "", null, "", null, "Rituals", null, "rituals", null },
                    { 46, 14535L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8401), "Make your top drawer your favourite drawer with our <strong>Ann Summers</strong> at ASOS edit. All about embracing self-confidence, the brand knows how to celebrate self-love. Treat yourself", null, "", null, "Ann Summers", null, "ann-summers", null },
                    { 47, 22555L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8402), "", null, "", null, "Weleda", null, "weleda", null },
                    { 48, 22705L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8404), "", null, "", null, "Erborian", null, "erborian", null },
                    { 49, 17600L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8406), "Get ready for streak-free bronzed skin with fake-tan favourite <strong>Tanologist</strong>, created by makeup artist and beauty influencer Lottie Tomlinson. Whether you’re looking", null, "", null, "Tanologist", null, "tanologist", null },
                    { 50, 3234L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8408), "Hoxton-founded <strong>Bolongaro Trevor</strong> takes its sartorial cues from British subcultures like the mods, skins and punks. Designed in East London, the brand’s retro leather jack", null, "", null, "Bolongaro Trevor", null, "bolongaro-trevor", null },
                    { 51, 17700L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8410), "If you need an excuse for a wardrobe update,&nbsp;<strong>HUGO BOSS Fragrances</strong>&nbsp;is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it co", null, "", null, "HUGO BOSS Fragrances", null, "hugo-boss-fragrances", null },
                    { 52, 19157L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8411), "", null, "", null, "MAEGAN", null, "maegan", null },
                    { 53, 14096L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8437), "Founded in 2001, US streetwear label <strong>Obey</strong> is an extension of graffiti artist Shepard Fairey’s street and fine art campaign. Moving his populist views from the canvas to clothing, F", null, "", null, "Obey", null, "obey", null },
                    { 54, 18150L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8439), "", null, "", null, "Nuxe", null, "nuxe", null },
                    { 55, 12577L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8441), "Created in Bordeaux in 1995, <strong>Caudalie</strong> recycles the grape seed oil usually thrown away during harvesting to produce an effective and luxurious beauty range – pretty ", null, "", null, "Caudalie", null, "caudalie", null },
                    { 56, 20703L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8442), "", null, "", null, "Billie Eilish", null, "billie-eilish", null },
                    { 57, 224L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8443), "Founded in 1972 by Stephen Marks and driven by innovation, <strong>French Connection</strong> is known for its wearable, intelligent collections and off-beat advertising campaigns. French", null, "", null, "French Connection", null, "french-connection", null },
                    { 58, 16651L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8445), "", null, "", null, "Threadbare Fitness", null, "threadbare-fitness", null },
                    { 59, 13289L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8447), "British watch brand <strong>Sekonda</strong> was launched in 1966 and now offers an expansive collection of innovative designs. ... ", null, "", null, "Sekonda", null, "sekonda", null },
                    { 60, 12962L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8448), "In 2009 Anton Janssens and Raf Maes launched <strong>Komono</strong> which means 'small things' in Japanese. However, ... ", null, "", null, "Komono", null, "komono", null },
                    { 61, 18054L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8450), "", null, "", null, "Valentino Bags", null, "valentino-bags", null },
                    { 62, 15883L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8451), "If classic street style with a touch of tailoring is your thing, then it&rsquo;s time to get excited because that&rsquo;s exactly what Swedish brand <strong>NA-KD's</strong> all about. Pad out your", null, "", null, "NA-KD", null, "na-kd", null },
                    { 63, 15586L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8453), "Celebrating women of all shapes and sizes, <strong>Simply Be</strong> makes a serious case for plus-size style. Inspired by international trends, the brand’s latest offering includes everyth", null, "", null, "Simply Be", null, "simply-be", null },
                    { 64, 13817L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8454), "Since setting up shop in the 60s, <strong>New Look</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ", null, "", null, "New Look", null, "new-look", null },
                    { 65, 14538L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8455), "", null, "", null, "Threadbare", null, "threadbare", null },
                    { 66, 13116L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8457), "Serving up femininity with a vintage twist, <strong>sister jane</strong> perfects your 9-9 style with its pretty blouses and tailored separates. Embroidered Peter-Pan collars, delicate pleat", null, "", null, "sister jane", null, "sister-jane", null },
                    { 67, 15812L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8458), "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda Curve</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety o", null, "", null, "Vero Moda Curve", null, "vero-moda-curve", null },
                    { 68, 3663L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8460), "Seeking inspiration from street and city style, Scandi favourite <strong>Vila</strong> combines quality fabrics and delicate cuts to create a collection of fashion-forward pieces. Signature floral p", null, "", null, "Vila", null, "vila", null },
                    { 69, 15629L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8462), "Barcelona-born clothing brand <strong>Stradivarius</strong> moves to its own beat. With an eye for minimalism and trend-led detail, expect classic silhouettes and a neutral colour palette (", null, "", null, "Stradivarius", null, "stradivarius", null },
                    { 70, 15128L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8464), "<strong>Miss Selfridge</strong> takes you from day to date night with its off-duty looks and full-on glamour. Solve what-to-wear dilemmas with its dresses and accessories that combine inh", null, "", null, "Miss Selfridge", null, "miss-selfridge", null },
                    { 71, 14516L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8465), "Inspired by minimalist design, contemporary denim brand <strong>Waven</strong> focuses on clean lines and relaxed silhouettes. Channeling two generations of denim manufacturing know-how into its p", null, "", null, "Waven", null, "waven", null },
                    { 72, 3180L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8467), "Docs, Doc Martens, DMs – we’ve all got our own name for them, but one thing’s for sure: <strong>Dr Martens</strong> kicks against the norm. The British footwear brand’s shoes, boots and ", null, "", null, "Dr Martens", null, "dr-martens", null },
                    { 73, 3672L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8468), "With a rich New England heritage, <strong>Timberland</strong> signature work boots were quickly adopted by a new wave of youth culture. With a rugged feel and reputation for quality, ... ", null, "", null, "Timberland", null, "timberland", null },
                    { 74, 16346L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8469), "<strong>adidas performance</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ", null, "", null, "adidas performance", null, "adidas-performance", null },
                    { 75, 12967L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8471), "Inspired by seasonal trends, Canadian footwear and accessory brand <strong>ALDO</strong> looks to the runways for inspiration when designing its collections. We’ve pulled together an edit of its ", null, "", null, "ALDO", null, "aldo", null },
                    { 76, 765L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8472), "ABOUT VANS Land more than just tricks with skatewear label <strong>Vans</strong>. Rewriting the blueprint for board shoes everywhere since 1966, the brand’s remit has expanded to include everything ", null, "", null, "Vans", null, "vans", null },
                    { 77, 14991L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8474), "Labelled Australia’s favourite tan, <strong>Bondi Sands</strong> is quickly becoming a firm favourite among fake-tan fans. Formulated with skin-nourishing ingredients including Jojo", null, "", null, "Bondi Sands", null, "bondi-sands", null },
                    { 78, 16246L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8475), "Faking it not your thing? Enter Australian-made brand <strong>The Fox Tan</strong>. Enriched with an exclusive ingredient, its mists, sprays and sealers help encourage the producti", null, "", null, "The Fox Tan", null, "the-fox-tan", null },
                    { 79, 20602L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8477), "Say hello to shade-stopping style with our <strong>Aire</strong> at ASOS edit. Featuring a range of on-trend designs, Australian label ... ", null, "", null, "Aire", null, "aire", null },
                    { 80, 597L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8478), "Naming his brand after a sport that embodied a world of classic style, Ralph Lauren created <strong>Ralph Lauren</strong> in 1967 with a line of men's ties. Fast forward and the label is ", null, "", null, "Ralph Lauren", null, "ralph-lauren", null },
                    { 81, 16305L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8479), "<strong>Topshop</strong> is entering a new era. Retaining its fashion authority and the very best of its heritage, while celebrating iconic styles such as the Jamie and Joni jean, and embracing ", null, "", null, "Topshop", null, "topshop", null },
                    { 82, 62200L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8481), "", null, "", null, "Hello Sunday", null, "hello-sunday", null },
                    { 83, 544L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8482), "Famed for his “classics with a twist” mantra, <strong>Paul Smith</strong> has been at the forefront of the menswear scene for over thirty years. This season sees the designer channelli", null, "", null, "Paul Smith", null, "paul-smith", null },
                    { 84, 15034L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8484), "Make wardrobe dilemmas a thing of the past thanks to clothing brand <strong>Yours</strong>. With staple separates that work all day (and night) and comfy co-ords to chill in, the brand’s plus-si", null, "", null, "Yours", null, "yours", null },
                    { 85, 105L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8485), "Underwear authority and all-round fashion icon, <strong>Calvin Klein</strong> puts a designer stamp on clean, casual-cool staples. From shirts to waistbands, the brand’s famous CK logo serve", null, "", null, "Calvin Klein", null, "calvin-klein", null },
                    { 86, 12727L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8487), "Sun’s out, shades on. Australian sunglasses brand <strong>Le Specs</strong> has been serving strong eyewear looks since 1979. With frames to suit all moods, consider your ultimate summer add-", null, "", null, "Le Specs", null, "le-specs", null },
                    { 87, 3128L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8489), "First produced for the U.S. Air Force, <strong>Ray-Ban</strong> has been making iconic sunglasses since 1937. With a rich pop culture history, ... ", null, "", null, "Ray-Ban", null, "ray-ban", null },
                    { 88, 15203L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8490), "Empowering athletes through passion, design and the relentless pursuit of innovation, <strong>Under Armour</strong> creates sports clothing and footwear to help you deliver your best performa", null, "", null, "Under Armour", null, "under-armour", null },
                    { 89, 767L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8492), "With added Donatella, Italian fashion house Versace adds a line of luxury accessories to its signature feminine style and OTT glamour. Think cat-eye and oversized sunglasses, handbags and jewellery all stamped with the label’s iconic Medusa logo, animal", null, "", null, "Versace", null, "versace", null },
                    { 90, 439L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8500), "<strong>Magic</strong> creates a range of underwear solutions designed to enhance and maximise your figure underneath clothing. Bra strap converters, stick on push up pads and fashion t", null, "", null, "Magic", null, "magic", null },
                    { 91, 13137L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8502), "Combining timeless silhouettes with standout embellishments, <strong>True Decadence</strong> have been mastering occasionwear since 2016. The brand's eye-catching array of tiered maxi dre", null, "", null, "True Decadence", null, "true-decadence", null },
                    { 92, 3594L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8505), "Known for its collegiate-cool American style, heritage brand <strong>Polo Ralph Lauren</strong> is a big player in the menswear game. Sample some of its signature preppy designs with our ", null, "", null, "Polo Ralph Lauren", null, "polo-ralph-lauren", null },
                    { 93, 499L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8506), "Founded over 100 years ago, <strong>New Balance</strong> (aka the dad-trainer OG) has been flexing its footwear credentials for as long as we can remember. Shop the ... ", null, "", null, "New Balance", null, "new-balance", null },
                    { 94, 12069L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8509), "When it comes to shirts, <strong>Gant</strong> knows its stuff. Founded as a shirtmakers back in 1949, the brand went on to shape the iconic Ivy League style embraced by 50s Harvard, Yale and Princet", null, "", null, "Gant", null, "gant", null },
                    { 95, 14116L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8511), "From Italian ski and tennis apparel to iconic 80s sports fashion, <strong>ellesse</strong> proves that sportswear isn’t just for getting physical. The brand nails that retro athleisure aesthetic", null, "", null, "ellesse", null, "ellesse", null },
                    { 96, 13872L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8535), "Designed in London, UK, <strong>PS Paul Smith</strong> bears all the hallmarks of Sir Paul Smith’s individual and quintessentially British style. Signature details feature across a rang", null, "", null, "PS Paul Smith", null, "ps-paul-smith", null },
                    { 97, 15622L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8537), "Started in 2009 by a group of friends at a Florida skate camp, LA-based label <strong>Rip N Dip</strong> combines skate apparel with classic streetwear. Known for its eccentric designs, includin", null, "", null, "Rip N Dip", null, "rip-n-dip", null },
                    { 98, 2988L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8539), "Since 1895, <strong>Reebok's</strong> ancestor company have been developing their line of running shoes and trainers. With the brand launched in its own right in 1958, ... ", null, "", null, "Reebok", null, "reebok", null },
                    { 99, 16674L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8542), "", null, "", null, "Don't Think Twice", null, "don't-think-twice", null },
                    { 100, 3060L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8543), "A diffusion line from iconic fashion house Armani, <strong>Emporio Armani</strong> offers timeless style with their collections of wearable classics. ... ", null, "", null, "Emporio Armani", null, "emporio-armani", null },
                    { 101, 16119L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8545), "With design ateliers in Paris, Stockholm and Los Angeles, <strong>& Other Stories</strong> collections are as varied and creative as the locations they take inspiration from. Find staple j", null, "", null, "& Other Stories", null, "&-other-stories", null },
                    { 102, 14483L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8546), "Prom dress stresses and wedding attire worries? Check out <strong>True Violet</strong> collection and get schooled on all-occasionwear. We’re talking hand-painted floral prints and embelli", null, "", null, "True Violet", null, "true-violet", null },
                    { 103, 16485L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8548), "<strong>Jaded Rose Tall</strong> launches their first collection exclusively on ASOS (we’re super happy about that btw!). Calling on the catwalk, ... ", null, "", null, "Jaded Rose Tall", null, "jaded-rose-tall", null },
                    { 104, 13511L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8550), "This is <strong>ASOS Curve</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is he", null, "", null, "ASOS Curve", null, "asos-curve", null },
                    { 105, 12542L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8551), "Founded in 1973, Monsoon brought hand-crafted and folk-inspired global fashion to London with their first stall on the Portobello Road. Developing an accessories line to sit alongside this collection saw the introduction of ... ", null, "", null, "Accessorize", null, "accessorize", null },
                    { 106, 15719L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8553), "Turn up and stand out in occasionwear that’s as unique as you. With luxe attention to detail, <strong>ASOS EDITION</strong> is designed for the most memorable moments of your life. Think ", null, "", null, "ASOS EDITION", null, "asos-edition", null },
                    { 107, 14146L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8555), "Designing fashion accessories with an edge, the squad behind <strong>Skinnydip</strong> standout range knows gals just want to have fun. Influenced by the world around us, the brand creates ev", null, "", null, "Skinnydip", null, "skinnydip", null },
                    { 108, 14162L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8556), "This is <strong>ASOS Tall</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is her", null, "", null, "ASOS Tall", null, "asos-tall", null },
                    { 109, 14450L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8558), "Family-owned label <strong>Jeffrey Campbell</strong> puts its stamp on vintage inspirations and catwalk trends with a standout footwear collection. Dressing up your walk from the street", null, "", null, "Jeffrey Campbell", null, "jeffrey-campbell", null },
                    { 110, 13661L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8559), "A diffusion line of Franco Moschino's iconic Italian design house, <strong>Love Moschino</strong> creates a playful and irreverent collection injected with a sense of youthful cool. Witty ", null, "", null, "Love Moschino", null, "love-moschino", null },
                    { 111, 13862L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8561), "Hot new label <strong>Vesper</strong> gives you a serious fashion fix with their collection of figure sculpting dresses. Cut from luxe, super stretch fabrics, each dress is designed to flatter an", null, "", null, "Vesper", null, "vesper", null },
                    { 112, 14012L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8562), "If you’re all for personality and expression, then <strong>Monki</strong>  is the brand for you. Known for its street-meets-Scandi-chic designs, it grabs bold, bright colours and a whole lot of ", null, "", null, "Monki", null, "monki", null },
                    { 113, 15068L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8564), "", null, "", null, "River Island Plus", null, "river-island-plus", null },
                    { 114, 15177L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8565), "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now", null, "", null, "Nike Training", null, "nike-training", null },
                    { 115, 13850L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8567), "Looking for trending pieces that will get you noticed? Enter: <strong>ONLY</strong>. The brand delivers the freshest selection of printed mini dresses and blouses for every plan in your calendar. B", null, "", null, "ONLY", null, "only", null },
                    { 116, 14599L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8568), "In 1971, French label <strong>Pimkie</strong> brought three textiles specialists together to create empowering collections that encourage women to express themselves, and the rest is fashion hist", null, "", null, "Pimkie", null, "pimkie", null },
                    { 117, 14185L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8571), "<strong>Jaded Rose</strong> launches their first collection exclusively on ASOS (we’re super happy about that btw!). Calling on the catwalk, ... ", null, "", null, "Jaded Rose", null, "jaded-rose", null },
                    { 118, 15734L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8579), "Give your wardrobe that extra something-something with the latest drop from <strong>Wednesday's Girl</strong>. Big on floral and ditsy prints, the brand helps bring your daytime thing to", null, "", null, "Wednesday's Girl", null, "wednesday's-girl", null },
                    { 119, 12117L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8580), "The designers behind Barcelona-born <strong>Mango</strong> know that pairing timeless style with minimalist design is a winning formula. We’ve handpicked our fave pieces from its dreamy collectio", null, "", null, "Mango", null, "mango", null },
                    { 120, 16483L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8582), "<strong>Jaded Rose Petite</strong> launches their first collection exclusively on ASOS (we’re super happy about that btw!). Calling on the catwalk, ... ", null, "", null, "Jaded Rose Petite", null, "jaded-rose-petite", null },
                    { 121, 14023L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8583), "If you like your trends as fast as they come then <strong>Daisy Street</strong> is the label for you. Always up on their A-game, ... ", null, "", null, "Daisy Street", null, "daisy-street", null },
                    { 122, 96L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8585), "Be your own icon in a statement pair of shoes from the <strong>Bronx</strong> at ASOS range. Experimenting with out-there styles – think snakeskin prints, gleaming hardware and cut-out designs ", null, "", null, "Bronx", null, "bronx", null },
                    { 123, 13138L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8586), "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous</strong>, where individual style is the key.  The carefully source", null, "", null, "Glamorous", null, "glamorous", null },
                    { 124, 16633L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8588), "Be your own influencer with fashion brand <strong>Missyempire</strong>. From the social feed straight to your wardrobe, the label taps into the latest trends with its range of clothes and ac", null, "", null, "Missyempire", null, "missyempire", null },
                    { 125, 21166L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8589), "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous Wide Fit</strong>, where individual style is the key.  The careful", null, "", null, "Glamorous Wide Fit", null, "glamorous-wide-fit", null },
                    { 126, 15778L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8591), "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous Wide Fit</strong>, where individual style is the key.  The careful", null, "", null, "Glamorous Wide Fit", null, "glamorous-wide-fit", null },
                    { 127, 16344L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8592), "", null, "", null, "Il Sarto", null, "il-sarto", null },
                    { 128, 15735L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8594), "Based in downtown Los Angeles, new kid on the block <strong>Emory Park</strong> has that effortlessly cool thing well and truly nailed down. Mixing vintage checks and ditsy prints with matchy", null, "", null, "Emory Park", null, "emory-park", null },
                    { 129, 3040L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8595), "With its Scandinavian roots and minimalist styling, <strong>Pieces</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand ties you", null, "", null, "Pieces", null, "pieces", null },
                    { 130, 15720L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8597), "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now", null, "", null, "Nike Football", null, "nike-football", null },
                    { 131, 14958L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8598), "Comfort and style? That's no sweat with <strong>Gym King</strong> jersey tees, vests and tracksuits. Influenced by street culture and global nightlife, shop its collections for premium, super-chi", null, "", null, "Gym King", null, "gym-king", null },
                    { 132, 746L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8600), "Founded in 2002 by Jeffrey Lubell, with the intention of redefining premium denim, <strong>True Religion</strong> draw inspiration from 1970s style to create a range of vintage inspired jeans", null, "", null, "True Religion", null, "true-religion", null },
                    { 133, 15631L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8601), "Whether it’s an embroidered logo, a bold graphic print or its iconic red, white and blue colour-blocking, there’s no mistaking <strong>Tommy Jeans</strong>. Flying the flag for all thing", null, "", null, "Tommy Jeans", null, "tommy-jeans", null },
                    { 134, 14334L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8603), "A true heritage brand, <strong>Helly Hansen</strong> was created back in 1877. Founded by Norwegian Helly Juell Hansen and his wife Maren Margarethe, they started out making clothing designed", null, "", null, "Helly Hansen", null, "helly-hansen", null },
                    { 135, 15863L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8604), "", null, "", null, "Barneys Originals Plus", null, "barneys-originals-plus", null },
                    { 136, 16279L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8606), "Give tired trainers the boot with our <strong>Koi Footwear</strong> at ASOS edit. Expect a range of vegan shoes, boots and trainers with a quirky, modern twist. From embellished hiking boots ", null, "", null, "Koi Footwear", null, "koi-footwear", null },
                    { 137, 3179L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8607), "", null, "", null, "Hunter", null, "hunter", null },
                    { 138, 14353L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8631), "Doing some sole searching? Scroll no further than Y2K icons <strong>Buffalo</strong>. With chunky treads that will transport you back to the 90s, expect statement-making trainers and boots in hi", null, "", null, "Buffalo", null, "buffalo", null },
                    { 139, 14489L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8633), "American denim brand <strong>Lee Jeans</strong> always finds the perfect balance between heritage and modernity. Fill your denim days with its cropped jeans, shirts and dungarees in skinny cuts, true", null, "", null, "Lee Jeans", null, "lee-jeans", null },
                    { 140, 16500L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8635), "", null, "", null, "Barney s Original Petite", null, "barney-s-original-petite", null },
                    { 141, 14698L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8728), "", null, "", null, "Brave Soul Plus", null, "brave-soul-plus", null },
                    { 142, 3009L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8730), "Outfit sorted but don’t have the footwear to go with it? <strong>Steve Madden</strong> has every style of shoe to help pull your look together, whatever the occasion. Expect chunky trainer", null, "", null, "Steve Madden", null, "steve-madden", null },
                    { 143, 15805L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8731), "Inspired by a trip to Bali, vegan brand <strong>Coco &amp; Eve</strong> was created by two friends who wanted to bring a taste of their travels back home. Now, thanks ", null, "", null, "Coco & Eve", null, "coco-&-eve", null },
                    { 144, 16380L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8733), "Starting as a single chair and sink in the corner of a nail bar, <strong>Bleach London</strong>n now has a number of hair salons, as well as a range of hair products designed to ", null, "", null, "Bleach London", null, "bleach-london", null },
                    { 145, 14339L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8735), "Straightforward skin care is grooming brand <strong>Bulldog</strong> in a nutshell. With vegan-friendly products designed for all skin types, confusing lingo has been ditched in fa", null, "", null, "Bulldog", null, "bulldog", null },
                    { 146, 14600L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8737), "Launched in 2014, <strong>Lola May</strong> reworks its high-end feel with street style influences for its capsule collection with ASOS. The result is a range of oversized shapes and minimal ta", null, "", null, "Lola May", null, "lola-may", null },
                    { 147, 14100L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8738), "<strong>Rains</strong> have been defying Danish weather - that’s an average of 121 rain days a year - since 2011, with their own take on the classic raincoat. With a concept designed to be easy to", null, "", null, "Rains", null, "rains", null },
                    { 148, 62251L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8740), "TBQHWY, we’re pretty sure our <strong>Made By Mitchell</strong> at ASOS edit will have your inner MUA swooning. Haven’t heard of the Blursh range? Allow us to introduce yo", null, "", null, "Made By Mitchell", null, "made-by-mitchell", null },
                    { 149, 16216L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8741), "", null, "", null, "Zoe Ayla", null, "zoe-ayla", null },
                    { 150, 16637L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8743), "If (like us) you love a bit of statement tailoring, where better to look for some wardrobe-addition inspiration than <strong>Pretty Lavish Curve</strong>? Founded by two sisters in 2013, t", null, "", null, "Pretty Lavish Curve", null, "pretty-lavish-curve", null },
                    { 151, 15718L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8744), "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous Curve</strong>, where individual style is the key.  The carefully ", null, "", null, "Glamorous Curve", null, "glamorous-curve", null },
                    { 152, 13512L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8746), "This is <strong>ASOS Petite</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is h", null, "", null, "ASOS Petite", null, "asos-petite", null },
                    { 153, 14513L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8747), "<strong>Champion</strong> has been sorting your street-meets-sportswear styles through the decades. Whether you’re a frequent gym goer, new to the tracks or just want to look good lounging, the", null, "", null, "Champion", null, "champion", null },
                    { 154, 15099L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8748), "The team behind <strong>My Accessories</strong> draw on more than 15 years of design expertise to put the finishing touches to your look. Expect berets, bag charms and beanies all in the ", null, "", null, "My Accessories", null, "my-accessories", null },
                    { 155, 13881L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8750), "The idea for <strong>Volcom</strong>&nbsp;came to its founders Richard Woolcott and Tucker Hall during a snowboarding trip in 1991. Incorporating their philosophy of 'Youth against establishment' t", null, "", null, "Volcom", null, "volcom", null },
                    { 156, 3182L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8751), "American label <strong>New Era</strong> have long enjoyed a relationship with the world of baseball, manufacturing baseball hats for teams since the 1930s. As popular off field as they are on, <", null, "", null, "New Era", null, "new-era", null },
                    { 157, 15849L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8753), "Disrupting the game since 1948, <strong>Puma Golf</strong> is out to set and smash goals in its bid to be the fastest sports brand in the world. Scroll the Puma at ASOS edit for the pieces we’re rat", null, "", null, "Puma Golf", null, "puma-golf", null },
                    { 158, 14751L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8754), "East meets West with our exclusive evening range, <strong>A Star Is Born</strong>. We’re talking party perfection with statement beading, hand embroidery and pretty prints. Fall for red", null, "", null, "A Star Is Born", null, "a-star-is-born", null },
                    { 159, 16711L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8756), "", null, "", null, "VAI21", null, "vai21", null },
                    { 160, 22855L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8757), "Watch out, the sun’s about. And we’re loving DIFF Eyewear for delivering *the* freshest sunglasses to help protect those peepers. Classic round sunglasses are given a modern update via pastel shades plus, expect square sunglasses that’ll amp-up ‘f", null, "", null, "DIFF Eyewear", null, "diff-eyewear", null },
                    { 161, 712L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8759), "Showcasing its signature style through key separates and statement party dresses, <strong>Ted Baker</strong> is renowned for bringing a contemporary edge to classic styles. Combining a vibrant ", null, "", null, "Ted Baker", null, "ted-baker", null },
                    { 162, 716L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8760), "London label <strong>TFNC</strong> is renowned for its standout occasionwear. Step it up in sparkly fabrics, embellished styles and party-prepped bodycon dresses – just don’t outshine the bride.", null, "", null, "TFNC", null, "tfnc", null },
                    { 163, 15368L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8762), "Brides-to-be, show your devotion to your best gals with <strong>Maya</strong> embellished bridesmaid dresses. Choose from a selection of midi, maxi and fit-and-flare styles for standout sequins, fl", null, "", null, "Maya", null, "maya", null },
                    { 164, 299L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8763), "Slick Danish design meets urban athleisure with sports-heritage brand <strong>Hummel</strong>. Listing both retro and current trends as influences, the label goes hard on strong colour combos, sp", null, "", null, "Hummel", null, "hummel", null },
                    { 165, 13688L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8765), "What do you get when you combine advanced technologies with flex-worthy footwear? <strong>Asics</strong>, obvs. Designed with top-tier workouts in mind, the brand serves up performance-enhanced styl", null, "", null, "Asics", null, "asics", null },
                    { 166, 16727L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8766), "Searching for running trainers that go the extra mile? <strong>On Running</strong> is the brand to bookmark. Not one for compromising, it was created by professional athletes and an engineer,", null, "", null, "On Running", null, "on-running", null },
                    { 167, 14269L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8767), "Ever since his game-changing jump shot sealed the 1982 NCAA Championship, Michael Jordan has been setting new standards in scores and style for basketball. After first wearing his original Air Jordan Is in 1985, ... ", null, "", null, "Jordan", null, "jordan", null },
                    { 168, 589L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8769), "Always bringing its A-game, sports giant <strong>Puma</strong> is all about setting and smashing goals in its quest to be forever faster. Feeling motivated yet? Join the club. Packed with all our fa", null, "", null, "Puma", null, "puma", null },
                    { 169, 13687L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8770), "<strong>Native Youth</strong> introduces oversized silhouettes and lightweight co-ords into your wardrobe this season. Expect clean shapes and soft-touch tencel contrasted with raw-edge fin", null, "", null, "Native Youth", null, "native-youth", null },
                    { 170, 391L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8772), "Famed for its iconic crocodile emblem, <strong>Lacoste</strong> was founded by tennis superstar René Lacoste in 1933 and was first to introduce the pique polo shirt. Utilising its sporting backgro", null, "", null, "Lacoste", null, "lacoste", null },
                    { 171, 16082L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8773), "Part high fashion, part street style, <strong>Versace Jeans Couture</strong> sits between the two. Founded by Donatella and Gianni Versace, the brand’s range of clothing and accessories ta", null, "", null, "Versace Jeans Couture", null, "versace-jeans-couture", null },
                    { 172, 15059L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8775), "", null, "", null, "Columbia", null, "columbia", null },
                    { 173, 16333L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8776), "The team behind <strong>My Accessories Curve</strong> draw on more than 15 years of design expertise to put the finishing touches to your look. Expect berets, bag charms and beanies all i", null, "", null, "My Accessories Curve", null, "my-accessories-curve", null },
                    { 174, 13927L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8778), "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, raw-cut ", null, "", null, "Noisy May", null, "noisy-may", null },
                    { 175, 16649L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8779), "If you need an excuse for a wardrobe update, <strong>BOSS Bodywear</strong> is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it comes to quality de", null, "", null, "BOSS Bodywear", null, "boss-bodywear", null },
                    { 176, 14969L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8780), "Accessorize your ‘fit to the fullest with London-based brand <strong>DesignB London</strong>. We’re talking from head-to-toe, with hair clips, earrings and anklets that have both Scandi mini", null, "", null, "DesignB London", null, "designb-london", null },
                    { 177, 14955L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8782), "Put your feet up. <strong>Loungeable</strong> has all your lazy-day needs covered. Get in your comfort zone with its fun prints, fleece fabrics and super-cute novelty slippers.", null, "", null, "Loungeable", null, "loungeable", null },
                    { 178, 15146L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8783), "From standout styles to everyday basics, London-based <strong>Boux Avenue</strong>  lingerie collection has you covered in all the right places. With a focus on fit and attention to deta", null, "", null, "Boux Avenue", null, "boux-avenue", null },
                    { 179, 16568L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8785), "Stepping up at a time when fashion dictated a single look, footwear brand <strong>Schuh</strong> has led the way in the ‘wear whatever’ movement. Master of fulfilling your footwear needs, its of", null, "", null, "Schuh", null, "schuh", null },
                    { 180, 752L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8786), "A hit with the So-Cal surf crowd back in the 70s, <strong>UGG</strong> iconic sheepskin boots have come a long way since then. From the beach to bona fide footwear staple, the brand now offers everyt", null, "", null, "UGG", null, "ugg", null },
                    { 181, 15139L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8818), "Specialising in streetwear, <strong>HUGO</strong> is here to push boundaries through its clothing – and we’re *big* fans. Shop our HUGO at ASOS edit to bag graphic T-shirts, hoodies and sweatshir", null, "", null, "HUGO", null, "hugo", null },
                    { 182, 12927L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8819), "Inspired by Inuit knowhow, <strong>Sorel</strong> shoes and boots provide insulation even in the coldest of sub zero temperatures. Uncompromising craftsmanship and uncomplicated design see a range o", null, "", null, "Sorel", null, "sorel", null },
                    { 183, 22005L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8821), "It’s the little things that count. Case in point: Charles & Keith's range of accessories. Serving up finishing touches for your ‘fit, the label is sure to raise those envy-inducing levels. Scroll shoulder bags and cross-body bags (not to mention their", null, "", null, "Charles & Keith", null, "charles-&-keith", null },
                    { 184, 17855L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8822), "Hair-wash day just got interesting. Specialising in luxe, salon-quality hair-care products formulated with natural ingredients, vegan-brand <strong>Monday Haircare</strong> is ", null, "", null, "Monday Haircare", null, "monday-haircare", null },
                    { 185, 13126L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8824), "<strong>Herschel Supply Co</strong> produces quality built backpacks inspired by vintage mountaineering equipment, American heritage and world travel. With a passion for individuality and persona", null, "", null, "Herschel Supply Co", null, "herschel-supply-co", null },
                    { 186, 12144L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8825), "<strong>Tangle Teezer</strong> specialises in award-winning hairbrushes that make taming your hair a whole lot easier. Thanks to patented teeth technology, the brand’s brushes are ", null, "", null, "Tangle Teezer", null, "tangle-teezer", null },
                    { 187, 14059L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8827), "Known for its elaborately illustrated decks, skateboard brand <strong>Santa Cruz</strong> accompanying apparel is every bit as cool as its cruisers. The result is a collection of boyfriend T-", null, "", null, "Santa Cruz", null, "santa-cruz", null },
                    { 188, 16183L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8828), "Want to switch up your look in minutes? Great news, <strong>Lullabellz</strong>'s lace-front wigs are an easy way to experiment with your vibe. The brand is big on everyday glam and we’ve p", null, "", null, "Lullabellz", null, "lullabellz", null },
                    { 189, 16471L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8830), "", null, "", null, "NEOM", null, "neom", null },
                    { 190, 16477L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8831), "ICYDK, <strong>Aveeno</strong> is the skincare brand turning softness up a notch. You can forget dry flakes and cracked skin ain’t a thing when you’ve got body washes, buttery hand ", null, "", null, "Aveeno", null, "aveeno", null },
                    { 191, 16131L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8833), "Unable to find apparel that expressed his style the way he wanted, <strong>Karl Kani</strong> decided to take matters into his own hands. At just 16, the Brooklyn-born designer began making his ", null, "", null, "Karl Kani", null, "karl-kani", null },
                    { 192, 3098L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8834), "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety of fits", null, "", null, "Vero Moda", null, "vero-moda", null },
                    { 193, 14076L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8836), "<strong>Neon Rose</strong> switches up its contemporary style from dusk till dawn, layering cool outerwear over relaxed playsuits, plunging necklines and midi dresses. Shop its separates for c", null, "", null, "Neon Rose", null, "neon-rose", null },
                    { 194, 15994L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8837), "<strong>Neon Rose Plus</strong> switches up its contemporary style from dusk till dawn, layering cool outerwear over relaxed playsuits, plunging necklines and midi dresses. Shop its separates ", null, "", null, "Neon Rose Plus", null, "neon-rose-plus", null },
                    { 195, 160L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8839), "An iconic brand for as long as we can remember, <strong>DKNY</strong> designs fail-safe pieces for work, play, and everything in-between. Created by fashion legend Donna Karan, the label serves up B", null, "", null, "DKNY", null, "dkny", null },
                    { 196, 3119L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8841), "Inspired by 1900's French actress Sarah Bernhardt's on-stage corseted silhouette, <strong>Gossard</strong> began creating super smooth underwear for cleavage enhancing curves. ... ", null, "", null, "Gossard", null, "gossard", null },
                    { 197, 15807L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8843), "<strong>The Couture Club</strong> – Manchester’s latest street-style offering – is changing the casualwear game. A self-confessed lifestyle brand, its range of T-shirts and sweats a", null, "", null, "The Couture Club", null, "the-couture-club", null },
                    { 198, 13510L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8844), "This is <strong>ASOS Maternity</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand i", null, "", null, "ASOS Maternity", null, "asos-maternity", null },
                    { 199, 14042L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8846), "Inspired by what lies beneath, British lingerie label <strong>Bluebella</strong> creates fashion cross-over styles with a provocative twist. Check out our edit of its bras, briefs and bodies a", null, "", null, "Bluebella", null, "bluebella", null },
                    { 200, 16631L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8847), "Get ready to send those ‘What you wearing?’ texts, because <strong>ASOS Luxe</strong> is serving elevated looks that'll dominate your IG feed and beyond. Make high-key co-ords the first st", null, "", null, "ASOS LUXE", null, "asos-luxe", null },
                    { 201, 16508L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8849), "<strong>LAUREN by RALPH LAUREN</strong> has achieved icon status. Known for its preppy-chic designs and signature polo player logo, the brand offers a range of collegiate-cool clothing", null, "", null, "LAUREN by RALPH LAUREN", null, "lauren-by-ralph-lauren", null },
                    { 202, 15882L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8850), "", null, "", null, "Lindex", null, "lindex", null },
                    { 203, 12255L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8852), "Eclectic label <strong>Orelia</strong> makes beautiful costume jewellery adorned with Swarovski crystals, semi-precious stones and charms. A love of shopping and travel sees eclectic influences a", null, "", null, "Orelia", null, "orelia", null },
                    { 204, 20202L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8853), "After some new beachwear for your next trip?&nbsp;<strong>Esmee Curve</strong>&nbsp;has a range of relaxed options for when it’s extra hot. For something to throw on over your bikini, browse the ", null, "", null, "Esmee Curve", null, "esmee-curve", null },
                    { 205, 3738L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8855), "Searching for trend-led designs combined with a timeless appeal? Then look to <strong>Dune</strong>. With a collection featuring cross-body and tote bags, your belongings will be secured in s", null, "", null, "Dune", null, "dune", null },
                    { 206, 12840L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8856), "Embracing freedom, identity and style, <strong>Selected</strong> offers a collection of understated elegance and timeless cool. Focusing on clean, contemporary lines with its tailoring, ... ", null, "", null, "Selected", null, "selected", null },
                    { 207, 15687L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8857), "Whatever the occasion, nail your going-out ’fit with <strong>Flounce London</strong> collection of party pieces. Streamline your silhouette in velvet and metallic bodysuits, or choose f", null, "", null, "Flounce London", null, "flounce-london", null },
                    { 208, 12205L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8859), "Developing a high-tech skin-care range specifically for men, <strong>LAB Series</strong> is big on science-first formulas. What’s more, the experts behind the brand have made sure", null, "", null, "LAB Series", null, "lab-series", null },
                    { 209, 3379L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8860), "Calling all skincare obsessives – <strong>Elemis</strong> range of skin and body-care heroes brings the spa to you. Created by a team of scientists and skincare experts, the brand blends botani", null, "", null, "Elemis", null, "elemis", null },
                    { 210, 20551L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8862), "Body-care brand Flamingo believes that when we take care of ourselves, we’re able show up for ourselves. With a range of products designed to upgrade your TLC routine, scroll our Flamingo at ASOS edit and experience the brand’s science and feedback-ba", null, "", null, "Flamingo", null, "flamingo", null },
                    { 211, 22805L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8863), "This is makeup brand <strong>Doll Beauty</strong>, and its motto is: make them stare. POV: you're turning glam all the way up with its super-shiny lip glosses in every shade from b", null, "", null, "Doll Beauty", null, "doll-beauty", null },
                    { 212, 20701L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8865), "Created in 2013 around the founder’s kitchen table, <strong>Revolution Man</strong> is committed to making vegan makeup and skincare that’s accessible to all. You’ll have to be quick thou", null, "", null, "Revolution Man", null, "revolution-man", null },
                    { 213, 15563L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8866), "Your hair and skin go through a lot. Treat them to some well-earned TLC with <strong>Apothecary 87</strong> grooming and styling products. Fragranced with super-fresh scents, the brand’s r", null, "", null, "Apothecary 87", null, "apothecary-87", null },
                    { 214, 12930L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8867), "There’s no better feeling than taking your makeup off at the end of the day, but when it comes to <strong>bareMinerals</strong>, you might forget you even have it on. Naturally ", null, "", null, "bareMinerals", null, "bareminerals", null },
                    { 215, 15585L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8869), "Scouring the globe to source the perfect ingredients, <strong>Murdock London</strong> doesn&rsquo;t hold back when it comes to creating its range of men's grooming products.", null, "", null, "Murdock London", null, "murdock-london", null },
                    { 216, 16337L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8870), "Our edit of your new favourite brand <strong>Style Cheat</strong> is here. Delivering the cutest dresses, tops and jumpsuits, ... ", null, "", null, "Style Cheat", null, "style-cheat", null },
                    { 217, 14988L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8872), "Put the sweats away and dress up for the day with <strong>Amy Lynn</strong>. The London-based clothing label offers up contemporary capsule collections that’ll have you craving that look-good", null, "", null, "Amy Lynn", null, "amy-lynn", null },
                    { 218, 12507L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8874), "Underwear authority and all-round fashion icon, <strong>Calvin Klein Jeans</strong> puts a designer stamp on clean, casual-cool staples. From smart shirts to waistbands, the brand’s famous C", null, "", null, "Calvin Klein Jeans", null, "calvin-klein-jeans", null },
                    { 219, 15715L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8877), "With a rich heritage dating back to 1894, quintessentially British brand, <strong>Barbour International</strong> have garnered a reputation for quality and durability, across their collection of h", null, "", null, "Barbour International", null, "barbour-international", null },
                    { 220, 14630L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8878), "", null, "", null, "Beauty Extras", null, "beauty-extras", null },
                    { 221, 16338L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8880), "Taking elements of street culture, Alpine lifestyle and British design, snow-sports brand Planks is owned and inspired by skiers. Built for the slopes, but just as at home on the streets, ... ", null, "", null, "Planks", null, "planks", null },
                    { 222, 15643L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8881), "Whether you’re gaining, training or exploring the great outdoors, our resident fitness brand <strong>ASOS 4505</strong> has your athletic aesthetic covered. Scroll leggings, shorts and jogge", null, "", null, "ASOS 4505", null, "asos-4505", null },
                    { 223, 12113L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8883), "A literal translation of the German for 'mountain centre', <strong>Berghaus</strong> was founded in 1966 by two mountaineering friends frustrated with the lack of decent outdoor wear.", null, "", null, "Berghaus", null, "berghaus", null },
                    { 224, 16546L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8903), "Searching for shoes that will take your wedding-day look from aisle-to-dancefloor?&nbsp;<strong>Be Mine Wide Fit</strong>&nbsp;is here to tick one thing off your list, so you can focus on the ", null, "", null, "Be Mine Wide Fit", null, "be-mine-wide-fit", null },
                    { 225, 16059L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8905), "<strong>4th & Reckless</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend shades", null, "", null, "4th & Reckless", null, "4th-&-reckless", null },
                    { 226, 62151L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8906), "Give your hair the TLC it deserves with our <strong>Sachajuan</strong> at ASOS edit. All about keeping it simple, the brand focuses on making haircare easy. From volumizing and scalp", null, "", null, "Sachajuan", null, "sachajuan", null },
                    { 227, 15747L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8908), "", null, "", null, "HIIT", null, "hiit", null },
                    { 228, 13078L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8910), "<strong>Nars</strong> has become one of the biggest names in the industry since its conception in 1994 by François Nars. Known for its no-rules attitude to self-expression, the brand’s co", null, "", null, "Nars", null, "nars", null },
                    { 229, 13527L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8912), "Created in 2013 around the founder&rsquo;s kitchen table, <strong>Revolution</strong> is committed to making vegan makeup and skincare that&rsquo;s accessible to all. You&rsquo;ll h", null, "", null, "Revolution", null, "revolution", null },
                    { 230, 15898L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8913), "<strong>Philip Kingsley</strong> knows that healthy, happy hair begins at the roots. The brand’s award-winning range of shampoos and conditioners is powered by trichology, me", null, "", null, "Philip Kingsley", null, "philip-kingsley", null },
                    { 231, 16190L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8915), "When it comes to textured hair, Cantu is your go-to brand – but you probably already knew that. Its award-winning treatments are designed to look after your coils, curls, waves, or straight tresses. Our edit features all the classics, including the ultr", null, "", null, "Cantu", null, "cantu", null },
                    { 232, 16264L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8916), "From its working cowboy roots, <strong>Wrangler Plus</strong> American blue jeans set a new standard for the denim industry. Inspired by the very first pair of ... ", null, "", null, "Wrangler Plus", null, "wrangler-plus", null },
                    { 233, 15230L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8918), "High-street hero <strong>River Island Petite</strong> covers all bases with its selection of clothing, accessories, swimwear and footwear. Offering everything from standout party dresses an", null, "", null, "River Island Petite", null, "river-island-petite", null },
                    { 234, 22659L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8919), "Looking to spritz up your fragrance shelf? Indulge in a lil bit of luxury with Michael Kors Fragrances. From fashion to fragrance, the brand adds *luxe* to everything it creates – think florals, citrus and musky scents. Shop our Michael Kors Fragrances ", null, "", null, "Michael Kors Fragrances", null, "michael-kors-fragrances", null },
                    { 235, 13488L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8921), "", null, "", null, "Issey Miyake", null, "issey-miyake", null },
                    { 236, 62061L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8922), "Say goodbye to the taboos of body care and hello to our Megababe at ASOS edit. Ft. the goods to top up your self-care shelf, the label will have you feeling comfortable AND confident in your own skin. Shop deodorants to fight sweat and odour, or scroll an", null, "", null, "Megababe", null, "megababe", null },
                    { 237, 16205L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8924), "We’re calling it – <strong>Crocs</strong> are back. Since 2002, the brand has dedicated itself to finding new comfort technologies and revolutionary materials to keep your feet feeling good – ", null, "", null, "Crocs", null, "crocs", null },
                    { 238, 612L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8925), "Hitting refresh on classic cuts – the name makes sense now, right? – <strong>Replay</strong> jeans, jackets and T-shirts are updated with hand-crafted details and over-dyed finishes. Its bags an", null, "", null, "Replay", null, "replay", null },
                    { 239, 3272L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8927), "Founded on Bondi Beach, <strong>Speedo</strong> is the world's best-selling swimwear brand, synonymous with a legion of gold medal champions. With a focus on technical innovation, the label has bee", null, "", null, "Speedo", null, "speedo", null },
                    { 240, 16670L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8928), "ICYMI, there’s a Y2K revival and <strong>Bailey Rose</strong> is bringing all the nostalgic feels. We’ve pulled together our pick of the labels smock dresses in retro prints and cute, cr", null, "", null, "Bailey Rose", null, "bailey-rose", null },
                    { 241, 15441L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8930), "", null, "", null, "Influence Plus", null, "influence-plus", null },
                    { 242, 13632L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8931), "Channelling a vintage vibe with a standout collection of party dresses and glam separates, <strong>Frock and Frill</strong> mixes catwalk inspiration with Art Deco detailing. With a fresh, f", null, "", null, "Frock and Frill", null, "frock-and-frill", null },
                    { 243, 21555L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8933), "Unlock your wardrobe potential with <strong>Something New</strong>, the brand that encourages you to be bold. Expect gram-worthy designs ft. prints and embellishments as well as matching c", null, "", null, "Something New", null, "something-new", null },
                    { 244, 14565L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8934), "With a flair for party pieces, <strong>NaaNaa</strong> puts its statement stamp on bodycon silhouettes, tailored jumpsuits and figure-flattering midi dresses. Strappy styling and peekaboo cut-out", null, "", null, "NaaNaa", null, "naanaa", null },
                    { 245, 20650L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8937), "Give your beauty bag the ultimate makeover with <strong>e.l.f.</strong>. The vegan brand is all about creating game-changing products for every face – we’re talking mascaras to make", null, "", null, "e.l.f.", null, "e.l.f.", null },
                    { 246, 15818L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8938), "Named after the makeup artist who founded it in 1991, cosmetics brand <strong>Bobbi Brown</strong> started life behind the counter of a department store in New York City. Fast forw", null, "", null, "Bobbi Brown", null, "bobbi-brown", null },
                    { 247, 740L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8940), "What's full of makeup bag MVPs and offers endless looks? Our <strong>Too Faced Cosmetics</strong> at edit at ASOS of course. Scroll the brand’s chocolate bronzers to add some warmth", null, "", null, "Too Faced Cosmetics", null, "too-faced-cosmetics", null },
                    { 248, 16543L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8941), "Founded in 2014, British brand <strong>Mylee</strong> makes DIY dreams a reality with its extensive range of gel nail polishes, primers and nail-perfecting treatments – meaning you can", null, "", null, "Mylee", null, "mylee", null },
                    { 249, 16551L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8943), "", null, "", null, "Acnecide", null, "acnecide", null },
                    { 250, 16552L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8944), "Hit refresh on your morning routine and show your skin some love with <strong>Sunday Riley</strong>. The brand’s products are made with balancing botanicals and lightweight, vit", null, "", null, "Sunday Riley", null, "sunday-riley", null },
                    { 251, 15943L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8946), "", null, "", null, "Laura Mercier", null, "laura-mercier", null },
                    { 252, 15939L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8947), "", null, "", null, "Origins", null, "origins", null },
                    { 253, 13931L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8949), "", null, "", null, "Brave Soul", null, "brave-soul", null },
                    { 254, 14989L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8950), "Specialising in clean, minimal tailoring, British label <strong>Unique 21</strong> smartens up your wardrobe staples with its latest offering. Designed exclusively in-house, th", null, "", null, "UNIQUE21", null, "unique21", null },
                    { 255, 20750L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8952), "", null, "", null, "Cherry Beach", null, "cherry-beach", null },
                    { 256, 21960L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8953), "If it’s cool casualwear you’re after, then it’s cool casualwear you’re gonna get – <strong>GUESS Originals</strong>, please stand up. Inspired by modern streetwear and archival", null, "", null, "GUESS Originals", null, "guess-originals", null },
                    { 257, 21706L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8955), "Question: what casj wardrobe is complete without pieces from PACSUN? Answer: none. The California-based brand is delivering throw-on-and-go styles that’ll become your everyday heroes. Expect hoodies, T-shirts and jeans with the freshest cuts and graphic", null, "", null, "PACSUN", null, "pacsun", null },
                    { 258, 18850L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8956), "", null, "", null, "First Distraction", null, "first-distraction", null },
                    { 259, 14434L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8958), "With an approach grounded in science, leading beauty brand <strong>L'Oreal</strong> demands only the most visionary products from its team. Whether you need an everyday cover-up or a slick", null, "", null, "L'Oreal", null, "l'oreal", null },
                    { 260, 16340L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8959), "When it comes to occasionwear, there’s nothing like a little sparkle. Serving embellished dresses, tops and bottoms, our <strong>Beauut</strong> at ASOS edit has you covered for every event in ", null, "", null, "Beauut", null, "beauut", null },
                    { 261, 13679L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8962), "Trend focused and led by catwalk styles, <strong>Influence</strong> create a collection of knitwear, dresses and jersey separates. ... ", null, "", null, "Influence", null, "influence", null },
                    { 262, 15950L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8963), "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now", null, "", null, "Nike Basketball", null, "nike-basketball", null },
                    { 263, 21661L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8965), "Streamline your style with ultra-glam brand Commando. Serving seamless bodysuits, leggings and crop tops, the brand specialises in timeless staples to sculpt and enhance. Shop our Commando at ASOS edit for mini skirts that offer a sleek, form-fitting silh", null, "", null, "Commando", null, "commando", null },
                    { 264, 14490L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8966), "Streetwear label <strong>Good For Nothing</strong> confronts the status quo with its collection of contrasts. Established in 2011, it challenges construction with tees and sweats in cut a", null, "", null, "Good For Nothing", null, "good-for-nothing", null },
                    { 265, 16377L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9014), "ABOUT WE ARE WE WEAR <strong>We Are We Wear</strong> is making waves on the swimwear scene. Its versatile collection is inspired by the idea that swimwear isn’t just for a dip in the se", null, "", null, "We Are We Wear", null, "we-are-we-wear", null },
                    { 266, 14607L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9016), "Proving there’s nothing accidental about <strong>Flook</strong> woven designs, founder Nikki Flook calls on highly skilled artisans in Indonesia to create her collections. The result is a range ", null, "", null, "Flook", null, "flook", null },
                    { 267, 15301L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9017), "London-based label <strong>Lace & Beads</strong> know sparkly dresses are always a good idea, so create the perfect handcrafted party pieces for your BNO. Expect standout embellishment, crop ", null, "", null, "Lace & Beads", null, "lace-&-beads", null },
                    { 268, 14369L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9019), "Dress for the main stage with <strong>Parisian</strong> cool cover-ups and crochet separates. It’s all in the details, so pack a floral print to ace your festival steez, or fall for fringing ", null, "", null, "Parisian", null, "parisian", null },
                    { 269, 16715L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9020), "Social calendar filling up fast? Pair your plans with 00s-born <strong>Urban Revivo</strong>, the fashion-forward brand with runway-inspired designs at the ready. Shop all the latest looks,", null, "", null, "Urban Revivo", null, "urban-revivo", null },
                    { 270, 12512L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9022), "Built on principles of comfort and durability, American brand <strong>Skechers</strong> has become a household name in premium kicks. Offering both casual and performance ranges, the brand chann", null, "", null, "Skechers", null, "skechers", null },
                    { 271, 13575L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9023), "<strong>Little Mistress</strong> collection ticks all your occasionwear boxes – we’re talking weddings, proms, fancy parties and everything in-between. The brand’s pretty dresses a", null, "", null, "Little Mistress", null, "little-mistress", null },
                    { 272, 166L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9025), "Famous for their narrow silhouette and skinny jeans, <strong>Dr Denim</strong> was founded in Sweden in 2003 and today offers a variety of clothing with denim very much still on the agenda.", null, "", null, "Dr Denim", null, "dr-denim", null },
                    { 273, 16554L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9026), "Embracing all things Sunday, Australian brand <strong>SNDYS</strong> is big on easy, comfy clothing. The brand’s knitted T-shirts, skirts, hoodies and trousers are ideal for lounging, while subt", null, "", null, "SNDYS", null, "sndys", null },
                    { 274, 12732L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9028), "With a rich heritage dating back to 1894, quintessentially British brand, <strong>Barbour</strong> have garnered a reputation for quality and durability, across their collection of high performanc", null, "", null, "Barbour", null, "barbour", null },
                    { 275, 16623L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9029), "", null, "", null, "Salomon", null, "salomon", null },
                    { 276, 14823L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9031), "If you thought <strong>Public Desire</strong> only did shoes, we’ve got news for you. Updating its offering with a range of selfie-worthy apparel – think slinky dresses, statement co-o", null, "", null, "Public Desire", null, "public-desire", null },
                    { 277, 15723L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9033), "<strong>adidas Golf</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ", null, "", null, "adidas Golf", null, "adidas-golf", null },
                    { 278, 582L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9036), "If you wear tights, chances are you’ve worn a pair of <strong>Pretty Polly</strong> tights. Leading the hosiery game since 1919, the British brand’s selection of tights is available in a", null, "", null, "Pretty Polly", null, "pretty-polly", null },
                    { 279, 12359L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9037), "<strong>Mama.licious</strong> make light work of pregnancy dressing, with a modern collection of jeans, dresses and jersey designed to flatter your bump and accommodate your new curves. Mixing fine prints, delicate cuts and femini", null, "", null, "Mama.licious", null, "mama.licious", null },
                    { 280, 3563L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9039), "Jim Jannard founded <strong>Oakley</strong> with $300 and the simple idea of making sunglasses that work and look better than anything else out there. Beginning an evolution of eyewear from generic ", null, "", null, "Oakley", null, "oakley", null },
                    { 281, 3624L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9040), "When Quiksilver started sister label <strong>Roxy</strong> it was a pretty big deal. With a band of female pro surfers quite literally on board, ... ", null, "", null, "Roxy", null, "roxy", null },
                    { 282, 15129L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9042), "<strong>Miss Selfridge Petite</strong> takes you from day to date night with its off-duty looks and full-on glamour. Solve what-to-wear dilemmas with its dresses and accessories that comb", null, "", null, "Miss Selfridge Petite", null, "miss-selfridge-petite", null },
                    { 283, 13889L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9043), "Born roadside on the festival circuit, eyewear brand <strong>Quay Australia</strong> helps you soak up the good vibes with its range of standout sunglasses and glasses. Serve real shade with oversi", null, "", null, "Quay Australia", null, "quay-australia", null },
                    { 284, 16641L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9048), "Looking to pull off practical-meets-glam athleisure? Take a cue from our <strong>Lapp The Brand</strong> at ASOS edit. Serving effortless styles designed to flatter and empower, shop the ", null, "", null, "Lapp The Brand", null, "lapp-the-brand", null },
                    { 285, 15648L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9050), "Australian label <strong>TYPO</strong> offers a fun collection of gifts and homeware. Channelling its quirky personality into a range of designs, the brand’s glitter notebooks, pens and speakers ", null, "", null, "TYPO", null, "typo", null },
                    { 286, 16657L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9051), "Born among artists and influencers in Los Angeles, <strong>Morphe</strong> blends the rules and celebrates individuality with its high-performance makeup collection. Whether bright neon", null, "", null, "Morphe", null, "morphe", null },
                    { 287, 14664L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9052), "", null, "", null, "Brave Soul Tall", null, "brave-soul-tall", null },
                    { 288, 15817L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9054), "Founded back in 1968, <strong>Clinique</strong> has gone on to become one of the world’s most iconic skin-care and makeup brands – but you already knew that. We’re giving props ", null, "", null, "Clinique", null, "clinique", null },
                    { 289, 15796L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9055), "Tell a friend – <strong>MAC</strong> has launched on ASOS and all our dreams have come true. The colourful cosmetics brand officially launched in 1984 in a department store in Toronto, C", null, "", null, "MAC", null, "mac", null },
                    { 290, 15407L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9057), "", null, "", null, "Soul Star", null, "soul-star", null },
                    { 291, 13027L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9058), "Blink and you’ll miss it – <strong>Nip+Fab</strong> collection of skin-care products aims to deliver instant results. Formulated with innovative ingredients including glycolic acid and drag", null, "", null, "Nip+Fab", null, "nip+fab", null },
                    { 292, 3470L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9059), "<strong>Muubaa</strong> design philosophy is about creating current yet timeless pieces for each wearer to make their own. Redefining the possibilities of leather, ... ", null, "", null, "Muubaa", null, "muubaa", null },
                    { 293, 15841L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9062), "", null, "", null, "Dr Dennis Gross", null, "dr-dennis-gross", null },
                    { 294, 14722L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9064), "A diffusion line from iconic fashion house Armani, <strong>EA7</strong> offers timeless style with their collections of wearable classics. ... ", null, "", null, "EA7", null, "ea7", null },
                    { 295, 16445L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9066), "Created in 2013 around the founder’s kitchen table, <strong>Revolution Pro</strong> is committed to making vegan makeup and skincare that’s accessible to all. You’ll have to b", null, "", null, "Revolution Pro", null, "revolution-pro", null },
                    { 296, 15379L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9067), "After tying up her hair for a fancy dress party with an old phone cord, <strong>Invisibobble</strong> founder discovered a new way to tidy her tresses. Enlisting German technicians to finalise he", null, "", null, "Invisibobble", null, "invisibobble", null },
                    { 297, 22605L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9069), "Object Tall is one of those clothing brands that everyone can get in on. Its mixture of boho styles and minimal designs serve up that casual-cool vibe we all know and love. Think pretty dresses in relaxed cuts, blouses in interesting fabrics and everyday ", null, "", null, "Object Tall", null, "object-tall", null },
                    { 298, 15928L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9070), "Skincare can be confusing with ingredients that sound more sci-fi than soothing. Luckily, though, skincare brand <strong>THE INKEY LIST</strong>  believes in a more straightforw", null, "", null, "THE INKEY LIST", null, "the-inkey-list", null },
                    { 299, 15461L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9073), "<strong>L'Oreal Men Expert</strong> don’t throw around the term ‘expert’ lightly. This is a grooming range that combines a legacy of science and innovation and is designed complete", null, "", null, "L'Oreal Men Expert", null, "l'oreal-men-expert", null },
                    { 300, 16360L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9075), "If you thought <strong>Public Desire Wide Fit</strong> only did shoes, we’ve got news for you. Updating its offering with a range of selfie-worthy apparel – think slinky dresses, state", null, "", null, "Public Desire Wide Fit", null, "public-desire-wide-fit", null },
                    { 301, 23255L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9077), "Makeup that nurtures your skin? Yes please. All about putting its formulas first, <strong>The Beauty Crop</strong> uses nutrition-rich ingredients in its products while deliver", null, "", null, "The Beauty Crop", null, "the-beauty-crop", null },
                    { 302, 21502L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9078), "", null, "", null, "AZALEA WANG", null, "azalea-wang", null },
                    { 303, 15665L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9080), "", null, "", null, "Shea Moisture", null, "shea-moisture", null },
                    { 304, 22955L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9081), "Give your pyjama drawer some love with our Luna at ASOS edit. All about trend-led nightwear, the brand will have you entering sleep mode in style. Scroll matching shirt and short sets in multiple prints or go all-in-one with its comfy rompers. Looking to ", null, "", null, "Luna", null, "luna", null },
                    { 305, 16355L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9083), "<strong>4th & Reckless Petite</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend", null, "", null, "4th & Reckless Petite", null, "4th-&-reckless-petite", null },
                    { 306, 16354L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9084), "<strong>4th & Reckless Tall</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend s", null, "", null, "4th & Reckless Tall", null, "4th-&-reckless-tall", null },
                    { 307, 22159L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9086), "<strong>4th & Reckless Plus</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend sh", null, "", null, "4th & Reckless Plus", null, "4th-&-reckless-plus", null },
                    { 308, 16478L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9119), "If you’re looking to achieve shiny, healthy-looking hair at home, <strong>OLAPLEX's</strong> hair-care heroes are designed to restore and strengthen damaged hair. The brand’s game-", null, "", null, "OLAPLEX", null, "olaplex", null },
                    { 309, 15751L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9120), "Founded in Melbourne in 2006 as a start-up retailer, <strong>Forever New Petite</strong> has evolved into one of the fastest-growing brands in Australia, thanks to its film and catwalk-inspi", null, "", null, "Forever New Petite", null, "forever-new-petite", null },
                    { 310, 15709L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9127), "Whatever the occasion, nail your going-out ’fit with <strong>Flounce London Plus</strong> collection of party pieces. Fall for velvet and metallic bodysuits, or choose from fancier-than", null, "", null, "Flounce London Plus", null, "flounce-london-plus", null },
                    { 311, 14459L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9129), "With its standout bodycons and sequinned dresses, <strong>Starlet</strong> proves first impressions count. Shop its embroidered and hand-embellished pieces, designed by its talented team and ins", null, "", null, "Starlet", null, "starlet", null },
                    { 312, 14510L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9130), "From its humble beginnings at London’s Portobello Road market, <strong>Never Fully Dressed</strong> has grown into a brand known for classic clean lines and flattering silhouettes.", null, "", null, "Never Fully Dressed", null, "never-fully-dressed", null },
                    { 313, 15058L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9132), "If you like your trends as fast as they come then <strong>Daisy Street Plus</strong> is the label for you. Always up on their A-game, ... ", null, "", null, "Daisy Street Plus", null, "daisy-street-plus", null },
                    { 314, 22906L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9133), "<strong>JDY Tall</strong> collection here at ASOS is a bit of us, and we think it’ll be a bit of you, too. Mix and match its dreamy denim skirts and jeans with trusty jersey pieces, or snap up an ", null, "", null, "JDY Tall", null, "jdy-tall", null },
                    { 315, 22905L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9135), "<strong>JDY Petite</strong> collection here at ASOS is a bit of us, and we think it’ll be a bit of you, too. Mix and match its dreamy denim skirts and jeans with trusty jersey pieces, or snap up a", null, "", null, "JDY Petite", null, "jdy-petite", null },
                    { 316, 131L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9137), "The iconic high-top canvas trainer created by <strong>Converse</strong> at the beginning of the 20th Century, have become a genre defining item. They now sit comfortably alongside the label's trai", null, "", null, "Converse", null, "converse", null },
                    { 317, 12279L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9139), "", null, "", null, "Gap", null, "gap", null },
                    { 318, 18500L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9140), "This is <strong>ASOS WEEKEND COLLECTIVE</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universa", null, "", null, "ASOS WEEKEND COLLECTIVE", null, "asos-weekend-collective", null },
                    { 319, 17802L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9142), "Created in 2013 around the founder’s kitchen table,&nbsp;<strong>Revolution Hair</strong>&nbsp;is committed to making vegan makeup and skincare that’s accessible to all. You’l", null, "", null, "Revolution Hair", null, "revolution-hair", null },
                    { 320, 13621L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9143), "Whether you’re surfin' in the sun, boardin’ in the snow or chillin’ by the campfire, activewear label <strong>Quiksilver</strong> has got all your moods covered. Scroll our Quiksilver a", null, "", null, "Quiksilver", null, "quiksilver", null },
                    { 321, 15700L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9145), "Hailing from sunny Los Angeles, our AFRM at ASOS edit brings California street style straight to your saved list. Short for affirmation (ICYDK), AFRM creates fashion-forward pieces incl. bodycon dresses with lace-up deets for when the club’s calling you", null, "", null, "AFRM", null, "afrm", null },
                    { 322, 15831L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9146), "Switch up your suiting game with <strong>Twisted Tailor</strong>. Taking inspiration from British culture with a nod to punk attitude, the London-based brand is coming through with high-qua", null, "", null, "Twisted Tailor", null, "twisted-tailor", null },
                    { 323, 15619L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9148), "Founded in Melbourne in 2006 as a start-up retailer, <strong>Forever New</strong> has evolved into one of the fastest-growing brands in Australia, thanks to its range of film and catwalk-ins", null, "", null, "Forever New", null, "forever-new", null },
                    { 324, 62059L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9149), "ICYDK, dressing modestly doesn’t mean you have to compromise your style creds – DASKA is here to prove it. It’s the bolder the better when it comes to this brand’s jumpsuits and high-neck maxi dresses, ft. block colours and bright prints. Or, for ", null, "", null, "Daska", null, "daska", null },
                    { 325, 16173L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9151), "Seeking inspiration from street and city style, Scandi favourite <strong>Vila Petite</strong> combines quality fabrics and delicate cuts to create a collection of fashion-forward pieces. Signature f", null, "", null, "Vila Petite", null, "vila-petite", null },
                    { 326, 21657L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9152), "Nobody nails elevated basics like British brand Kaiia. From corset tops to cargo trousers, our Kaiia at ASOS edit will take your street style to the next level. Refresh your daywear ‘drobe with co-ord sets and mix-and-match tailoring (hello, cropped bla", null, "", null, "Kaiia", null, "kaiia", null },
                    { 327, 14251L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9154), "Aussie label <strong>Ripcurl</strong> was born in the cold water waves of Bells Beach. Not just for the boys, ... ", null, "", null, "Ripcurl", null, "ripcurl", null },
                    { 328, 16575L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9155), "Serving up new-new trends, emerging brand <strong>AsYou</strong> is a big vibe. Whether you’re off-duty or going out-out, there’s a piece for every mood – from legging shorts and oversized ", null, "", null, "AsYou", null, "asyou", null },
                    { 329, 15360L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9157), "Inspired by the most beautiful people in the world, the designers behind <strong>Hunkem&ouml;ller</strong>  take your confidence levels up to a 100 with their range of flirty", null, "", null, "Hunkemoller", null, "hunkemoller", null },
                    { 330, 16696L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9158), "Combining luxury aesthetic with traditional touches and cutting-edge design, <strong>Valentino Bags</strong> is on hand to give your carryall line-up a serious upgrade with its latest sel", null, "", null, "Valentino Bags", null, "valentino-bags", null },
                    { 331, 15902L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9160), "Get ready to go out-out with <strong>SIMMI Shoes</strong>’s offering of the latest footwear and clothing. Created with a trailblazer in mind, the brand’s designs are unapologetically bold – ", null, "", null, "SIMMI Shoes", null, "simmi-shoes", null },
                    { 332, 22505L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9161), "", null, "", null, "IIQUAL", null, "iiqual", null },
                    { 333, 20702L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9163), "Be the moment in colour-poppin’ brand Easy Tiger. ICYDK, it’s *the* destination for statement styles that give festival szn meets 70s groove. Get browsing our Easy Tiger at ASOS edit for brightly printed sets complete with bikinis and matching sarongs", null, "", null, "Easy Tiger", null, "easy-tiger", null },
                    { 334, 22305L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9164), "In the mood for a major beachwear moment? Then dip your toe into our It’s Now Cool at ASOS edit. Featuring 90s-inspired swimwear (read: high-cut legs), the label’s offering is bound to up the envy-inducing levels. Scroll bikini tops finished in bold p", null, "", null, "It’s Now Cool", null, "it’s-now-cool", null },
                    { 335, 16322L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9166), "From its humble beginnings at London’s Portobello Road market, <strong>Never Fully Dressed Plus</strong> has grown into a brand known for classic clean lines and flattering silhoue", null, "", null, "Never Fully Dressed Plus", null, "never-fully-dressed-plus", null },
                    { 336, 13942L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9167), "If standing out from the crowd’s your thing, stand out in <strong>The Ragged Priest</strong>. Designed and made in the UK, the brand’s bold selection of striped, neon and tie-dye d", null, "", null, "The Ragged Priest", null, "the-ragged-priest", null },
                    { 337, 16269L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9169), "", null, "", null, "Cotton:On", null, "cotton:on", null },
                    { 338, 18653L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9171), "Say hello to <strong>JJXX</strong> – newest member of the Jack & Jones fam. Celebrating all things denim, the brand channels 30 years of experience into empowering women with quality essentials f", null, "", null, "JJXX", null, "jjxx", null },
                    { 339, 15900L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9172), "Love dressing for yourself and nobody else? <strong>In The Style</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an excuse ", null, "", null, "In The Style", null, "in-the-style", null },
                    { 340, 13073L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9174), "The <strong>Lyle & Scott</strong> range balances an old school 80s attitude with preppy styling and laid-back collegiate cool. Sweatshirts and joggers bring a relaxed yet stylish attitu", null, "", null, "Lyle & Scott", null, "lyle-&-scott", null },
                    { 341, 16191L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9175), "Love dressing for yourself and nobody else? <strong>In The Style Plus</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an ex", null, "", null, "In The Style Plus", null, "in-the-style-plus", null },
                    { 342, 14164L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9177), "The guys behind <strong>SikSilk</strong> are obsessed with American, Japanese and Brit street culture. OK, so that’s quite a lot of influences, but it all makes sense when you see it distilled ", null, "", null, "SikSilk", null, "siksilk", null },
                    { 343, 15828L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9178), "Let’s be honest, we all love a bit of Scandi style. That’s why we’ve put together an edit of Danish high-street brand <strong>ONLY Tall</strong> freshest pieces, including classic denim cuts,", null, "", null, "ONLY Tall", null, "only-tall", null },
                    { 344, 15685L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9180), "Searching for shoes that will take your wedding-day look from aisle-to-dancefloor? <strong>Be Mine</strong> is here to tick one thing off your list, so you can focus on the ‘I do’ instead of", null, "", null, "Be Mine", null, "be-mine", null },
                    { 345, 13214L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9181), "<strong>Marshall Artist</strong> was founded in 2000 and has fast developed a reputation as being one of the most eclectic and best loved new menswear labels. Known for creating modern, ta", null, "", null, "Marshall Artist", null, "marshall-artist", null },
                    { 346, 16650L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9183), "If you need an excuse for a wardrobe update, <strong>HUGO Bodywear</strong> is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it comes to quality de", null, "", null, "HUGO Bodywear", null, "hugo-bodywear", null },
                    { 347, 17650L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9184), "The authority on fresh handmade cosmetics, <strong>LUSH</strong> serves up sweet-smelling hair, body and skincare goodies for your self-care shelf (not that they’ll spend much time on i", null, "", null, "LUSH", null, "lush", null },
                    { 348, 13727L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9186), "", null, "", null, "Malin + Goetz", null, "malin-+-goetz", null },
                    { 349, 13886L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9187), "Designing and producing a covetable collection of day to night dresses in the heart of London, <strong>Closet London</strong> transcends seasons to bring you fashion-forward pieces that will alwa", null, "", null, "Closet London", null, "closet-london", null },
                    { 350, 13644L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9189), "With a classic history of the American dream come to life, <strong>47 Brand</strong> was founded by twin brothers Arthur and Henry D'Angelo, who arrived in Boston from Italy and witnessed the pas", null, "", null, "47 Brand", null, "47-brand", null },
                    { 351, 16724L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9218), "Founded by Mona Kattan, <strong>KAYALI</strong> (Arabic for ‘my imagination’) brings a collection of intoxicating fragrances inspired by her Middle Eastern heritage. The brand’s perfumes ar", null, "", null, "KAYALI", null, "kayali", null },
                    { 352, 22155L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9220), "Let your fragrance do the talking with perfume brand Floral Street. Searching for a selection of high-impact aromas that’ll kit out your fragrance ‘drobe? Shop our Floral Street at ASOS edit and expect flower-inspired scents ft. notes of citrus and ea", null, "", null, "Floral Street", null, "floral-street", null },
                    { 353, 62062L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9222), "Introducing: <strong>Messy Weekend</strong>. Serving sunny essentials to elevate your accessories line-up, shop the brand’s sunglasses and caps that are *giving* sensible-yet-stylish sun", null, "", null, "Messy Weekend", null, "messy-weekend", null },
                    { 354, 13652L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9223), "<strong>HUF</strong> owner Keith Hufnagel grew up skateboarding in the streets of New York before moving to San Francisco to pursue his passion.  Opening his first store in 2002, ... ", null, "", null, "HUF", null, "huf", null },
                    { 355, 20612L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9225), "ICYDK, Narciso Rodriguez isn’t just a fashion-industry icon, he also creates fragrances that will have your current faves nervous. With perfumes For Him and For Her the brand celebrates masculinity and femininity through its floral and woody scents. Scr", null, "", null, "Narciso Rodriguez", null, "narciso-rodriguez", null },
                    { 356, 14379L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9226), "A BATHING APE launched its brand new diffusion line, <strong>AAPE BY A BATHING APE®</strong> (Aape for short), in 2012 with the aim to create a collection of simple, light clothes for everyday wear.", null, "", null, "AAPE BY A BATHING APE®", null, "aape-by-a-bathing-ape®", null },
                    { 357, 3008L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9228), "In 1973, <strong>Billabong</strong> founders Gordon and Rena Merchant started crafting and selling board shorts to surf shops on Australia’s Gold Coast. Thanks to the durable, triple-stitchin", null, "", null, "Billabong", null, "billabong", null },
                    { 358, 16592L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9229), "High-street hero <strong>River Island Tall</strong> covers all bases with its selection of clothing, accessories, swimwear and footwear. Offering everything from standout party dresses and ", null, "", null, "River Island Tall", null, "river-island-tall", null },
                    { 359, 21000L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9231), "Give your coils the care they crave with <strong>Curlsmith</strong>. Packed full of superfoods (think almond oil, blackcurrants and mashed avocados), our ... ", null, "", null, "Curlsmith", null, "curlsmith", null },
                    { 360, 16547L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9232), "", null, "", null, "Living Proof", null, "living-proof", null },
                    { 361, 21755L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9234), "Give your strands some TLC with ARKIVE. Featuring products to care for your head and style those locks, what more could you want? Scroll cleansing shampoos and nourishing conditioners to say goodbye to bad hair days, or filter by hairspray to lock-in your", null, "", null, "ARKIVE", null, "arkive", null },
                    { 362, 2994L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9235), "It’s no surprise that <strong>ghd</strong> stands for ‘Good Hair Day’, with its first styler making major waves in the hair-styling scene back in 2001. As an official stockist, our ... ", null, "", null, "ghd", null, "ghd", null },
                    { 363, 18904L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9237), "Switch to effective, fuss-free makeup removal with <strong>Face Halo</strong>. You won’t need to rub, scrub or use soap thanks to ultra-fine fibres that help trap makeup and reach ", null, "", null, "Face Halo", null, "face-halo", null },
                    { 364, 14291L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9238), "It’s time to power up your self-care routine – snap up award-winning skincare devices and products from our <strong>Foreo</strong> at ASOS edit. From gentle Micro-Foam cleansers and dee", null, "", null, "Foreo", null, "foreo", null },
                    { 365, 15741L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9239), "", null, "", null, "Sand & Sky", null, "sand-&-sky", null },
                    { 366, 15919L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9241), "Making its ASOS debut – if we could roll out a red carpet, we would – <strong>Estee Lauder</strong> multi-award-winning skin care and makeup is about to take up all the space ", null, "", null, "Estee Lauder", null, "estee-lauder", null },
                    { 367, 15247L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9242), "", null, "", null, "The Ordinary", null, "the-ordinary", null },
                    { 368, 16585L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9244), "Get ready to go out-out with <strong>Simmi Wide Fit</strong>’s offering of the latest footwear and clothing. Created with a trailblazer in mind, the brand’s designs are unapologetically bold ", null, "", null, "Simmi Wide Fit", null, "simmi-wide-fit", null },
                    { 369, 16114L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9245), "Created in 2013 around the founder’s kitchen table,&nbsp;<strong>Revolution Skincare</strong>&nbsp;is committed to making vegan makeup and skincare that’s accessible to all. You", null, "", null, "Revolution Skincare", null, "revolution-skincare", null },
                    { 370, 2955L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9247), "Founded more than 20 years ago by Sara Blakely with nothing but a pair of footless tights, <strong>Spanx</strong> shapewear revolutionised the industry with its body-sculpting collection. Having ga", null, "", null, "Spanx", null, "spanx", null },
                    { 371, 13987L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9248), "Putting a clean twist on everyday essentials, Danish label <strong>Y.A.S</strong> packs its understated-cool style into dresses, premium leather and tailored pieces. Think minimalist designs paired ", null, "", null, "Y.A.S", null, "y.a.s", null },
                    { 372, 13943L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9250), "<strong>Lavish Alice</strong> represents directional design with a bold signature. Cut to enhance the silhouette and heighten the body, capes, asymmetry, cutaway details and a clean, minima", null, "", null, "Lavish Alice", null, "lavish-alice", null },
                    { 373, 16204L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9251), "Question: what’s timeless, chic and always IG-ready? Our <strong>Pretty Lavish</strong> at ASOS edit, ofc. Shop midi skirts and tops in soft knits and sequin finishes, plus printed dress", null, "", null, "Pretty Lavish", null, "pretty-lavish", null },
                    { 374, 16710L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9253), "Get ready to go out-out with <strong>Simmi Clothing</strong>’s offering of the latest footwear and clothing. Created with a trailblazer in mind, the brand’s designs are unapologetically bold ", null, "", null, "Simmi Clothing", null, "simmi-clothing", null },
                    { 375, 16638L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9254), "RSVPd yes but don’t know what to wear yet? Don’t worry, <strong>Collective the Label Curve</strong> has got your back. The dressed-up sister brand of Glamorous, it's big on occa", null, "", null, "Collective the Label Curve", null, "collective-the-label-curve", null },
                    { 376, 16308L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9256), "Introducing <strong>Topshop Tall</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stopping by ", null, "", null, "Topshop Tall", null, "topshop-tall", null },
                    { 377, 14304L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9257), "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda Petite</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety ", null, "", null, "Vero Moda Petite", null, "vero-moda-petite", null },
                    { 378, 16487L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9259), "", null, "", null, "Urban Threads Petite", null, "urban-threads-petite", null },
                    { 379, 15395L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9260), "", null, "", null, "Heartbreak", null, "heartbreak", null },
                    { 380, 20611L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9261), "", null, "", null, "Night Addict Plus", null, "night-addict-plus", null },
                    { 381, 15910L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9263), "", null, "", null, "Influence Maternity", null, "influence-maternity", null },
                    { 382, 14457L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9264), "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda Tall</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety of", null, "", null, "Vero Moda Tall", null, "vero-moda-tall", null },
                    { 383, 3606L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9266), "London-based label <strong>Whistles</strong> is a firm ASOS favourite. The brand’s collections pair clean silhouettes with premium fabrics, while relaxed fits keep things chill – think print", null, "", null, "Whistles", null, "whistles", null },
                    { 384, 62550L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9267), "", null, "", null, "Hugo Red", null, "hugo-red", null },
                    { 385, 12090L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9269), "BOSS offers an authentic and understated wardrobe for the modern man. Crafted from super-soft fabrics, BOSS bodywear, loungewear and accessory collections offer ultimate comfort and enduring style.", null, "", null, "BOSS Orange", null, "boss-orange", null },
                    { 386, 3454L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9270), "With roots back to the ‘70s, the <strong>Free People</strong> girl lives through art, fashion, music and wanderlust. She’s feminine in spirit and Bohemian in attitude. From sweet to tough", null, "", null, "Free People", null, "free-people", null },
                    { 387, 443L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9272), "After graduating from Parsons School of Design, <strong>Marc Jacobs</strong> founded his eponymous label in 1984. Loved for his retro-inspired cool, it has since become a go-t", null, "", null, "Marc Jacobs", null, "marc-jacobs", null },
                    { 388, 15224L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9273), "A brand that’s all about healthy and happy skin, <strong>Dermalogica</strong> is used by skin therapists all over the world. Offering professional-grade products, the brand achie", null, "", null, "Dermalogica", null, "dermalogica", null },
                    { 389, 21169L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9274), "Founded by the Graah family in 2004, iconic Swedish brand <strong>Dr Denim Plus</strong> are famed for their skinny jeans and simple Scandinavian styling. Branching out with a collection of jers", null, "", null, "Dr Denim Plus", null, "dr-denim-plus", null },
                    { 390, 15739L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9276), "Formulating a range of sheet masks developed specifically for men, <strong>Barber Pro</strong> gives your razor-and-face-cream regime a serious overhaul. The brand’s peel-off putty and foamin", null, "", null, "Barber Pro", null, "barber-pro", null },
                    { 391, 22355L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9277), "", null, "", null, "Dsquared", null, "dsquared", null },
                    { 392, 22757L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9279), "Attention accessory lovers, Petit Moments has landed. Featuring trend-led designs to make any jewellery box jealous, the label’s offering will sit pride of place in your ‘fit. Scroll crush-worthy necklaces in a range of tones – or shop hoop and drop", null, "", null, "Petit Moments", null, "petit-moments", null },
                    { 393, 16683L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9306), "Dreaming of an effortlessly chic capsule wardrobe? Extro & Vert has got you covered. Specialising in modern tailoring, the brand serves up minimal designs with maximum impact. Expect oversized blazers and relaxed trousers, or mix-and-match with polished s", null, "", null, "Extro & Vert", null, "extro-&-vert", null },
                    { 394, 16144L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9308), "Let’s be honest, we all love a bit of Scandi style. That’s why we’ve put together an edit of Danish high-street brand <strong>ONLY Curve</strong> freshest pieces, including classic denim cuts", null, "", null, "ONLY Curve", null, "only-curve", null },
                    { 395, 22657L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9310), "London-based label <strong>Whistles Petite</strong> is a firm ASOS favourite. The brand’s collections pair clean silhouettes with premium fabrics, while relaxed fits keep things chill – thin", null, "", null, "Whistles Petite", null, "whistles-petite", null },
                    { 396, 16307L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9311), "Introducing <strong>Topshop Petite</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stopping b", null, "", null, "Topshop Petite", null, "topshop-petite", null },
                    { 397, 16394L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9313), "Give your wardrobe that main-feed treatment with <strong>I Saw It First</strong>. Scroll the brand’s range of bodycon party dresses, faux-leather trousers and embellished tops for the u", null, "", null, "I Saw It First", null, "i-saw-it-first", null },
                    { 398, 479L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9314), "Founded in 1968 by sisters Jocelyn Bismuth and Odette Barouch, French label <strong>Morgan</strong> opened its first store in Paris’ 6th arrondissement. Known for its ready-to-wear collections, ", null, "", null, "Morgan", null, "morgan", null },
                    { 399, 14230L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9316), "The Aussie boys behind <strong>Uppercut Deluxe</strong> are such big fans of the traditional barber experience they decided to create their own at home. So that’s a complete range of hai", null, "", null, "Uppercut Deluxe", null, "uppercut-deluxe", null },
                    { 400, 3352L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9317), "Reviving and replicating footwear legends, <strong>Clarks Originals</strong> laid-back shoes and boots look to authenticity and individuality. Desert boots, wallabee shoes and hiking boots", null, "", null, "Clarks Originals", null, "clarks-originals", null },
                    { 401, 13579L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9319), "Creating a snappy range of fashion eyewear and sunglasses, American label <strong>AJ Morgan</strong> has seen its lenses appear in cult films and television series such as, Demolition Man, Bev", null, "", null, "AJ Morgan", null, "aj-morgan", null },
                    { 402, 673L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9320), "London-based label <strong> Spitfire</strong>  has garnered a cult following with its cutting-edge eyewear, featuring imaginative style details such as removable UV l", null, "", null, "Spitfire", null, "spitfire", null },
                    { 403, 16434L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9322), "", null, "", null, "Labelrail", null, "labelrail", null },
                    { 404, 12456L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9323), "Founded in 2009 by Liam Gallagher, <strong>Pretty Green</strong> has a deep understanding of British street culture. Named after a track by The Jam, it unites music and fashion, giving simple,", null, "", null, "Pretty Green", null, "pretty-green", null },
                    { 405, 15488L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9325), "Launching a line of golf clothing and accessories, <strong>Calvin Klein Golf</strong> brings its modern-minimalist aesthetic to the fairways. Whatever the weather, get your gear up to par with", null, "", null, "Calvin Klein Golf", null, "calvin-klein-golf", null },
                    { 406, 17952L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9326), "With its Scandinavian roots and minimalist styling, <strong>Pieces Plus</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand tie", null, "", null, "Pieces Plus", null, "pieces-plus", null },
                    { 407, 62400L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9329), "", null, "", null, "Milk Makeup", null, "milk-makeup", null },
                    { 408, 3498L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9330), "In 1976, sisters Jean and Jane Ford flipped a coin – heads they opened a deli, tails they opened a makeup store. It landed on tails, so they set up shop in San Francisco and launched whimsical cosmetics brand ... ", null, "", null, "Benefit", null, "benefit", null },
                    { 409, 15020L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9332), "Specialising in all things you didn’t know you wanted, accessory brand <strong>Kitsch</strong> designs everything from hair accessories to sleep aids and skincare tools. Stock up on hair bits l", null, "", null, "Kitsch", null, "kitsch", null },
                    { 410, 17900L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9333), "Say hello to streetwear brand <strong>Urban Classics</strong>. The label is home to a collection of no effort, effort makers perfect for those laid-back moods. Start from the bottom with trouse", null, "", null, "Urban Classics", null, "urban-classics", null },
                    { 411, 14821L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9335), "Prom queens and wedding guests, claim the best-dressed title in <strong>Hope & Ivy</strong> occasion-ready collection. Shop its notice-me styles for hand-painted florals, Bardot necklines a", null, "", null, "Hope & Ivy", null, "hope-&-ivy", null },
                    { 412, 15672L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9336), "With a focus on quality craftsmanship and impeccable design, the <strong>BOSS Athleisure</strong> collection offers a premium range of tailoring, athleisure and refined casualwear. Expect tailored se", null, "", null, "BOSS Athleisure", null, "boss-athleisure", null },
                    { 413, 13991L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9338), "<strong>JDY</strong> collection here at ASOS is a bit of us, and we think it’ll be a bit of you, too. Mix and match its dreamy denim skirts and jeans with trusty jersey pieces, or snap up an entir", null, "", null, "JDY", null, "jdy", null },
                    { 414, 202L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9339), "Founded in 1911 by brothers in Biella, Italy, <strong>Fila</strong> packs more than 100 years of heritage into its collections. Championed throughout the 80s before becoming streetwear history, its", null, "", null, "Fila", null, "fila", null },
                    { 415, 12092L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9341), "<strong>BOSS Orange</strong> is the laid-back, easy-going side of HUGO BOSS. Fusing craft with signature design, ... ", null, "", null, "BOSS Green", null, "boss-green", null },
                    { 416, 14564L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9342), "<strong>Object</strong> is one of those clothing brands that everyone can get in on. Its mixture of boho styles and minimal designs serve up that casual-cool vibe we all know and love. Think pret", null, "", null, "Object", null, "object", null },
                    { 417, 15000L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9343), "Branded ‘the Godfather of modern day pinstriping’, <strong>Von Dutch</strong>, AKA Kenneth Howard, first started out blasting motorbikes and cars with iconic Americana imagery. Fast forward ", null, "", null, "Von Dutch", null, "von-dutch", null },
                    { 418, 16506L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9345), "<strong>Charlotte Tilbury</strong> is a pretty huge deal. With over 27 years’ experience in the beauty industry (major), the world-famous British makeup artist’s namesake", null, "", null, "Charlotte Tilbury", null, "charlotte-tilbury", null },
                    { 419, 15973L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9346), "Combining the latest in Korean skincare technology, <strong>Dr.Jart+</strong> is all about results-driven products that work hard for different skin needs. Browse the brand’s cleanse", null, "", null, "Dr.Jart+", null, "dr.jart+", null },
                    { 420, 20201L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9348), "With timeless collections that are easy-to-wear *and* focused on personal style, we’re saying <strong>The Frolic</strong> FTW – and we mean it. The Aussie boutique stocks a range of top-tier st", null, "", null, "The Frolic", null, "the-frolic", null },
                    { 421, 16525L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9349), "Minimalism just got an update with Scandi clothing brand <strong>Annorlunda</strong>. Serving up a fresh slice of street-style inspiration, the brand’s collections are all about staple piec", null, "", null, "Annorlunda", null, "annorlunda", null },
                    { 422, 20300L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9351), "", null, "", null, "Threadbare Plus Fitness", null, "threadbare-plus-fitness", null },
                    { 423, 16097L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9352), "RSVPd yes but don’t know what to wear yet? Don’t worry, <strong>Collective The Label</strong> has got your back. The dressed-up sister brand of Glamorous, it's big on occasionwe", null, "", null, "Collective The Label", null, "collective-the-label", null },
                    { 424, 62058L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9355), "PSA: we’ve got your statement styles sorted all thanks to LA jewellery brand <strong>Girls Crew</strong>. It’s got creativity on lock with necklaces, rings and anklets that’ll add a lil", null, "", null, "Girls Crew", null, "girls-crew", null },
                    { 425, 17857L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9356), "", null, "", null, "Mario Badescu", null, "mario-badescu", null },
                    { 426, 16412L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9357), "RSVPd yes but don’t know what to wear yet? Don’t worry, <strong>Collective The Label Petite</strong> has got your back. The dressed-up sister brand of Glamorous, it's big on occ", null, "", null, "Collective The Label Petite", null, "collective-the-label-petite", null },
                    { 427, 15668L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9360), "Bringing you longer-lasting, glossier manicures, <strong>Le Mini Macaron</strong> takes your nail game up a notch with its gel-manicure kits. Designed to look like the sugary-sweet treat", null, "", null, "Le Mini Macaron", null, "le-mini-macaron", null },
                    { 428, 14730L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9362), "", null, "", null, "Noak", null, "noak", null },
                    { 429, 13891L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9363), "Whatever your plans, <strong>South Beach</strong> have the ‘fits. After a beach-day look that delivers from head-to-toe? Scroll the brand’s hats, sunglasses and sandals – perfect for p", null, "", null, "South Beach", null, "south-beach", null },
                    { 430, 15921L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9365), "With a rich heritage dating back to 1894, quintessentially British brand, <strong>Barbour Beacon</strong> have garnered a reputation for quality and durability, across their collection of high per", null, "", null, "Barbour Beacon", null, "barbour-beacon", null },
                    { 431, 274L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9366), "Born in 1962, Brazilian label <strong>Havaianas</strong> are famed for their world renowned flip flops. Representing Brazilian values of simplicity, optimism, energy and colour, ... ", null, "", null, "Havaianas", null, "havaianas", null },
                    { 432, 16530L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9368), "After some new beachwear for your next trip? <strong>Esmée</strong> has a range of relaxed options for when it’s extra hot. For something to throw on over your bikini, browse the brand’s mini ", null, "", null, "Esmée", null, "esmée", null },
                    { 433, 16243L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9369), "Fix up and look sharp with <strong>Viggo</strong> range of standout formalwear. Taking a bolder stance on Scandi style, the brand creates a range of modern, refreshing and bright tailoring for your ", null, "", null, "Viggo", null, "viggo", null },
                    { 434, 14139L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9371), "With Neil Armstrong et al. in mind, Giancarlo Zanatta launched his lunar-inspired footwear label, <strong>Moon Boot</strong>, in the 70s – taking one giant leap for winter footwear. Turning", null, "", null, "Moon Boot", null, "moon-boot", null },
                    { 435, 62412L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9372), "Show your locks some love with our <strong>Drybar</strong> at ASOS edit. Ft. haircare heroes to bless your blow-dry, the brand has just the stuff to style your strands. Shop hair tools", null, "", null, "Drybar", null, "drybar", null },
                    { 436, 62406L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9397), "Launching in 2015 with her i-c-o-n-i-c lip kits, makeup mogul and insta royalty Kylie Jenner knows a thing or two about the makeup game. With a Jenner-ous range of products to choose from, scroll our ... ", null, "", null, "Kylie Cosmetics by Kylie Jenner", null, "kylie-cosmetics-by-kylie-jenner", null },
                    { 437, 21857L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9399), "POV: You’ve found Neutrogena and are never going back. Whether it’s a *major* self-care shelf restock or a daily product upgrade, browse our <strong>Neutrogena</strong> at ASOS ", null, "", null, "Neutrogena", null, "neutrogena", null },
                    { 438, 16636L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9400), "", null, "", null, "Threadbare Maternity", null, "threadbare-maternity", null },
                    { 439, 14345L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9402), "With one eye firmly on the catwalk <strong>Bardot</strong> owns the latest trends. Soaked in Aussie sunshine, these guys crop it like it’s hot in camis and printed bralets, scuba skater skirts ", null, "", null, "Bardot", null, "bardot", null },
                    { 440, 17852L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9404), "Love dressing for yourself and nobody else? <strong>In The Style Petite</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an ", null, "", null, "In The Style Petite", null, "in-the-style-petite", null },
                    { 441, 17858L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9406), "Love dressing for yourself and nobody else? <strong>In The Style Tall</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an ex", null, "", null, "In The Style Tall", null, "in-the-style-tall", null },
                    { 442, 62051L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9409), "We’re falling head over heels for our Circus NY at ASOS edit. Featuring a range of trend-led and bold designs, we’re finding the brand hard to scroll past TBH. Shop mules when you want to slip-in to style – or browse the label’s collection of chun", null, "", null, "Circus NY", null, "circus-ny", null },
                    { 443, 22706L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9411), "", null, "", null, "Good News", null, "good-news", null },
                    { 444, 16016L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9412), "Brides-to-be, assemble – <strong>Anaya</strong> has officially joined our ranks. The sister brand of occasionwear label Maya, its pastel-toned collection of tulle maxi dresses and co-o", null, "", null, "Anaya", null, "anaya", null },
                    { 445, 16007L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9414), "The people behind Candypants have turned their attention from throwing the hottest parties in town (we know, best job ever, right?) to ticking off everything you’ll need to make waves on your next sea-and-sand adventure. From swimsuits to bikinis, cover", null, "", null, "Candypants", null, "candypants", null },
                    { 446, 16587L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9415), "", null, "", null, "Anaya Tall", null, "anaya-tall", null },
                    { 447, 21150L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9416), "", null, "", null, "Closet London Tall", null, "closet-london-tall", null },
                    { 448, 16400L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9418), "Brides-to-be, assemble – <strong>Anaya Petite</strong> has officially joined our ranks. The sister brand of occasionwear label Maya, its pastel-toned collection of tulle maxi dresses a", null, "", null, "Anaya Petite", null, "anaya-petite", null },
                    { 449, 20502L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9419), "Designed for the bold, the glam and the fashion-forward, look to Naked Wardrobe for pieces that are so good you’ll want to gatekeep. With bodycon, the vibe running through our Naked Wardrobe at ASOS edit, expect sleek mini and midi dresses in slinky fab", null, "", null, "Naked Wardrobe", null, "naked-wardrobe", null },
                    { 450, 14688L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9421), "Here to make light work of your mane, <strong>Babyliss</strong> has been leading the hair game for more than 50 years. With tools designed for all hair types, it’s never been easier to", null, "", null, "Babyliss", null, "babyliss", null },
                    { 451, 14041L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9422), "Surf at daybreak and skate ‘til sunset? Then you’ll be into accessories brand <strong>Classics 77</strong>, who take their inspiration from the continued search for freedom and the dream o", null, "", null, "Classics 77", null, "classics-77", null },
                    { 452, 16565L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9424), "Fresh on the streetwear scene, London-based label <strong>ASOS Dark Future</strong> brings a hint of minimalism to its collection of relaxed urban staples. With a considered colour palett", null, "", null, "ASOS Dark Future", null, "asos-dark-future", null },
                    { 453, 19952L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9425), "Say goodbye to skincare worries and hello to your new fave K-beauty brand <strong>COSRX</strong>. All about simplicity, the label uses minimal yet effective ingredients to serve all skin", null, "", null, "COSRX", null, "cosrx", null },
                    { 454, 15295L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9426), "<strong>Frank Body's</strong> Australian made and owned, coffee-based skincare range rubs you the right way, targeting problematic skin conditions and damaging free radicals. Made from n", null, "", null, "frank body", null, "frank-body", null },
                    { 455, 15957L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9428), "Well, this is exciting. We’ve teamed up with award-winning London perfumery <strong>Shay & Blue</strong> and put together an edit of its dreamy, unisex fragrances, including a ", null, "", null, "Shay & Blue", null, "shay-&-blue", null },
                    { 456, 3018L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9431), "<strong>Rimmel London</strong> has been re-writing the rules of makeup since 1834, helping you express yourself however you choose. Founded by Eugène Rimmel – aka, the man who practical", null, "", null, "Rimmel London", null, "rimmel-london", null },
                    { 457, 13852L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9432), "New York label <strong>Chelsea Peers</strong> brings us a brilliant range of our latest loungewear obsession- onesies. All-American with a prep-inspired look, ... ", null, "", null, "Chelsea Peers", null, "chelsea-peers", null },
                    { 458, 15753L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9434), "Footwear brand <strong>Raid Wide Fit</strong> loves shoes so much that its collection covers every style you could think of — and for that, we're eternally grateful. Expect classic Chelsea boots,", null, "", null, "Raid Wide Fit", null, "raid-wide-fit", null },
                    { 459, 21350L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9435), "", null, "", null, "Coola", null, "coola", null },
                    { 460, 23105L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9440), "POV: you’re on the journey from being newly engaged to newlywed and <strong>Six Stories</strong> is your wedding BFF. Expect dreamy bridesmaid dresses for your besties and pyjamas that’l", null, "", null, "Six Stories", null, "six-stories", null },
                    { 461, 18250L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9441), "Warning: this is a knot-free zone. Swerve the stress of messy hair and cop yourself a top-drawer detangler from hair-care brand <strong>WetBrush</strong>. Bringing tangle-free tresses", null, "", null, "WetBrush", null, "wetbrush", null },
                    { 462, 15390L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9443), "<strong>OUAI</strong> believes that good hair starts from within. Thanks to its MD-formulated supplements restoring hair health from the inside, and shampoos, conditioners and styling products that nouri", null, "", null, "OUAI", null, "ouai", null },
                    { 463, 20600L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9444), "Introducing <strong>Topshop Curve</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stopping by", null, "", null, "Topshop Curve", null, "topshop-curve", null },
                    { 464, 15010L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9446), "", null, "", null, "Office", null, "office", null },
                    { 465, 66L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9447), "Born in the 80s,&nbsp;<strong>Barry M</strong>&nbsp;has been a leader in&nbsp;the&nbsp;bold-makeup&nbsp;scene&nbsp;since the start.&nbsp;From market stall to mainstream, the brand’s made the m", null, "", null, "Barry M", null, "barry-m", null },
                    { 466, 14884L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9448), "Named after the Greek goddess who ruled the night, <strong>NYX Professional Makeup</strong> combines beauty and power. Rich pigments, long-lasting formulas and a fun approach to colour help y", null, "", null, "NYX Professional Makeup", null, "nyx-professional-makeup", null },
                    { 467, 16719L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9450), "", null, "", null, "Huda Beauty", null, "huda-beauty", null },
                    { 468, 16498L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9452), "Creating simple and effective solutions for all hair types, discover <strong>Beauty Works</strong> range of products and tools, designed to help style, protect and restore your lo", null, "", null, "Beauty Works", null, "beauty-works", null },
                    { 469, 18800L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9453), "Founded by *the* expert in ‘perfectly imperfect’ hair, <strong>Kristin Ess</strong> is big on products that protect your strands from the inside out. Manage your mane with", null, "", null, "Kristin Ess", null, "kristin-ess", null },
                    { 470, 13844L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9455), "Since setting up shop in the 60s, <strong>New Look Plus</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ", null, "", null, "New Look Plus", null, "new-look-plus", null },
                    { 471, 16391L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9457), "Founded in 2017, <strong>Femme Luxe</strong> is big on bold, fresh fashion. Based in Manchester, the brand’s trend-led range brings glitter, glamour and standout styling to your wardrobe ", null, "", null, "Femme Luxe", null, "femme-luxe", null },
                    { 472, 16443L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9458), "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May Curve</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, ra", null, "", null, "Noisy May Curve", null, "noisy-may-curve", null },
                    { 473, 16634L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9460), "Seeking inspiration from street and city style, Danish label <strong>Vila Curve</strong> combine quality fabrics, textures and delicate cuts to create fashion-forward garments. Intricate feminine de", null, "", null, "Vila Curve", null, "vila-curve", null },
                    { 474, 16232L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9461), "One of the oldest cosmetics companies in the world, <strong>Shiseido</strong> boasts over 145 years of Japanese beauty experience. Skip to the best bits with our ... ", null, "", null, "Shiseido", null, "shiseido", null },
                    { 475, 16537L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9463), "", null, "", null, "Threadbare Tall", null, "threadbare-tall", null },
                    { 476, 15169L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9465), "", null, "", null, "ASOS MADE IN", null, "asos-made-in", null },
                    { 477, 16047L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9466), "Founded in 1985, all-American brand <strong>Tommy Hilfiger Sport</strong> is best known for its preppy vibe and iconic red, white and blue logo. Branching out, the brand has stepped up it", null, "", null, "Tommy Hilfiger Sport", null, "tommy-hilfiger-sport", null },
                    { 478, 16470L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9468), "Created in 2013 around the founder’s kitchen table, <strong>I Heart Revolution</strong> is committed to making makeup and skincare that’s accessible to all. You’ll have to be ", null, "", null, "I Heart Revolution", null, "i-heart-revolution", null },
                    { 479, 16398L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9494), "Brides-to-be, assemble – <strong>Anaya Plus</strong> has officially joined our ranks. The sister brand of occasionwear label Maya, its pastel-toned collection of tulle maxi dresses and", null, "", null, "Anaya Plus", null, "anaya-plus", null },
                    { 480, 259L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9496), "Founded in 1981 by the Marciano brothers, <strong>Guess</strong> started out redefining denim with a selection of slim-fit stonewash jeans before adding watches and footwear to its range. Guess Conne", null, "", null, "Guess", null, "guess", null },
                    { 481, 18052L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9497), "<strong>Madewell</strong> stylosophy? All good days start with great jeans. Best known for its top-tier timeless denim, the all-American clothing brand is big on the classics. Our ... ", null, "", null, "Madewell", null, "madewell", null },
                    { 482, 16553L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9499), "", null, "", null, "Cetaphil", null, "cetaphil", null },
                    { 483, 16128L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9500), "Whatever the occasion, <strong>New Girl Order</strong> specialises in all things bold and daring with its personality-packed collection. We&rsquo;ve pulled together some of our favourite ", null, "", null, "New Girl Order Curve", null, "new-girl-order-curve", null },
                    { 484, 17951L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9502), "With its Scandinavian roots and minimalist styling, <strong>Pieces Petite</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand t", null, "", null, "Pieces Petite", null, "pieces-petite", null },
                    { 485, 15145L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9503), "Footwear brand <strong>Raid</strong> loves shoes so much that its collection covers every style you could think of — and for that, we're eternally grateful. Expect classic Chelsea boots, slick lo", null, "", null, "Raid", null, "raid", null },
                    { 486, 21557L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9505), "ICYMI, Coney Island Picnic is here to supply your casj line up with some fresh ‘fits. Its designers take inspo from vintage athletics and future ideologies to create garms that’ll level up your low-key looks. Expect T-shirts, hoodies and sweatshirts t", null, "", null, "Coney Island Picnic", null, "coney-island-picnic", null },
                    { 487, 3192L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9506), "Brit brand <strong>this works</strong> knows that your skin goes through a lot. Formulated with a ‘Superblend’ of natural ingredients, its award-winning range of products work with", null, "", null, "this works", null, "this-works", null },
                    { 488, 3212L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9508), "Italy really is home to a few of our favourite things – pizza, pasta and, of course, <strong>Superga</strong>. More than 100 years old, the brand gives its classic creps a fresh-as update with ", null, "", null, "Superga", null, "superga", null },
                    { 489, 13685L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9509), "PSA: elevating your slope style couldn’t be easier with clothing brand <strong>Protest</strong>. Dutch-founded, the label serves up cold-weather gear to keep your ‘fit looking sub-zero – in ", null, "", null, "Protest", null, "protest", null },
                    { 490, 17L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9511), "<strong>adidas</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ", null, "", null, "adidas", null, "adidas", null },
                    { 491, 21559L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9512), "Here’s the sitch: you found the perfect ‘fit, but forgot the all-important base layer. Enter, Bye Bra. Serving shapewear and underwear in a wide range of sizes and skin tones, our Bye Bra at ASOS edit has a solution for every occasion. We’re talking", null, "", null, "Bye Bra", null, "bye-bra", null },
                    { 492, 20500L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9514), "", null, "", null, "Chelsea Peers Tall", null, "chelsea-peers-tall", null },
                    { 493, 20454L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9517), "", null, "", null, "Chelsea Peers Petite", null, "chelsea-peers-petite", null },
                    { 494, 14544L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9519), "Bringing pawpaw to British shores, <strong>Dr. PAWPAW</strong> unveil their multi-use balm that&rsquo;s packed with effective natural ingredients &ndash; think fermente", null, "", null, "Dr Paw Paw", null, "dr-paw-paw", null },
                    { 495, 3190L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9520), "Trading on its ethos of natural beauty, <strong>Pixi</strong> makeup and skin-care line combines innovative formulas with skin-loving properties. With over 20 years in the cosmetics industry, makeu", null, "", null, "Pixi", null, "pixi", null },
                    { 496, 20501L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9522), "Whether you’re after a wardrobe refresh or just a few staples,&nbsp;<strong>Vero Moda Maternity</strong>&nbsp;serves big outfit energy. Scroll for your new favourite pair of jeans, available ", null, "", null, "Vero Moda Maternity", null, "vero-moda-maternity", null },
                    { 497, 625L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9523), "", null, "", null, "Rocketdog", null, "rocketdog", null },
                    { 498, 15214L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9525), "Hot new label <strong>Vesper Tall</strong> gives you a serious fashion fix with their collection of figure sculpting dresses. Cut from luxe, super stretch fabrics, each dress is designed to flatt", null, "", null, "Vesper Tall", null, "vesper-tall", null },
                    { 499, 16486L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9526), "Based in Brooklyn, New York, <strong>Zemeta</strong> draws inspiration from its diverse doorstep to bring us the latest streetwear clothing. With a focus on asymmetric cuts, textured fabrics and ", null, "", null, "Zemeta", null, "zemeta", null },
                    { 500, 16557L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9528), "<strong>DesignB London Curve</strong> is the perfect pairing of quality and design. This London label creates major everyday vibes with its collection of faux-suede chokers, silver and gold jewe", null, "", null, "DesignB London Curve", null, "designb-london-curve", null },
                    { 501, 17953L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9529), "", null, "", null, "Bolongaro Trevor Sport", null, "bolongaro-trevor-sport", null },
                    { 502, 110L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9531), "When it comes to watches, <strong>Casio's</strong> are about as classic as they come. The Japanese brand&rsquo;s range of watches pairs go-with-everything design with functionality ", null, "", null, "Casio", null, "casio", null },
                    { 503, 298L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9532), "If you need an excuse for a wardrobe update, <strong>BOSS</strong> is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it comes to quality design. The", null, "", null, "BOSS", null, "boss", null },
                    { 504, 504L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9534), "When they couldn't find a watch that fulfilled their need for style and substance, <strong>Nixon</strong> set about creating their own. From their base in Southern California, ... ", null, "", null, "Nixon", null, "nixon", null },
                    { 505, 15237L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9535), "Refresh your wardrobe with casj-cool essentials by London brand <strong>Nobody's Child</strong>. Think tomboy meets girly-girl, as seasonal styles – including crop tops, jumpsuits and da", null, "", null, "Nobody's Child", null, "nobody's-child", null },
                    { 506, 20850L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9537), "Hold the flip phone, because <strong>Tammy Girl</strong> is back. Featuring a Y2K reboot, the brand’s offering is here to satisfy your nostalgic cravings. Scroll mini, midi and maxi dresses", null, "", null, "Tammy Girl", null, "tammy-girl", null },
                    { 507, 16427L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9539), "Step up your shoe game with our&nbsp;<strong>ASRA</strong>&nbsp;at ASOS edit.&nbsp;<strong>ASRA</strong>&nbsp;(which stands for Association, So", null, "", null, "ASRA", null, "asra", null },
                    { 508, 156L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9541), "Changing the denim game since 1978, <strong>Diesel</strong> celebrates self-expression and individuality with its reinterpreted lifestyle pieces. Ripped-up, washed denim features acr", null, "", null, "Diesel", null, "diesel", null },
                    { 509, 16535L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9542), "", null, "", null, "Threadbare Curve", null, "threadbare-curve", null },
                    { 510, 16536L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9544), "", null, "", null, "Threadbare Petite", null, "threadbare-petite", null },
                    { 511, 262L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9545), "Launched in 2004, footwear label <strong>H by Hudson</strong>  reworks current trends into its signature in-house style, referencing music and youth culture influences. Expect a wide range of contem", null, "", null, "H by Hudson", null, "h-by-hudson", null },
                    { 512, 16497L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9547), "<strong>ICONIC LONDON</strong> is all about creating trend-led makeup collections that are as standout as its name suggests. The brand’s glow-boosting beauty products help add ", null, "", null, "ICONIC LONDON", null, "iconic-london", null },
                    { 513, 12203L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9548), "In case you missed it, Juicy Couture is back. Revive the noughties and treat your casj line up with some freshly squeezed styles in our <strong>Juicy Couture</strong> at ASOS edit. Expect T-shirts,", null, "", null, "Juicy Couture", null, "juicy-couture", null },
                    { 514, 16706L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9550), "Feel like the best version of yourself with <strong>Wild Lovers</strong>’ range of lingerie and loungewear. The female-founded label was created to capture the retro girl’s free spirit w", null, "", null, "Wild Lovers", null, "wild-lovers", null },
                    { 515, 16166L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9551), "", null, "", null, "Garnier", null, "garnier", null },
                    { 516, 15708L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9553), "", null, "", null, "Tan Luxe", null, "tan-luxe", null },
                    { 517, 20251L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9554), "With timeless collections that are easy-to-wear *and* focused on personal style, we’re saying The Frolic FTW – and we mean it. The Aussie boutique stocks a range of top-tier styles all designed on its home turf, and each delivering a different aesthet", null, "", null, "The Frolic Plus", null, "the-frolic-plus", null },
                    { 518, 777L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9556), "Celebrating its 100th anniversary as a pioneer of home grooming in 2019, <strong>Wahl</strong> keeps you top of the crops with its professional-standard range. Fix up, look sharp with its beard trimm", null, "", null, "Wahl", null, "wahl", null },
                    { 519, 16138L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9557), "Delivering no-nonsense skincare that’s kind enough for even the most sensitive skin, <strong>CeraVe</strong> is here to give your AM/PM routine a serious upgrade. Developed by dermato", null, "", null, "CeraVe", null, "cerave", null },
                    { 520, 16266L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9558), "<strong>Native Youth Plus</strong> introduces oversized silhouettes and lightweight co-ords into your wardrobe this season. Expect clean shapes and soft-touch tencel contrasted with raw-edg", null, "", null, "Native Youth Plus", null, "native-youth-plus", null },
                    { 521, 14448L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9583), "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May Petite</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, r", null, "", null, "Noisy May Petite", null, "noisy-may-petite", null },
                    { 522, 23205L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9585), "Update your self-care shelf with our <strong>Patchology</strong> at ASOS edit. Ft. targeted products that get to work ASAP, the brand is here to revolutionise your routine. Start fr", null, "", null, "Patchology", null, "patchology", null },
                    { 523, 15393L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9587), "An expert in the art of exfoliation, resurfacing and skin renewal, <strong>Alpha-H</strong> is all about results-driven skincare. The award-winning beauty brand behind cult product Liq", null, "", null, "Alpha-H", null, "alpha-h", null },
                    { 524, 15600L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9588), "Stealing the spotlight with standout sequins and sheer layers, <strong>Maya Plus</strong> is your go-to for next-level occasionwear. With a nod to the catwalks, expect floor-sweeping maxis, pretty ", null, "", null, "Maya Plus", null, "maya-plus", null },
                    { 525, 14810L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9590), "Standout sequins and cool cut-outs help steal the spotlight with <strong>Maya Tall</strong> occasionwear. With a nod to the catwalks, expect need-right-now maxi dresses, hand embellishment and prom", null, "", null, "Maya Tall", null, "maya-tall", null },
                    { 526, 15503L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9591), "Offering a fresh take on skate clothing, <strong>LEVIS SKATEBOARDING</strong> Skateboarding takes your favourite Levi’s designs and reconstructs them in toughened-up fabrics. Expect straight-leg je", null, "", null, "LEVIS SKATEBOARDING", null, "levis-skateboarding", null },
                    { 527, 15833L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9595), "", null, "", null, "Urban Threads", null, "urban-threads", null },
                    { 528, 178L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9597), "Multi-award winning nail care brand, <strong>Elegant Touch</strong> was developed right on the King’s Road in Chelsea. With its roots at the heart of London’s celebrity and fash", null, "", null, "Elegant Touch", null, "elegant-touch", null },
                    { 529, 196L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9599), "Originating in the 1940s, false lash connoisseurs <strong>Eylure</strong>, channel their show business roots through their extensive eyelash collection. Intricately handmade, the range spans from", null, "", null, "Eylure", null, "eylure", null },
                    { 530, 16315L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9600), "London-based label <strong>Lace & Beads Plus</strong> know sparkly dresses are always a good idea, so create the perfect handcrafted party pieces for your BNO. Expect standout embellishment, ", null, "", null, "Lace & Beads Plus", null, "lace-&-beads-plus", null },
                    { 531, 14248L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9601), "Since setting up shop in the 60s, <strong>New Look</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ", null, "", null, "New Look Tall", null, "new-look-tall", null },
                    { 532, 16655L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9603), "", null, "", null, "Threadbare Fitness Tall", null, "threadbare-fitness-tall", null },
                    { 533, 16654L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9604), "", null, "", null, "Threadbare Fitness Petite", null, "threadbare-fitness-petite", null },
                    { 534, 15140L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9606), "Founded by a dermatologist in 1950s Paris, <strong>Embryolisse</strong> Laboratoires put the care into skincare. Initially turning heads with their famous Lait-Crème moisturiser, ... ", null, "", null, "Embryolisse", null, "embryolisse", null },
                    { 535, 14327L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9607), "Brides-to-be, show your devotion to your best gals with <strong>Maya Petite</strong> embellished bridesmaid dresses. Choose from a selection of midi, maxi and fit-and-flare styles for standout sequ", null, "", null, "Maya Petite", null, "maya-petite", null },
                    { 536, 16529L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9609), "Designing a range of super-dreamy beachwear, <strong>Iisla & Bird</strong> has got us keeping our fingers crossed for warm weather. Keep it breezy with co-ord beach tops, beach shorts and b", null, "", null, "Iisla & Bird", null, "iisla-&-bird", null },
                    { 537, 16421L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9610), "Award-winning and all in when it comes to innovation, makeup brand <strong>Real Techniques</strong> is on hand with the foundation brushes, cosmetic sponges and cleansing gels ", null, "", null, "Real Techniques", null, "real-techniques", null },
                    { 538, 14176L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9612), "", null, "", null, "Truffle Collection", null, "truffle-collection", null },
                    { 539, 14590L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9613), "From casual daytime pieces to elevated weekend styles, add some newness to your line-up with our <strong>Missguided</strong> at ASOS edit. Filling up our social feeds and Saved Items since 20", null, "", null, "Missguided", null, "missguided", null },
                    { 540, 15770L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9615), "Serving Insta-glam realness, clothing brand&nbsp;<strong>Fashionkilla</strong>&nbsp;certainly know how to grab our attention. Make room for BNO dresses such as mini, midi and bodycon option", null, "", null, "Fashionkilla", null, "fashionkilla", null },
                    { 541, 21554L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9616), "", null, "", null, "Edikted", null, "edikted", null },
                    { 542, 14714L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9617), "", null, "", null, "In Your Dreams", null, "in-your-dreams", null },
                    { 543, 20150L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9619), "When it comes to your casual rotation, no one does it better than <strong>Pull&Bear</strong>. Inspired by the laid-back vibe of Palm Springs, California, the brand references grunge influences,", null, "", null, "Pull&Bear Tall", null, "pull&bear-tall", null },
                    { 544, 14119L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9620), "Since setting up shop in the 60s, <strong>New Look Petite</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ", null, "", null, "New Look Petite", null, "new-look-petite", null },
                    { 545, 16386L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9622), "Inclusive and empowering,  <strong>American Eagle</strong> is a clothing brand that celebrates individuality through its staples and standout pieces. Expect everything from cosy hoodies and", null, "", null, "American Eagle", null, "american-eagle", null },
                    { 546, 15307L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9623), "Love Abercrombie & Fitch? Us too. That's why we're so excited to have its lingerie brand, <strong>Gilly Hicks</strong>, at ASOS. Channelling that familiar effortless vibe, our edit of its ba", null, "", null, "Gilly Hicks", null, "gilly-hicks", null },
                    { 547, 3492L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9625), "<strong>French Connection</strong> have been creating well-designed, fashion-forward collections since 1972, delivering stylish separates, statement dresses and clean-cu", null, "", null, "FCUK", null, "fcuk", null },
                    { 548, 12833L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9626), "", null, "", null, "Maurie & Eve", null, "maurie-&-eve", null },
                    { 549, 16494L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9627), "When it comes to getting dressed, <strong>Stan Ray</strong> isn’t messing about. Making clothes designed to be worn (like, really worn), the Texas-born brand delivers durable, fuss-free threads", null, "", null, "Stan Ray", null, "stan-ray", null },
                    { 550, 20705L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9629), "", null, "", null, "MIM", null, "mim", null },
                    { 551, 13849L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9630), "Delivering designer sunglasses in a range of shapes and colours, <strong>Vogue Eyewear</strong> is all about bringing a bit of glamour and sophistication to your everyday look. Fro", null, "", null, "Vogue", null, "vogue", null },
                    { 552, 21958L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9632), "Nobody nails great skincare like world-renowned aesthetics doctor, Barbara Sturm. Boasting an impressive celebrity following, our Barbara Sturm at ASOS edit puts science-based skincare firmly on the map (and into our baskets!). Get the spa treatment with ", null, "", null, "Dr. Barbara Sturm", null, "dr.-barbara-sturm", null },
                    { 553, 12431L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9633), "French designed youth brand <strong>Kickers</strong> saw a resurgence in popularity when they were adopted by the rave scene of the early 90s. With their distinctive tough crepe soles and nubuck l", null, "", null, "Kickers", null, "kickers", null },
                    { 554, 12477L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9635), "Founded in 1970s Pennsylvania, USA, <strong>Free People</strong> channels a bohemian femininity in their designs. With emphasis on freedom of dress, ... ", null, "", null, "We The Free by Free People", null, "we-the-free-by-free-people", null },
                    { 555, 16589L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9636), "With a philosophy of getting out and doing what makes you smile, Seattle-born brand <strong>KAVU</strong> hits the ground running when it comes to adventure-ready gear. Scroll our ... ", null, "", null, "KAVU", null, "kavu", null },
                    { 556, 16378L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9638), "Give your wardrobe that extra something-something with the latest drop from <strong>Wednesday's Girl Maternity</strong>. Big on floral and ditsy prints, the brand helps bring your daytim", null, "", null, "Wednesday's Girl Maternity", null, "wednesday's-girl-maternity", null },
                    { 557, 21200L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9639), "", null, "", null, "Nobody’s Child Petite", null, "nobody’s-child-petite", null },
                    { 558, 16682L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9641), "Refresh your wardrobe with casj-cool essentials by London brand <strong>Nobody's Child Plus</strong>. Think tomboy meets girly-girl, as seasonal styles – including crop tops, jumpsuits a", null, "", null, "Nobody's Child Plus", null, "nobody's-child-plus", null },
                    { 559, 12311L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9642), "Founded in 1995, <strong>Base London</strong> was created to fill a noticeable gap in the market for men's design-led, high quality formal footwear at a reasonable price. Quickly developing in ", null, "", null, "Base London", null, "base-london", null },
                    { 560, 16319L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9644), "<strong>Les Girls Les Boys</strong> is the creator of our new favourite style aesthetic: underwear meets street. Designing the sleekest, chicest selection of lingerie and loungewear, ", null, "", null, "Les Girls Les Boys", null, "les-girls-les-boys", null },
                    { 561, 15869L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9645), "Whether you&rsquo;re heading to a festival or just feeling a little extra, <strong>Elsie &amp; Fred</strong> ticks all the boxes. Think sequins, glitter and tassels galore", null, "", null, "Elsie & Fred", null, "elsie-&-fred", null },
                    { 562, 16339L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9647), "Bringing a bit of fun to the beauty scene, <strong>M.A.D Beauty</strong> knows how to make childhood dreams come true when it comes to novelty beauty gifting. With Disney accessori", null, "", null, "M.A.D Beauty", null, "m.a.d-beauty", null },
                    { 563, 15757L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9648), "", null, "", null, "Madden Girl", null, "madden-girl", null },
                    { 564, 20452L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9663), "We’re *living* for <strong>Kanya London</strong> and their mission to reimagine occasion wear with modern twists. The South Asian-owned brand creates timeless pieces that are inspired by ", null, "", null, "Kanya London", null, "kanya-london", null },
                    { 565, 15350L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9665), "With 25 years in expertise, Swiss suncare brand <strong>Ultrasun's</strong> skin protection is known for its once-a-day application. Its sun lotions, sprays and gels offer long-lastin", null, "", null, "Ultrasun", null, "ultrasun", null },
                    { 566, 16507L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9667), "Get that feel-good factor (15 to 50) with <strong>Sun Bum</strong>. Big on sun care, the brand’s vegan and cruelty-free SPF products make it easy to stay safe in the sun all year rou", null, "", null, "Sun Bum", null, "sun-bum", null },
                    { 567, 14555L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9668), "Inspired by trending looks, <strong>Lottie</strong> future-proofs your makeup bag with its range of cosmetics. Scrolling through the most talked about social feeds so you don’t have to, ", null, "", null, "Lottie", null, "lottie", null },
                    { 568, 20607L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9670), "Give your trusty mascara a day off with <strong>Tatti Lashes</strong> . The brand’s collection of luxe false lashes lets you keep things fresh and customise your look. Scroll ou", null, "", null, "Tatti Lashes", null, "tatti-lashes", null },
                    { 569, 12191L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9673), "What’s bold, grungy and serving Y2K vibes? You in an Ed Hardy dress, obvs. With colour-blocking and gram-worthy graphics, the brand fuses together tattoo artistry and fashion to create on-trend pieces that’ll have heads turning. Browse our Ed Hardy at", null, "", null, "Ed Hardy", null, "ed-hardy", null },
                    { 570, 12724L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9675), "The premier supplier of tough wearing jackets for the U.S. military; <strong>Alpha Industries</strong> have over 50 years of quality manufacturing expertise and unrivalled heritage under ", null, "", null, "Alpha Industries", null, "alpha-industries", null },
                    { 571, 15609L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9676), "The designers behind <strong>Parlez</strong> draw on a love of street culture to craft their collection of hoodies, sweatshirts and T-shirts. Inspired by sportswear and nautical aesthetics, the lab", null, "", null, "Parlez", null, "parlez", null },
                    { 572, 16164L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9678), "", null, "", null, "Wednesday's Girl Curve", null, "wednesday's-girl-curve", null },
                    { 573, 12731L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9679), "Italian label <strong>Fiorucci</strong> achieved cult status in the 70s and 80s with its outlandish designs and skin-tight jeans. More than 50 years later, the brand has relaunched with a focus", null, "", null, "Fiorucci", null, "fiorucci", null },
                    { 574, 16401L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9681), "With an approach grounded in science, leading beauty brand <strong>L&rsquo;Oreal</strong> demands only the most visionary products from its team. Whether you need an everyd", null, "", null, "L'Oreal Elvive", null, "l'oreal-elvive", null },
                    { 575, 16193L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9682), "If you’re the kind of person who likes a bubble bath and series binge after a busy day, then Sunday Rain is for you. Big on self-care, its range of heavenly scented bath and body products gives your ‘me time’ a serious upgrade. Shop our edit of the ", null, "", null, "Sunday Rain", null, "sunday-rain", null },
                    { 576, 13843L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9684), "Since setting up shop in the 60s, <strong>New Look Maternity</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ", null, "", null, "New Look Maternity", null, "new-look-maternity", null },
                    { 577, 16709L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9685), "A lover of style and authenticity, Italian tennis champion <strong>Sergio Tacchini</strong> founded his namesake label in 1966. Since then, the brand has helped redefine traditional sports", null, "", null, "Sergio Tacchini", null, "sergio-tacchini", null },
                    { 578, 676L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9687), "Providing a natural tan all year round, <strong>St. Tropez</strong> offer a professional, streak-free sun-kissed glow with their range of fake tan and tinted moisturisers. Cont", null, "", null, "St. Tropez", null, "st.-tropez", null },
                    { 579, 16619L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9688), "Determined to create a brand that black men everywhere could be proud of, <strong>Aaron Wallace</strong> kick-started his namesake grooming brand in 2016 from his south London barbershop. Sp", null, "", null, "Aaron Wallace", null, "aaron-wallace", null },
                    { 580, 22356L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9689), "Want to get your complexion in check? Us too. Enter Sarah Chapman, founder behind the luxury champ of all skincare labels. Find treatment room TLC at your fingertips with the brand’s milky cleansers and scroll silky serums for that profesh facial feel -", null, "", null, "Sarah Chapman", null, "sarah-chapman", null },
                    { 581, 16233L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9691), "", null, "", null, "Piz Buin", null, "piz-buin", null },
                    { 582, 20400L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9692), "Your future’s looking bright with London-based jewellery brand Faded Future in it. If you’re new to the accessorising game, a chain necklace never misses, and there’s everything from mixed metals to multiple layers to choose from. Or, if you’re lo", null, "", null, "FADED FUTURE", null, "faded-future", null },
                    { 583, 16607L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9694), "Offering a selection of broad-spectrum sun protection, sun-care brand <strong>Lancaster</strong> is your go-to for tanning responsibly. Stock up on its SPF tanning oils, suntan lotio", null, "", null, "Lancaster", null, "lancaster", null },
                    { 584, 15338L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9695), "Fed up with colour fade? <strong>Pureology</strong> range of haircare is designed to protect colour-treated hair and give you that fresh-out-the-salon look. Its sulphate-free shampoos, conditioners,", null, "", null, "Pureology", null, "pureology", null },
                    { 585, 21955L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9697), "", null, "", null, "Grown Alchemist", null, "grown-alchemist", null },
                    { 586, 12168L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9698), "", null, "", null, "Beauty Blender", null, "beauty-blender", null },
                    { 587, 20605L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9700), "Refresh your wardrobe with our <strong>KYO</strong> at ASOS edit. Combining Far East fashion and Western street style, the brand is all about keeping things versatile. Make a statement wit", null, "", null, "KYO", null, "kyo", null },
                    { 588, 16447L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9701), "<strong>HARRY'S</strong> is the name and well-rounded, straightforward skincare is its game. After a close, comfortable shave? You’re in luck – the NYC-based men’s grooming brand has the tool", null, "", null, "HARRY'S", null, "harry's", null },
                    { 589, 16116L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9702), "", null, "", null, "OGX", null, "ogx", null },
                    { 590, 3735L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9704), "Denim pioneers <strong>G-Star</strong> are famed for their work with raw denim jeans, utilising innovative techniques to create new styles and cuts. The ... ", null, "", null, "G-Star", null, "g-star", null },
                    { 591, 12455L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9705), "<strong>Palladium</strong> boots are made for, well, just about everything. After manufacturing airplane tyres in the 1920s, the French brand went on to apply the same tough rubber to the soles o", null, "", null, "Palladium", null, "palladium", null },
                    { 592, 12681L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9707), "", null, "", null, "Vita Liberata", null, "vita-liberata", null },
                    { 593, 15589L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9708), "Newsflash: our <strong>Spectrum</strong> at ASOS edit has landed, and the beauty brand sure knows how to handle makeup bag MVPs. Scroll singular makeup brushes and sponges designed fo", null, "", null, "Spectrum", null, "spectrum", null },
                    { 594, 16514L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9710), "", null, "", null, "Veet", null, "veet", null },
                    { 595, 15473L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9711), "Get serious with your skincare routine with <strong>MasqueBAR</strong> sheet, mud and cream masks. Developed in Korea, its range of professional-standard home remedies are formulated with ingred", null, "", null, "MasqueBAR", null, "masquebar", null },
                    { 596, 15816L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9713), "", null, "", null, "Aveda", null, "aveda", null },
                    { 597, 16203L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9714), "With over 115 years in the business, <strong>Gillette</strong> knows what it’s doing. The brand is committed to creating the closest and most comfortable shave with its ever-evolvin", null, "", null, "Gillette", null, "gillette", null },
                    { 598, 16022L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9716), "Whatever the occasion, <strong>New Girl Order</strong> specialises in all things bold and daring with its personality-packed collection. We’ve pulled together some of our favourite grap", null, "", null, "New Girl Order", null, "new-girl-order", null },
                    { 599, 16618L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9717), "Our two favourite words: new shoes. Supplying the goods is Manchester-based footwear brand <strong>EGO</strong>, serving up catwalk-inspired designs loved by your fave fashion influencers since 2015", null, "", null, "EGO", null, "ego", null },
                    { 600, 20051L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9789), "", null, "", null, "Jamaican Mango & Lime", null, "jamaican-mango-&-lime", null },
                    { 601, 17701L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9791), "Locks feeling a little lacklustre? <strong>Hairburst</strong> is on hand to give them a zhuzh with its range of award-winning hair care. Specifically formulated to promote length and", null, "", null, "Hairburst", null, "hairburst", null },
                    { 602, 14451L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9792), "", null, "", null, "Rule London", null, "rule-london", null },
                    { 603, 16414L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9794), "Introducing <strong>Damson Madder</strong>: the London-based brand supplying you with the perf’ garms for a wardrobe refresh. Choose from statement hoodies, joggers and T-shirts, or colo", null, "", null, "Damson Madder", null, "damson-madder", null },
                    { 604, 18050L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9796), "Finding your glow couldn’t be easier with <strong>Bali Body</strong>. Inspired by the shores of Bali, the Australian-born brand shines through with a range of vegan tanning treats ", null, "", null, "Bali Body", null, "bali-body", null },
                    { 605, 20951L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9797), "", null, "", null, "Extro & Vert Tall", null, "extro-&-vert-tall", null },
                    { 606, 16578L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9842), "Hot new label <strong>Vesper Petite</strong> gives you a serious fashion fix with their collection of figure sculpting dresses. Cut from luxe, super stretch fabrics, each dress is designed to fla", null, "", null, "Vesper Petite", null, "vesper-petite", null },
                    { 607, 12635L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9844), "Pioneering skincare brand <strong>Murad</strong> consistently deliver results with their high performance collection. Creating tailor-made product ranges to target specific skin concerns, each ... ", null, "", null, "Murad", null, "murad", null },
                    { 608, 17950L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9846), "With its Scandinavian roots and minimalist styling, <strong>Pieces Tall</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand tie", null, "", null, "Pieces Tall", null, "pieces-tall", null },
                    { 609, 16475L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9847), "<strong>Glow Hub</strong> believes that healthy, happy skin isn’t just a trend, and we agree. Packed with vitamins and antioxidants, the brand’s colour-coded ranges help make it ea", null, "", null, "Glow Hub", null, "glow-hub", null },
                    { 610, 16423L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9849), "With confidence and empowerment at the heart of its designs, <strong>Aria Cove</strong> is a go-to for standout partywear. Level up your weekend look with our ... ", null, "", null, "Aria Cove", null, "aria-cove", null },
                    { 611, 15752L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9850), "Is your AM-PM regime in need of a little TLC? Look to <strong>First Aid Beauty</strong> for your new skincare heroes. Providing targeted solutions for sensitive skin types, th", null, "", null, "First Aid Beauty", null, "first-aid-beauty", null },
                    { 612, 13827L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9852), "Offering more than your average action sports brand, <strong>RVCA</strong> is a design-driven lifestyle brand that doesn't concern itself with passing trends. Their fresh take on swimwear sees lase", null, "", null, "RVCA", null, "rvca", null },
                    { 613, 16438L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9853), "Dreaming of longer, thicker hair? Bring the bounce back with hair extensions from <strong>Easilocks</strong>. Whether you’re in the mood for sleek ponytail pieces, glossy fringe ex", null, "", null, "Easilocks", null, "easilocks", null },
                    { 614, 3392L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9855), "Focusing on statement pieces with a truly feminine twist, boutique brand <strong>Rare</strong> take influence from catwalk trends and iconic style setters. Look out for party dresses and miniskirts ", null, "", null, "Rare", null, "rare", null },
                    { 615, 16705L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9856), "", null, "", null, "HVISK", null, "hvisk", null },
                    { 616, 21959L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9857), "", null, "", null, "Spotlight", null, "spotlight", null },
                    { 617, 15815L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9859), "Great news for hair everywhere – <strong>Bumble and Bumble</strong> is officially available on ASOS. Often spotted backstage during fashion week, the New York City salon’", null, "", null, "Bumble and Bumble", null, "bumble-and-bumble", null },
                    { 618, 16267L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9860), "", null, "", null, "My White Secret", null, "my-white-secret", null },
                    { 619, 15961L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9862), "Looking for your next signature scent? Our edit of football legend David Beckham’s aftershaves has you covered. Keep things fresh and fruity with its Classic Blue eau de toilette, or go for Homme if a heady scent is more your vibe – we love the spiced", null, "", null, "David Beckham", null, "david-beckham", null },
                    { 620, 23055L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9863), "A look is never complete without on-point accessories, and Sui Ava is here to help your ‘fit reach its *full* potench. Shop colourful beaded necklaces for Y2K vibes, or wear your five a day with its stud and hoop earrings in fruity designs. Hair-up kind", null, "", null, "Sui Ava", null, "sui-ava", null },
                    { 621, 21807L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9865), "", null, "", null, "Sundae Body", null, "sundae-body", null },
                    { 622, 19500L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9866), "", null, "", null, "Carbon Theory", null, "carbon-theory", null },
                    { 623, 16112L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9868), "", null, "", null, "Flat Lay Company", null, "flat-lay-company", null },
                    { 624, 16679L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9869), "", null, "", null, "Shaka", null, "shaka", null },
                    { 625, 3755L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9871), "", null, "", null, "DKNY Active", null, "dkny-active", null },
                    { 626, 62101L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9872), "", null, "", null, "Messina Hembry Clothing Ltd", null, "messina-hembry-clothing-ltd", null },
                    { 627, 13597L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9874), "Back in 2008, <strong>Icon Brand</strong> started as a youthful spin-off to a jewellery design company that was 31-years-old. Now based out of London, New York and Sydney, its simple and refine", null, "", null, "Icon Brand", null, "icon-brand", null },
                    { 628, 16431L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9875), "Breathing fresh air into street style, <strong>Sixth June Plus</strong> launched in Paris in 2008. With its creative and innovative approach to design, the brand’s collection of jumpers, cr", null, "", null, "Sixth June Plus", null, "sixth-june-plus", null },
                    { 629, 15248L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9877), "London barbers <strong>Johnny's Chop Shop</strong> channel their well-groomed attitude and Americana aesthetic into their expert range. Expect beard oils, shampoos and styling clays rich", null, "", null, "Johnny's Chop Shop", null, "johnny's-chop-shop", null },
                    { 630, 20950L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9878), "", null, "", null, "Extro & Vert Petite", null, "extro-&-vert-petite", null },
                    { 631, 15811L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9880), "Putting a clean twist on everyday essentials, Danish label <strong>Y.A.S Petite</strong> packs its understated-cool style into dresses, premium leather and tailored pieces. Think minimalist designs ", null, "", null, "Y.A.S Petite", null, "y.a.s-petite", null },
                    { 632, 13656L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9881), "From the construction site to our daily rotation, <strong>Cat Footwear</strong> range of rugged workwear has grown into a collection of lifestyle clothing and footwear with serious flex appeal", null, "", null, "Cat Footwear", null, "cat-footwear", null },
                    { 633, 22455L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9883), "Three words: knots, dryness and the dreaded F-R-I-Z-Z. Maintaining curly tresses can be challenging, but Bouclème gets it. Celebrating natural curls is the brand’s MO and the reason it delivers a range of products specifically catered to care for all t", null, "", null, "Bouclème", null, "bouclème", null },
                    { 634, 15067L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9884), "From casual daytime pieces to elevated weekend styles, add some newness to your line-up with our <strong>Missguided</strong> at ASOS edit. Filling up our social feeds and Saved Items since 20", null, "", null, "Missguided Maternity", null, "missguided-maternity", null },
                    { 635, 12491L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9885), "", null, "", null, "Barneys Originals", null, "barneys-originals", null },
                    { 636, 62450L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9887), "PSA: we have zero chill when it comes to outerwear brand <strong>JACK1T</strong>. Allow us to introduce you to a go-to label, whether you’re heading for the slopes or the streets – expect puffe", null, "", null, "JACK1T", null, "jack1t", null },
                    { 637, 3414L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9888), "A family owned brand created in New York with a rich history, <strong>Schott's</strong> pea coats and leather jackets are still produced by hand. ... ", null, "", null, "Schott", null, "schott", null },
                    { 638, 13017L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9890), "London-based brand <strong>Crooked Tongues</strong> is easily identifiable by its bold streetwear. Headed up by graphic designers, the drops take inspiration from pop culture and the ska", null, "", null, "Crooked Tongues", null, "crooked-tongues", null },
                    { 639, 62250L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9892), "", null, "", null, "OOSC", null, "oosc", null },
                    { 640, 15591L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9893), "Calling all adventure lovers! <strong>Jack Wolfskin</strong> is here with all the kit you’ll need for your upcoming outdoor pursuits. Big on functionality and high-performance fabrics, the", null, "", null, "Jack Wolfskin", null, "jack-wolfskin", null },
                    { 641, 16005L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9895), "Sweet dreams start with cute sleepwear &ndash; enter <strong>Women'secret</strong> with its collection of cute and creative designs. Our edit of the brand&rsquo;s night dresses, pyjama sets ", null, "", null, "Women'secret", null, "women'secret", null },
                    { 642, 15895L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9896), "Perfect your fingertips with <strong>Sally Hansen's</strong> range of nail varnishes and nail-care products. Scroll vitamin nail serums to help protect and strengthen your nails, ", null, "", null, "Sally Hansen", null, "sally-hansen", null },
                    { 643, 14300L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9898), "<strong>Jaded London</strong> takes its inspiration from global street-style, from East London to LA and New York. The product of London-based siblings Jade and Grant Goulden, this is a brand", null, "", null, "Jaded London", null, "jaded-london", null },
                    { 644, 62503L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9899), "", null, "", null, "Soho Skin", null, "soho-skin", null },
                    { 645, 16250L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9901), "With over 90 years of manufacturing experience, <strong>Dickies</strong> traces its reputation for durability and performance back to its workwear roots. Rounding up a selection of everyday stap", null, "", null, "Dickies Girl", null, "dickies-girl", null },
                    { 646, 21855L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9902), "London-based label <strong>Lace & Beads Petite</strong> know sparkly dresses are always a good idea, so create the perfect handcrafted party pieces for your BNO. Expect standout embellishment", null, "", null, "Lace & Beads Petite", null, "lace-&-beads-petite", null },
                    { 647, 16135L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9904), "", null, "", null, "StylPro", null, "stylpro", null },
                    { 648, 16461L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9939), "Inspired by their signature luxe style, influencers Ellie and Daisey O’Donnell introduce <strong>The O Dolls Collection</strong>. For easy, everyday glam, shop cropped hoodies a", null, "", null, "The O Dolls Collection", null, "the-o-dolls-collection", null },
                    { 649, 16178L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9941), "The search is over for your new festival attire – <strong>Go Guy</strong> has just landed onsite. Starting off as a one-woman feat. sewing machine show, the brand hasn’t stopped growing since ", null, "", null, "Go Guy", null, "go-guy", null },
                    { 650, 14444L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9942), "<strong>Little Mistress Plus</strong> collection ticks all your occasionwear boxes – we’re talking weddings, proms, fancy parties and everything in-between. The brand’s pretty dres", null, "", null, "Little Mistress Plus", null, "little-mistress-plus", null },
                    { 651, 16393L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9944), "Get ski-season ready with <strong>Eivy</strong>. Based in the Swedish mount resort of Åre, the brand knows a thing or two when it comes to skiwear. Scroll our ... ", null, "", null, "Eivy", null, "eivy", null },
                    { 652, 12552L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9945), "Co-founded by Ben and Bobby Hundreds in 2003, <strong>The Hundreds</strong> centre on street subculture with both a clothing line and an online magazine.  ... ", null, "", null, "The Hundreds", null, "the-hundreds", null },
                    { 653, 480L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9947), "If founder Franco Moschino left one legacy behind him, it was the motto of Italian design house <strong>Moschino</strong>; 'fashion should be fun'. Diffusion lines Cheap and Chic and Love Moschi", null, "", null, "Moschino", null, "moschino", null },
                    { 654, 15351L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9948), "Inspired by beauty influencers, <strong>L&rsquo;Oreal Paris' COLORISTA </strong> haircare is made for the fearless. Choose from spray-on pastels to more wearable colours", null, "", null, "L Oréal Pa", null, "l-oréal-pa", null },
                    { 655, 20050L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9950), "<strong>Eco Style</strong> makes beauty affordable as it believes its power should be accessible (ICYDK: eco = economical). Specialising in weightless hair gels enriched with moistur", null, "", null, "Eco Style", null, "eco-style", null },
                    { 656, 20606L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9951), "Dreaming of an effortlessly chic capsule wardrobe? Extro & Vert has got you covered. Specialising in modern tailoring, the brand serves up minimal designs with maximum impact. Expect oversized blazers and relaxed trousers, or mix-and-match with polished s", null, "", null, "Extro & Vert Plus", null, "extro-&-vert-plus", null },
                    { 657, 16723L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9953), "Drawing on her 10+ years expertise as a beauty blogger, Huda Kattan decided to turn her attention to her followers’ skincare concerns and create skincare brand ... ", null, "", null, "Wishful", null, "wishful", null },
                    { 658, 16180L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9954), "Psychic Sisters’ range of spiritual and holistic products are ideal for novices and experts alike. The team behind the brand have been practicing tarot, clairvoyance and reiki healing for over 10 years – so they’re kinda a big deal. Shop our edit of", null, "", null, "Psychic Sisters", null, "psychic-sisters", null },
                    { 659, 16652L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9956), "", null, "", null, "Threadbare Fitness Curve", null, "threadbare-fitness-curve", null },
                    { 660, 14803L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9957), "From casual daytime pieces to elevated weekend styles, add some newness to your line-up with our <strong>Missguided</strong> at ASOS edit. Filling up our social feeds and Saved Items since 20", null, "", null, "Missguided Plus", null, "missguided-plus", null },
                    { 661, 21055L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9959), "", null, "", null, "Loungeable Tall", null, "loungeable-tall", null },
                    { 662, 21450L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9960), "Nostalgic AND futuristic, what more could you want? Enter clothing brand Basic Pleasure Mode. Inspired by underground subcultures, sci-fi movies and 00s magazines, the label is here to enhance your line-up. Scroll tops and T-shirts featuring graphic print", null, "", null, "Basic Pleasure Mode", null, "basic-pleasure-mode", null },
                    { 663, 16072L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9962), "Founded by the Graah family in 2004, iconic Swedish brand <strong>Dr Denim Tall</strong> are famed for their skinny jeans and simple Scandinavian styling. Branching out with a collection of jers", null, "", null, "Dr Denim Tall", null, "dr-denim-tall", null },
                    { 664, 16387L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9963), "Prom queens and wedding guests, claim the best-dressed title in <strong>Hope & Ivy Plus</strong> occasion-ready collection. Shop its notice-me styles for hand-painted florals, Bardot neckli", null, "", null, "Hope & Ivy Plus", null, "hope-&-ivy-plus", null },
                    { 665, 15091L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9966), "From best dressed to wedding guest, <strong>Hope & Ivy Maternity</strong> dresses you for the next nine months and beyond. Choose from bump-friendly bodycons and two-in-one nursing dresses,", null, "", null, "Hope & Ivy Maternity", null, "hope-&-ivy-maternity", null },
                    { 666, 16581L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9967), "", null, "", null, "Violet Romance Petite", null, "violet-romance-petite", null },
                    { 667, 13305L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9969), "Pioneering beauty brand <strong>REN</strong> drew up a comprehensive list of ingredients that weren’t welcome in its products when it was founded back in 2000, and hasn’", null, "", null, "REN", null, "ren", null },
                    { 668, 15003L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9970), "", null, "", null, "Harry Brown", null, "harry-brown", null },
                    { 669, 15364L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9972), "", null, "", null, "Gianni Feraud", null, "gianni-feraud", null },
                    { 670, 19900L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9973), "", null, "", null, "Shambhala", null, "shambhala", null },
                    { 671, 14557L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9974), "Take it outside and embrace those warm, fuzzy feels with clothing brand <strong>Jayley</strong>. The brand’s collection of outerwear and accessories is handcrafted from premium fabrics leaving ", null, "", null, "Jayley", null, "jayley", null },
                    { 672, 13518L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9976), "Born in the heart of American surfing culture in Southern California, <strong>Hurley</strong> has been creating surfing goods since the late 70s. Our ... ", null, "", null, "Hurley", null, "hurley", null },
                    { 673, 13935L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9977), "Founded in 2006, <strong>Deus Ex Machina</strong> hails from Australia. Originally launching with customised motorcycles, the guys at Deus Ex quickly developed a clothing range and we're g", null, "", null, "Deus Ex Machina", null, "deus-ex-machina", null },
                    { 674, 16432L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9979), "", null, "", null, "A.Kjaerbede", null, "a.kjaerbede", null },
                    { 675, 15821L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9980), "With just a market cart and a passion for interior design, Joe Chandler founded British homeware label <strong>Chickidee</strong> back in 2007. We&rsquo;ve rounded up a selecti", null, "", null, "CHICKIDEE", null, "chickidee", null },
                    { 676, 14974L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9982), "Australian-based label <strong>Sisters of the Tribe</strong> turns up the heat with its out-all-day-and-night styles. Standout prints and trims bring an added edge to your wardrobe ", null, "", null, "Sisters of the Tribe", null, "sisters-of-the-tribe", null },
                    { 677, 21156L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9987), "", null, "", null, "Truffle Collection Wide Fit", null, "truffle-collection-wide-fit", null },
                    { 678, 18151L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9988), "BeYou creates science-backed period products. Best known for its award-winning monthly period patches, the brand also helps to balance inequalities in medical research by developing products in a way that challenges the status quo. Find everything you nee", null, "", null, "BeYou", null, "beyou", null },
                    { 679, 13573L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9989), "Inspired by adventure, swimwear brand <strong>Rhythm</strong> range is as much about self-expression as it is doing what you love. Drawing on influences from art, music, fashion and travel, its b", null, "", null, "Rhythm", null, "rhythm", null },
                    { 680, 16214L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9991), "<p>For targeted skincare products that also give your bathroom cabinet a bit of a zhuzh, introduce yourself to Tonymoly. Born in Seoul, it joins the long list of Korean beauty brands we&rsquo;re already obsessed with. Known for its adorable packaging, the", null, "", null, "Tonymoly", null, "tonymoly", null },
                    { 681, 62789L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9992), "Social calendar filling up fast? Our Denim Project at ASOS edit has a bunch of elevated everyday wear that just, hits different. Serving up T-shirts, trousers, and hoodies, as well as (you guessed it) – denim, consider your plans sorted as you tuck your", null, "", null, "Denim Project", null, "denim-project", null },
                    { 682, 14187L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9994), "With almost two decades of shoe-making under its belt, <strong>CAT</strong> has grown its line from a handful of work boots to a full collection of footwear and accessories. Its tough boots ", null, "", null, "CAT", null, "cat", null },
                    { 683, 13761L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9995), "Danish outdoors brand <strong>Fat Moose</strong> was founded by three friends, all with backgrounds in extreme sports and a desire to combine durable and innovative fabrics with practical soluti", null, "", null, "Fat Moose", null, "fat-moose", null },
                    { 684, 13962L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9997), "Watch makers <strong>Limit</strong>   have been bringing Swiss construction back to their UK-based headquarters since 1912. With sleek leather straps and super precise Japanese quartz movement, ... ", null, "", null, "Limit", null, "limit", null },
                    { 685, 3675L, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9998), "British design company <strong>Urbancode</strong>, uses traditional techniques across a contemporary edit of leather handbags and jackets. Cropped, aviator and biker styles are updated, all w", null, "", null, "Urbancode", null, "urbancode", null },
                    { 686, 14449L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc), "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May Tall</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, raw", null, "", null, "Noisy May Tall", null, "noisy-may-tall", null },
                    { 687, 12626L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(1), "Creating a sensory experience, <strong>L'Occitane</strong> samples the purest plant oils to formulate their certified organic collection. In keeping with the Mediterranean art de vivre, fragr", null, "", null, "L'Occitane", null, "l'occitane", null },
                    { 688, 12754L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(3), "We dare you to scroll past our Dare 2b at ASOS edit. You can’t do it, can ya? Maybe because the multi-sportswear brand has been pushing the boundaries of outdoor wear since 1999. Whether you’re running, climbing, or skiing, you won’t need to look an", null, "", null, "Dare 2b", null, "dare-2b", null },
                    { 689, 15584L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(4), "", null, "", null, "Brave Soul Petite", null, "brave-soul-petite", null },
                    { 690, 20601L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(6), "Introducing <strong>Topshop Hourglass</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stoppin", null, "", null, "Topshop Hourglass", null, "topshop-hourglass", null },
                    { 691, 62798L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(29), "Off The Hook is here to bring your *sole*searching to a halt. From loafers to knee-high boots, consider your ‘fit sorted from the bottom up with the brand’s range of footwear. Shop our Off The Hook at ASOS edit for boots that’ll take you from the of", null, "", null, "Off The Hook", null, "off-the-hook", null },
                    { 692, 16244L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(31), "No one can deny the power of a good suit, least of all <strong>Shelby & Sons</strong>. Serving up formalwear with a fresh edge, its range is inspired by those who ruled the streets in the ea", null, "", null, "Shelby & Sons", null, "shelby-&-sons", null },
                    { 693, 647L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(33), "", null, "", null, "Sean John", null, "sean-john", null },
                    { 694, 16406L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(34), "Obsessed with embellishment and standout silhouettes, <strong>Forever New Curve</strong> offers the ultimate in occassionwear. From flowing maxi dresses to bodycon fits, get prepped for your", null, "", null, "Forever New Curve", null, "forever-new-curve", null },
                    { 695, 15297L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(36), "<strong>Lamoda</strong> introduced the accessories market to its fresh bags and jewellery on ASOS Marketplace in 2012. Taking inspiration from badass girls, street trends and 90s throwbacks, it c", null, "", null, "Lamoda", null, "lamoda", null },
                    { 696, 62700L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(37), "Notification: missed call – it’s from the outdoors and it kinda wants you to get o-u-t there. We’ll add our <strong>Regatta</strong> at ASOS edit to your contacts because you won’t need to", null, "", null, "Regatta", null, "regatta", null },
                    { 697, 16528L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(39), "If you’re all about copping the latest trending styles, <strong>The Kript</strong> is the brand for you. First launching on the ‘gram, the Beirut-based clothing label takes its inspo from ", null, "", null, "The Kript", null, "the-kript", null },
                    { 698, 15827L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(40), "Let’s be honest, we all love a bit of Scandi style. That’s why we’ve put together an edit of Danish high-street brand <strong>ONLY Petite</strong> freshest pieces, including classic denim cut", null, "", null, "ONLY Petite", null, "only-petite", null },
                    { 699, 3154L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(42), "", null, "", null, "Helene Berman", null, "helene-berman", null },
                    { 700, 62410L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(43), "", null, "", null, "Pajar", null, "pajar", null },
                    { 701, 3513L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(44), "", null, "", null, "Claudia Canova", null, "claudia-canova", null },
                    { 702, 15143L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(46), "When it comes to underwear, it’s the style, comfort and support for <strong>Dorina</strong>. Empowering women to embrace body diversity, the brand offers plus size, fuller bust and maternity ra", null, "", null, "Dorina", null, "dorina", null },
                    { 703, 16039L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(47), "", null, "", null, "Thinx", null, "thinx", null },
                    { 704, 481L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(49), "Inspired by vintage prints and cuts, <strong>Motel</strong> are renowned for creating well-crafted pieces in an eclectic mix of designs. Embracing the feminine silhouette; look out for statement pa", null, "", null, "Motel", null, "motel", null },
                    { 705, 13839L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(50), "Vegan brand <strong>Call It Spring</strong> looks high and wide for its inspirations, taking influences from the streets, culture and the runway to create its trend-led fo", null, "", null, "Call it Spring", null, "call-it-spring", null },
                    { 706, 15355L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(52), "<strong>Tommy Hilfiger</strong> is a global brand with a classic/cool American heritage. Think timeless, preppy Americana, updated, re-imagined and always changing across ", null, "", null, "Tommy Hilfiger Denim", null, "tommy-hilfiger-denim", null },
                    { 707, 16306L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(53), "Introducing <strong>Topshop Maternity</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stoppin", null, "", null, "Topshop Maternity", null, "topshop-maternity", null },
                    { 708, 62799L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(54), "", null, "", null, "SENSSE", null, "sensse", null },
                    { 709, 12527L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(56), "Launched in 1946, British brand <strong>Accurist</strong> has led the way in making watches of exceptional quality, style and reliability for 70 years. Combining precision engineering with smart ", null, "", null, "Accurist", null, "accurist", null },
                    { 710, 16534L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(57), "", null, "", null, "VIOLET ROMANCE", null, "violet-romance", null },
                    { 711, 18901L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(59), "In the mood for effortless style? Look no further than German brand <strong>Edited</strong>. The label’s offering of it-pieces and timeless basics are total wardrobe wins. Scroll tops and trousers in", null, "", null, "Edited", null, "edited", null },
                    { 712, 14616L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(60), "Mix up your jewellery game with <strong>Kingsley Ryan</strong> fresh and innovative designs. Inspired by fashion and street trends, expect everything from minimal earrings to stackable rin", null, "", null, "Kingsley Ryan", null, "kingsley-ryan", null },
                    { 713, 15710L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(64), "Whatever the occasion, nail your going-out ’fit with <strong>Flounce London Maternity</strong> collection of party pieces. Tick all your maternity boxes in velvet tops, or choose from f", null, "", null, "Flounce London Maternity", null, "flounce-london-maternity", null },
                    { 714, 13668L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(65), "If you’re after a new going-out look or dressing for a big occasion, <strong>AX Paris</strong> never fails to deliver. Scroll the brand’s lace, satin and slinky bodycon dresses in mini and ", null, "", null, "AX Paris", null, "ax-paris", null },
                    { 715, 14629L, new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(67), "", null, "", null, "Devils Advocate", null, "devils-advocate", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CurrencyCode", "CurrencyName", "CurrencySign", "CustomStringFormat", "DefaultCultureName", "Description" },
                values: new object[,]
                {
                    { 1, "IRR", "تومان ایران", " تومان ", "N0", "fa-IR", "" },
                    { 2, "GBP", "Pound Sterling", "£", "N2", null, "" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "ApiId", "CreatedOnUtc", "Name", "Slug", "UpdatedOnUtc", "WeightId" },
                values: new object[,]
                {
                    { 1, 8415L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2166), "T-shirts", "t-shirts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2172), 2 },
                    { 2, 8390L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2174), "Shirts", "shirts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2176), 2 },
                    { 3, 8612L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2176), "Rings", "rings", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2178), 2 },
                    { 4, 8414L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2181), "Vests", "vests", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2183), 2 },
                    { 5, 10888L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2183), "Polo Shirts", "polo-shirts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2185), 2 },
                    { 6, 8386L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2185), "Shorts", "shorts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2186), 2 },
                    { 7, 8399L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2187), "Gilets", "gilets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2188), 2 },
                    { 8, 8572L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2189), "Trunks", "trunks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2190), null },
                    { 9, 8401L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2191), "Jackets", "jackets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2192), 3 },
                    { 10, 8366L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2193), "Socks", "socks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2194), null },
                    { 11, 11350L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2195), "Face Coverings", "face-coverings", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2196), null },
                    { 12, 8600L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2196), "Sandals", "sandals", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2197), 2 },
                    { 13, 8393L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2198), "Jeans", "jeans", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2199), null },
                    { 14, 8655L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2200), "Suit Jackets", "suit-jackets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2201), 3 },
                    { 15, 8654L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2202), "Suit Trousers", "suit-trousers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2204), 2 },
                    { 16, 8397L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2205), "Trousers", "trousers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2206), 3 },
                    { 17, 8405L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2207), "Sweatshirts", "sweatshirts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2208), 2 },
                    { 18, 8391L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2209), "Hoodies", "hoodies", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2210), 3 },
                    { 19, 8554L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2211), "Waistcoats", "waistcoats", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2212), 2 },
                    { 20, 8400L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2212), "Blazers", "blazers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2214), 3 },
                    { 21, 9763L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2214), "Body Moisturisers", "body-moisturisers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2216), null },
                    { 22, 8488L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2216), "Fake Tan", "fake-tan", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2217), null },
                    { 23, 9773L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2218), "Bath Sets", "bath-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2219), null },
                    { 24, 8455L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2220), "Body Washes", "body-washes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2221), null },
                    { 25, 9334L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2222), "Body Scrubs", "body-scrubs", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2223), null },
                    { 26, 9323L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2223), "Body Oils", "body-oils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2225), null },
                    { 27, 9766L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2226), "Self Tan", "self-tan", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2227), null },
                    { 28, 8513L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2228), "Fragrances", "fragrances", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2229), null },
                    { 29, 8669L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2230), "Candles", "candles", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2231), null },
                    { 30, 8594L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2231), "Watches", "watches", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2232), null },
                    { 31, 8253L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2233), "Belts", "belts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2234), null },
                    { 32, 8396L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2235), "Chinos", "chinos", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2236), null },
                    { 33, 8609L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2237), "Shoes", "shoes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2238), null },
                    { 34, 8244L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2238), "Sunglasses", "sunglasses", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2239), null },
                    { 35, 9765L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2240), "Sun Care", "sun-care", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2241), null },
                    { 36, 8562L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2242), "Briefs", "briefs", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2243), null },
                    { 37, 8407L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2243), "Joggers", "joggers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2244), 2 },
                    { 38, 8699L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2246), "Bra Solutions", "bra-solutions", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2247), null },
                    { 39, 8369L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2248), "Hair Clips", "hair-clips", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2249), 2 },
                    { 40, 8565L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2250), "Bras", "bras", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2251), 2 },
                    { 41, 8472L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2252), "Tracksuits", "tracksuits", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2253), 4 },
                    { 42, 8578L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2253), "Thongs", "thongs", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2255), null },
                    { 43, 8577L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2255), "Boxers", "boxers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2260), null },
                    { 44, 8466L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2261), "Loungewear Sets", "loungewear-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2262), 3 },
                    { 45, 8560L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2262), "Bralets", "bralets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2263), null },
                    { 46, 8416L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2264), "Dresses", "dresses", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2265), null },
                    { 47, 8283L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2266), "Bags", "bags", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2267), null },
                    { 48, 8431L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2268), "Purses", "purses", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2269), null },
                    { 49, 8585L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2269), "Boots", "boots", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2272), null },
                    { 50, 10885L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2272), "Fleeces", "fleeces", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2273), null },
                    { 51, 8406L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2274), "Coats", "coats", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2275), 4 },
                    { 52, 8514L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2276), "Hair Masks", "hair-masks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2277), null },
                    { 53, 8510L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2277), "Shampoos", "shampoos", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2278), null },
                    { 54, 15987L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2279), "Hair Mists & Fragrances", "hair-mists-&-fragrances", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2280), null },
                    { 55, 9769L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2281), "Facial Moisturisers", "facial-moisturisers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2282), null },
                    { 56, 8489L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2282), "Facial Serums", "facial-serums", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2283), null },
                    { 57, 8282L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2284), "Wash Bags", "wash-bags", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2285), null },
                    { 58, 10071L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2286), "Makeup Bags", "makeup-bags", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2287), null },
                    { 59, 9332L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2287), "Beauty Tools", "beauty-tools", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2289), null },
                    { 60, 10059L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2313), "Makeup Brushes", "makeup-brushes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2314), null },
                    { 61, 15295L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2317), "Vibrators", "vibrators", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2318), null },
                    { 62, 11139L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2318), "Lubricants", "lubricants", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2319), null },
                    { 63, 8275L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2320), "Caps", "caps", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2321), null },
                    { 64, 8242L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2322), "Harnesses", "harnesses", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2323), null },
                    { 65, 8276L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2324), "Scarves", "scarves", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2325), null },
                    { 66, 8245L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2325), "Hats", "hats", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2326), null },
                    { 67, 8273L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2327), "Snoods", "snoods", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2328), 2 },
                    { 68, 8606L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2329), "Trainers", "trainers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2330), 3 },
                    { 69, 10774L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2331), "Sliders", "sliders", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2332), 3 },
                    { 70, 8570L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2333), "Jock Straps", "jock-straps", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2334), null },
                    { 71, 8240L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2334), "Hairbands", "hairbands", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2338), 2 },
                    { 72, 8248L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2340), "Headbands", "headbands", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2341), null },
                    { 73, 8597L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2342), "Slippers", "slippers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2343), null },
                    { 74, 8449L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2343), "Conditioners", "conditioners", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2344), null },
                    { 75, 8526L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2345), "Hair Brushes", "hair-brushes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2346), null },
                    { 76, 9770L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2347), "Hair Extensions", "hair-extensions", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2348), null },
                    { 77, 8454L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2349), "Body Lotions", "body-lotions", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2350), null },
                    { 78, 8385L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2350), "Leggings", "leggings", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2351), null },
                    { 79, 8715L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2352), "Nighties", "nighties", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2353), 2 },
                    { 80, 8402L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2354), "Skirts", "skirts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2355), 2 },
                    { 81, 11273L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2356), "Corset Tops", "corset-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2357), 2 },
                    { 82, 8398L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2358), "Crop Tops", "crop-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2359), 2 },
                    { 83, 8388L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2359), "Pyjamas", "pyjamas", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2361), 2 },
                    { 84, 8592L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2362), "Earrings", "earrings", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2363), 2 },
                    { 85, 8266L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2364), "Bum Bags", "bum-bags", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2365), null },
                    { 86, 8591L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2366), "Bracelets", "bracelets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2367), 2 },
                    { 87, 8608L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2367), "Necklaces", "necklaces", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2369), 2 },
                    { 88, 8271L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2369), "Card Holders", "card-holders", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2370), null },
                    { 89, 8700L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2371), "Corsets", "corsets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2372), 2 },
                    { 90, 8392L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2373), "Blouses", "blouses", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2374), 2 },
                    { 91, 8281L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2374), "Backpacks", "backpacks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2376), null },
                    { 92, 8858L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2376), "Shaving Creams & Gels", "shaving-creams-&-gels", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2377), null },
                    { 93, 8856L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2378), "Shaving Sets", "shaving-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2379), null },
                    { 94, 9391L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2380), "Grooming Sets", "grooming-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2382), null },
                    { 95, 8848L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2382), "Beard Oils", "beard-oils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2383), null },
                    { 96, 8849L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2384), "Beard Balms", "beard-balms", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2385), null },
                    { 97, 9295L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2386), "After Shave Lotions", "after-shave-lotions", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2387), null },
                    { 98, 8236L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2387), "Gloves", "gloves", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2389), 2 },
                    { 99, 9782L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2389), "Skincare Sets", "skincare-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2390), null },
                    { 100, 9733L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2391), "Hair Grips", "hair-grips", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2392), null },
                    { 101, 9748L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2393), "Lingerie Bralets", "lingerie-bralets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2394), null },
                    { 102, 9761L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2394), "Hair Treatments", "hair-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2396), 2 },
                    { 103, 8527L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2396), "Hair Sets", "hair-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2397), null },
                    { 104, 8417L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2398), "Camis", "camis", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2399), null },
                    { 105, 8505L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2400), "Lip Balms", "lip-balms", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2401), null },
                    { 106, 8447L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2402), "Blushers", "blushers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2403), null },
                    { 107, 8543L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2404), "Lip Glosses", "lip-glosses", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2405), null },
                    { 108, 8468L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2406), "Nightwear Sets", "nightwear-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2407), null },
                    { 109, 9787L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2407), "Palettes", "palettes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2408), null },
                    { 110, 8451L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2409), "Bronzers", "bronzers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2410), null },
                    { 111, 8576L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2411), "Swim Shorts", "swim-shorts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2416), null },
                    { 112, 8403L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2417), "Playsuits", "playsuits", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2418), 3 },
                    { 113, 8384L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2419), "Jumpsuits", "jumpsuits", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2420), 2 },
                    { 114, 15989L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2421), "UV Sun Protection", "uv-sun-protection", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2422), null },
                    { 115, 9336L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2422), "Body Treatments", "body-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2423), null },
                    { 116, 8404L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2424), "Cardigans", "cardigans", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2425), 3 },
                    { 117, 8387L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2426), "Jumpers", "jumpers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2428), 3 },
                    { 118, 9038L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2429), "Pyjama Bottoms", "pyjama-bottoms", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2430), null },
                    { 119, 8471L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2430), "Onesies", "onesies", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2431), null },
                    { 120, 9778L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2432), "Eye Shadow Palettes", "eye-shadow-palettes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2433), null },
                    { 121, 8529L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2434), "Lipsticks", "lipsticks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2435), null },
                    { 122, 8659L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2435), "Highlighters", "highlighters", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2436), null },
                    { 123, 9768L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2437), "Cleansers", "cleansers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2438), null },
                    { 124, 8538L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2439), "Nail Treatments", "nail-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2440), null },
                    { 125, 9788L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2440), "Facial Exfoliators", "facial-exfoliators", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2441), null },
                    { 126, 10062L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2442), "Makeup Removers", "makeup-removers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2443), null },
                    { 127, 9729L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2444), "Facial Creams", "facial-creams", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2445), null },
                    { 128, 8516L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2445), "Face Masks", "face-masks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2447), null },
                    { 129, 8711L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2448), "Bikini Tops", "bikini-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2449), null },
                    { 130, 8265L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2450), "Ties", "ties", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2451), null },
                    { 131, 8284L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2452), "Bow Ties", "bow-ties", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2453), null },
                    { 132, 10883L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2454), "Hygiene Products", "hygiene-products", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2455), null },
                    { 133, 9834L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2455), "Bikini Bottoms", "bikini-bottoms", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2456), null },
                    { 134, 9139L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2457), "Water Bottles", "water-bottles", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2458), null },
                    { 135, 8533L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2458), "Primers", "primers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2460), null },
                    { 136, 9040L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2460), "Pyjama Tops", "pyjama-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2461), null },
                    { 137, 9775L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2462), "Lip Kits", "lip-kits", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2463), null },
                    { 138, 8500L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2463), "Facial Masks", "facial-masks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2464), null },
                    { 139, 8453L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2490), "Eye Creams", "eye-creams", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2491), null },
                    { 140, 8280L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2492), "Wallets", "wallets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2495), null },
                    { 141, 8238L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2495), "Beanies", "beanies", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2496), null },
                    { 142, 10775L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2497), "Flip Flops", "flip-flops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2498), null },
                    { 143, 8541L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2499), "Hair Bands", "hair-bands", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2500), null },
                    { 144, 15986L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2500), "Hair Accessories", "hair-accessories", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2502), null },
                    { 145, 8435L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2502), "Eyebrow Pencils", "eyebrow-pencils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2503), null },
                    { 146, 8461L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2504), "Eye Shadows", "eye-shadows", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2505), null },
                    { 147, 10066L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2506), "Makeup Sets", "makeup-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2507), null },
                    { 148, 8411L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2507), "Dungarees", "dungarees", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2509), 4 },
                    { 149, 15985L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2509), "Scalp Scrubs & Treatments", "scalp-scrubs-&-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2510), null },
                    { 150, 8556L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2511), "Lingerie Sets", "lingerie-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2512), null },
                    { 151, 9311L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2513), "Football Shirts", "football-shirts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2514), null },
                    { 152, 9335L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2514), "Tank Tops", "tank-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2516), null },
                    { 153, 9349L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2516), "Co-ords", "co-ords", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2517), null },
                    { 154, 8452L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2518), "Cover Ups", "cover-ups", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2519), null },
                    { 155, 8410L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2520), "Bodies", "bodies", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2521), null },
                    { 156, 8589L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2522), "Wellies", "wellies", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2523), null },
                    { 157, 8264L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2523), "Ponchos", "ponchos", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2524), null },
                    { 158, 8491L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2525), "Hair Sprays", "hair-sprays", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2526), null },
                    { 159, 8519L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2527), "Hair Dryers", "hair-dryers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2528), null },
                    { 160, 8504L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2529), "Hair Straighteners", "hair-straighteners", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2530), null },
                    { 161, 8558L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2530), "Shapewear", "shapewear", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2531), null },
                    { 162, 9762L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2532), "Tanning Mitts", "tanning-mitts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2533), null },
                    { 163, 10072L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2534), "Makeup Cloths", "makeup-cloths", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2536), null },
                    { 164, 15993L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2537), "Spot Treatments", "spot-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2538), null },
                    { 165, 8567L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2538), "Unitards", "unitards", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2540), 2 },
                    { 166, 8499L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2541), "Tanning Sets", "tanning-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2542), null },
                    { 167, 9743L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2543), "Eye Serums", "eye-serums", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2544), null },
                    { 168, 8549L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2544), "Foundations", "foundations", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2545), null },
                    { 169, 9786L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2546), "Hair Pomades", "hair-pomades", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2547), null },
                    { 170, 8528L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2548), "Eyeliners", "eyeliners", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2549), null },
                    { 171, 8437L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2550), "Eyebrow Kits", "eyebrow-kits", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2551), null },
                    { 172, 8563L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2552), "Slips", "slips", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2553), 2 },
                    { 173, 9308L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2554), "Compression Shorts", "compression-shorts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2555), null },
                    { 174, 15983L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2556), "Leave-in Treatments", "leave-in-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2557), null },
                    { 175, 8542L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2557), "Hair Serums", "hair-serums", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2558), null },
                    { 176, 8503L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2559), "Hair Oils", "hair-oils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2560), null },
                    { 177, 9390L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2561), "Lip Liners", "lip-liners", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2562), null },
                    { 178, 8445L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2562), "Concealers", "concealers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2564), null },
                    { 179, 8434L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2564), "Eyebrow Gels", "eyebrow-gels", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2565), null },
                    { 180, 8522L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2566), "Mascaras", "mascaras", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2567), null },
                    { 181, 8374L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2568), "Tights", "tights", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2573), null },
                    { 182, 9231L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2573), "Setting Sprays", "setting-sprays", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2574), null },
                    { 183, 8512L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2575), "Facial Cleansers", "facial-cleansers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2576), null },
                    { 184, 8568L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2577), "Underwear Sets", "underwear-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2578), null },
                    { 185, 8255L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2578), "Tie Bars", "tie-bars", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2579), null },
                    { 186, 8259L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2580), "Pocket Squares", "pocket-squares", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2581), null },
                    { 187, 9732L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2582), "Nail Clippers", "nail-clippers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2583), null },
                    { 188, 11138L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2584), "Hair Removal Creams", "hair-removal-creams", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2585), null },
                    { 189, 8551L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2586), "Hand Creams", "hand-creams", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2587), null },
                    { 190, 8575L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2587), "Swim Trunks", "swim-trunks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2589), null },
                    { 191, 9292L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2589), "Sunglasses Accessories", "sunglasses-accessories", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2590), null },
                    { 192, 10574L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2591), "Diffusers", "diffusers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2592), null },
                    { 193, 8521L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2593), "Toners", "toners", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2594), null },
                    { 194, 9232L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2594), "Curling Wands", "curling-wands", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2595), null },
                    { 195, 9825L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2596), "Dry Shampoos", "dry-shampoos", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2597), null },
                    { 196, 8515L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2598), "Hand Lotions", "hand-lotions", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2599), null },
                    { 197, 9764L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2599), "Hair Clippers", "hair-clippers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2601), null },
                    { 198, 8377L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2601), "Headscarves", "headscarves", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2604), null },
                    { 199, 8540L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2604), "Facial Oils", "facial-oils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2605), null },
                    { 200, 9776L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2606), "Eye Primers", "eye-primers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2607), null },
                    { 201, 8511L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2608), "Sponges", "sponges", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2609), null },
                    { 202, 10904L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2609), "Face + Body Sets", "face-+-body-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2611), null },
                    { 203, 8412L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2611), "Jeggings", "jeggings", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2612), null },
                    { 204, 9318L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2613), "Ski Pants", "ski-pants", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2614), null },
                    { 205, 8605L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2615), "Anklets", "anklets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2616), null },
                    { 206, 9305L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2616), "Watch Straps", "watch-straps", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2617), null },
                    { 207, 8469L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2618), "Dressing Gowns", "dressing-gowns", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2619), null },
                    { 208, 9767L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2620), "Gems", "gems", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2621), null },
                    { 209, 8446L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2621), "Beauty Sets", "beauty-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2623), null },
                    { 210, 8566L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2624), "Sports Bras", "sports-bras", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2625), null },
                    { 211, 9317L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2626), "Sweatbands", "sweatbands", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2627), null },
                    { 212, 8685L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2628), "Pencil Sharpeners", "pencil-sharpeners", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2629), null },
                    { 213, 9306L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2629), "Compression Tops", "compression-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2630), null },
                    { 214, 8467L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2631), "Robes", "robes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2632), null },
                    { 215, 9233L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2633), "Bikinis", "bikinis", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2634), null },
                    { 216, 8696L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2635), "False Nails", "false-nails", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2636), null },
                    { 217, 8530L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2636), "False Eyelashes", "false-eyelashes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2637), null },
                    { 218, 8441L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2657), "Eyebrow Stencils", "eyebrow-stencils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2658), null },
                    { 219, 8509L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2659), "Powders", "powders", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2660), null },
                    { 220, 9774L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2661), "Contour Sticks", "contour-sticks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2662), null },
                    { 221, 9726L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2662), "Contours", "contours", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2664), null },
                    { 222, 8438L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2665), "Eyebrow Tints", "eyebrow-tints", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2666), null },
                    { 223, 8450L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2667), "Body Glitters", "body-glitters", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2668), null },
                    { 224, 8555L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2669), "Boiler Suits", "boiler-suits", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2670), null },
                    { 225, 11136L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2670), "Razors & Blades", "razors-&-blades", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2671), null },
                    { 226, 8518L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2672), "Foot Lotions", "foot-lotions", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2673), null },
                    { 227, 8544L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2674), "Nail Art", "nail-art", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2675), null },
                    { 228, 9779L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2675), "Lip Treatments", "lip-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2677), null },
                    { 229, 8547L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2677), "Tweezers", "tweezers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2678), null },
                    { 230, 9746L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2679), "Masks", "masks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2680), null },
                    { 231, 11383L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2681), "Deodorant", "deodorant", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2682), null },
                    { 232, 9330L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2683), "Beard Brushes", "beard-brushes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2684), null },
                    { 233, 8490L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2685), "Hair Colours", "hair-colours", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2687), null },
                    { 234, 15991L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2687), "Styling Products", "styling-products", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2688), null },
                    { 235, 8532L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2689), "Hair Creams", "hair-creams", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2690), null },
                    { 236, 9793L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2691), "Heat Protection Sprays", "heat-protection-sprays", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2692), null },
                    { 237, 10070L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2693), "Makeup Brush Cleansers", "makeup-brush-cleansers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2694), null },
                    { 238, 8857L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2695), "Shaving Brushes", "shaving-brushes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2696), null },
                    { 239, 8239L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2696), "Laptop Cases", "laptop-cases", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2697), null },
                    { 240, 10061L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2698), "Makeup Brush Sets", "makeup-brush-sets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2699), null },
                    { 241, 8860L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2700), "Trimmers", "trimmers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2701), null },
                    { 242, 9326L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2702), "Beard Washes", "beard-washes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2703), null },
                    { 243, 8368L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2703), "Fascinators", "fascinators", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2705), null },
                    { 244, 9781L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2705), "Hand Washes", "hand-washes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2707), null },
                    { 245, 9780L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2708), "Cleansing Brushes", "cleansing-brushes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2709), null },
                    { 246, 9728L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2710), "Eyebrow Brushes", "eyebrow-brushes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2711), null },
                    { 247, 16007L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2712), "Skincare Tools & Accessories", "skincare-tools-&-accessories", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2713), null },
                    { 248, 11255L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2713), "Room Fragrances", "room-fragrances", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2714), null },
                    { 249, 9236L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2715), "Rollers", "rollers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2716), null },
                    { 250, 9731L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2717), "Dental Care Product", "dental-care-product", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2718), null },
                    { 251, 10566L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2718), "Toothbrush Holder", "toothbrush-holder", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2720), null },
                    { 252, 9312L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2720), "Compression Tights", "compression-tights", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2721), null },
                    { 253, 9298L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2722), "Running Tights", "running-tights", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2723), null },
                    { 254, 9310L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2724), "Ski Jackets", "ski-jackets", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2725), null },
                    { 255, 8661L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2729), "Gift Boxes", "gift-boxes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2731), null },
                    { 256, 9755L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2731), "Eye Masks", "eye-masks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2732), null },
                    { 257, 8456L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2733), "Creams", "creams", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2734), null },
                    { 258, 15992L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2735), "Sheet Masks", "sheet-masks", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2736), null },
                    { 259, 9742L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2736), "Shavers", "shavers", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2737), null },
                    { 260, 9785L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2738), "Beauty Storage", "beauty-storage", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2739), null },
                    { 261, 9747L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2740), "Lingerie Bodies", "lingerie-bodies", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2741), null },
                    { 262, 8501L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2741), "Facial Washes", "facial-washes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2742), null },
                    { 263, 9300L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2743), "Hair Waxes", "hair-waxes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2744), null },
                    { 264, 9744L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2745), "Skin Serums", "skin-serums", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2746), null },
                    { 265, 8463L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2747), "Eye Treatments", "eye-treatments", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2748), null },
                    { 266, 8736L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2748), "Suspenders", "suspenders", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2749), null },
                    { 267, 8678L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2750), "Cards", "cards", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2751), null },
                    { 268, 9396L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2752), "Laptop Bags", "laptop-bags", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2753), null },
                    { 269, 9345L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2754), "Body Tapes", "body-tapes", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2755), null },
                    { 270, 9333L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2755), "Sleep Aids", "sleep-aids", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2756), null },
                    { 271, 8581L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2757), "Ear Cuffs", "ear-cuffs", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2758), null },
                    { 272, 8557L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2759), "Swim Briefs", "swim-briefs", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2760), null },
                    { 273, 11256L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2760), "Crystals", "crystals", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2761), null },
                    { 274, 8261L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2762), "Arm Cuffs", "arm-cuffs", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2763), null },
                    { 275, 8737L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2764), "Suspender Belts", "suspender-belts", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2765), null },
                    { 276, 8459L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2765), "Eye Pencils", "eye-pencils", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2766), null },
                    { 277, 9792L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2767), "Colour Correctors", "colour-correctors", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2768), null },
                    { 278, 9132L, new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2769), "Shell Tops", "shell-tops", new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2770), null }
                });

            migrationBuilder.InsertData(
                table: "WeightSource",
                columns: new[] { "Id", "Weight" },
                values: new object[,]
                {
                    { 1, 0f },
                    { 2, 0.5f },
                    { 3, 1f },
                    { 4, 1.5f },
                    { 5, 2f }
                });

            migrationBuilder.InsertData(
                table: "CatalogBrandApi",
                columns: new[] { "Id", "ApiId", "ApiName", "CatalogBrandId", "CreatedTime", "LastModify", "Name" },
                values: new object[,]
                {
                    { 1, 14644L, "ASOS", 1, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3635), null, "Hollister" },
                    { 2, 53L, "ASOS", 2, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3655), null, "ASOS DESIGN" },
                    { 3, 3682L, "ASOS", 3, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3657), null, "Carhartt WIP" },
                    { 4, 2986L, "ASOS", 4, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3658), null, "Nike" },
                    { 5, 12983L, "ASOS", 5, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3659), null, "River Island" },
                    { 6, 14920L, "ASOS", 6, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3661), null, "Sixth June" },
                    { 7, 16522L, "ASOS", 7, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3662), null, "Gramicci" },
                    { 8, 12461L, "ASOS", 8, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3664), null, "Jack & Jones" },
                    { 9, 401L, "ASOS", 9, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3665), null, "Levi's" },
                    { 10, 14370L, "ASOS", 10, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3666), null, "Abercrombie & Fitch" },
                    { 11, 3253L, "ASOS", 11, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3667), null, "Dickies" },
                    { 12, 3312L, "ASOS", 12, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3668), null, "The North Face" },
                    { 13, 18L, "ASOS", 13, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3669), null, "adidas Originals" },
                    { 14, 12769L, "ASOS", 14, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3671), null, "Reclaimed Vintage" },
                    { 15, 14441L, "ASOS", 15, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3672), null, "ONLY & SONS" },
                    { 16, 14403L, "ASOS", 16, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3673), null, "Element" },
                    { 17, 2943L, "ASOS", 17, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3674), null, "Fred Perry" },
                    { 18, 75L, "ASOS", 18, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3676), null, "Ben Sherman" },
                    { 19, 14159L, "ASOS", 19, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3677), null, "Selected Homme" },
                    { 20, 16545L, "ASOS", 20, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3678), null, "Nike Golf" },
                    { 21, 15176L, "ASOS", 21, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3679), null, "Nike Running" },
                    { 22, 16123L, "ASOS", 22, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3680), null, "Hi-Tec" },
                    { 23, 3497L, "ASOS", 23, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3682), null, "Farah" },
                    { 24, 15127L, "ASOS", 24, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3684), null, "Napapijri" },
                    { 25, 12791L, "ASOS", 25, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3685), null, "AllSaints" },
                    { 26, 3029L, "ASOS", 26, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3686), null, "Tommy Hilfiger" },
                    { 27, 14758L, "ASOS", 27, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3687), null, "ADPT" },
                    { 28, 15370L, "ASOS", 28, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3689), null, "Bershka" },
                    { 29, 14512L, "ASOS", 29, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3690), null, "Le Breve" },
                    { 30, 12136L, "ASOS", 30, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3691), null, "Armani Exchange" },
                    { 31, 16236L, "ASOS", 31, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3692), null, "Topman" },
                    { 32, 691L, "ASOS", 32, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3693), null, "Superdry" },
                    { 33, 14126L, "ASOS", 33, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3695), null, "Pull&Bear" },
                    { 34, 15878L, "ASOS", 34, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3696), null, "Collusion" },
                    { 35, 12077L, "ASOS", 35, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3697), null, "BOSS by Hugo Boss" },
                    { 36, 14712L, "ASOS", 36, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3698), null, "WALK LONDON" },
                    { 37, 14550L, "ASOS", 37, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3699), null, "Teva" },
                    { 38, 14287L, "ASOS", 38, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3700), null, "Weekday" },
                    { 39, 3062L, "ASOS", 39, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3702), null, "Wrangler" },
                    { 40, 79L, "ASOS", 40, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3704), null, "Birkenstock" },
                    { 41, 396L, "ASOS", 41, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3729), null, "Lee" },
                    { 42, 14468L, "ASOS", 42, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3730), null, "Nicce" },
                    { 43, 20903L, "ASOS", 43, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3731), null, "Sol de Janeiro" },
                    { 44, 15829L, "ASOS", 44, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3732), null, "Isle of Paradise" },
                    { 45, 16511L, "ASOS", 45, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3734), null, "Rituals" },
                    { 46, 14535L, "ASOS", 46, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3735), null, "Ann Summers" },
                    { 47, 22555L, "ASOS", 47, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3736), null, "Weleda" },
                    { 48, 22705L, "ASOS", 48, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3737), null, "Erborian" },
                    { 49, 17600L, "ASOS", 49, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3738), null, "Tanologist" },
                    { 50, 3234L, "ASOS", 50, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3740), null, "Bolongaro Trevor" },
                    { 51, 17700L, "ASOS", 51, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3741), null, "HUGO BOSS Fragrances" },
                    { 52, 19157L, "ASOS", 52, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3742), null, "MAEGAN" },
                    { 53, 14096L, "ASOS", 53, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3743), null, "Obey" },
                    { 54, 18150L, "ASOS", 54, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3744), null, "Nuxe" },
                    { 55, 12577L, "ASOS", 55, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3746), null, "Caudalie" },
                    { 56, 20703L, "ASOS", 56, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3747), null, "Billie Eilish" },
                    { 57, 224L, "ASOS", 57, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3749), null, "French Connection" },
                    { 58, 16651L, "ASOS", 58, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3750), null, "Threadbare Fitness" },
                    { 59, 13289L, "ASOS", 59, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3752), null, "Sekonda" },
                    { 60, 12962L, "ASOS", 60, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3753), null, "Komono" },
                    { 61, 18054L, "ASOS", 61, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3754), null, "Valentino Bags" },
                    { 62, 15883L, "ASOS", 62, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3755), null, "NA-KD" },
                    { 63, 15586L, "ASOS", 63, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3756), null, "Simply Be" },
                    { 64, 13817L, "ASOS", 64, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3758), null, "New Look" },
                    { 65, 14538L, "ASOS", 65, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3759), null, "Threadbare" },
                    { 66, 13116L, "ASOS", 66, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3760), null, "sister jane" },
                    { 67, 15812L, "ASOS", 67, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3761), null, "Vero Moda Curve" },
                    { 68, 3663L, "ASOS", 68, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3762), null, "Vila" },
                    { 69, 15629L, "ASOS", 69, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3763), null, "Stradivarius" },
                    { 70, 15128L, "ASOS", 70, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3765), null, "Miss Selfridge" },
                    { 71, 14516L, "ASOS", 71, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3766), null, "Waven" },
                    { 72, 3180L, "ASOS", 72, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3767), null, "Dr Martens" },
                    { 73, 3672L, "ASOS", 73, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3768), null, "Timberland" },
                    { 74, 16346L, "ASOS", 74, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3771), null, "adidas performance" },
                    { 75, 12967L, "ASOS", 75, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3772), null, "ALDO" },
                    { 76, 765L, "ASOS", 76, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3773), null, "Vans" },
                    { 77, 14991L, "ASOS", 77, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3774), null, "Bondi Sands" },
                    { 78, 16246L, "ASOS", 78, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3775), null, "The Fox Tan" },
                    { 79, 20602L, "ASOS", 79, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3777), null, "Aire" },
                    { 80, 597L, "ASOS", 80, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3778), null, "Ralph Lauren" },
                    { 81, 16305L, "ASOS", 81, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3779), null, "Topshop" },
                    { 82, 62200L, "ASOS", 82, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3780), null, "Hello Sunday" },
                    { 83, 544L, "ASOS", 83, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3781), null, "Paul Smith" },
                    { 84, 15034L, "ASOS", 84, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3783), null, "Yours" },
                    { 85, 105L, "ASOS", 85, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3784), null, "Calvin Klein" },
                    { 86, 12727L, "ASOS", 86, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3785), null, "Le Specs" },
                    { 87, 3128L, "ASOS", 87, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3786), null, "Ray-Ban" },
                    { 88, 15203L, "ASOS", 88, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3787), null, "Under Armour" },
                    { 89, 767L, "ASOS", 89, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3788), null, "Versace" },
                    { 90, 439L, "ASOS", 90, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3790), null, "Magic" },
                    { 91, 13137L, "ASOS", 91, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3792), null, "True Decadence" },
                    { 92, 3594L, "ASOS", 92, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3793), null, "Polo Ralph Lauren" },
                    { 93, 499L, "ASOS", 93, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3794), null, "New Balance" },
                    { 94, 12069L, "ASOS", 94, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3795), null, "Gant" },
                    { 95, 14116L, "ASOS", 95, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3797), null, "ellesse" },
                    { 96, 13872L, "ASOS", 96, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3798), null, "PS Paul Smith" },
                    { 97, 15622L, "ASOS", 97, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3799), null, "Rip N Dip" },
                    { 98, 2988L, "ASOS", 98, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3800), null, "Reebok" },
                    { 99, 16674L, "ASOS", 99, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3801), null, "Don't Think Twice" },
                    { 100, 3060L, "ASOS", 100, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3802), null, "Emporio Armani" },
                    { 101, 16119L, "ASOS", 101, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3804), null, "& Other Stories" },
                    { 102, 14483L, "ASOS", 102, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3805), null, "True Violet" },
                    { 103, 16485L, "ASOS", 103, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3810), null, "Jaded Rose Tall" },
                    { 104, 13511L, "ASOS", 104, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3811), null, "ASOS Curve" },
                    { 105, 12542L, "ASOS", 105, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3813), null, "Accessorize" },
                    { 106, 15719L, "ASOS", 106, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3814), null, "ASOS EDITION" },
                    { 107, 14146L, "ASOS", 107, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3815), null, "Skinnydip" },
                    { 108, 14162L, "ASOS", 108, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3817), null, "ASOS Tall" },
                    { 109, 14450L, "ASOS", 109, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3819), null, "Jeffrey Campbell" },
                    { 110, 13661L, "ASOS", 110, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3820), null, "Love Moschino" },
                    { 111, 13862L, "ASOS", 111, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3821), null, "Vesper" },
                    { 112, 14012L, "ASOS", 112, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3822), null, "Monki" },
                    { 113, 15068L, "ASOS", 113, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3823), null, "River Island Plus" },
                    { 114, 15177L, "ASOS", 114, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3824), null, "Nike Training" },
                    { 115, 13850L, "ASOS", 115, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3826), null, "ONLY" },
                    { 116, 14599L, "ASOS", 116, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3827), null, "Pimkie" },
                    { 117, 14185L, "ASOS", 117, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3828), null, "Jaded Rose" },
                    { 118, 15734L, "ASOS", 118, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3829), null, "Wednesday's Girl" },
                    { 119, 12117L, "ASOS", 119, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3830), null, "Mango" },
                    { 120, 16483L, "ASOS", 120, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3831), null, "Jaded Rose Petite" },
                    { 121, 14023L, "ASOS", 121, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3833), null, "Daisy Street" },
                    { 122, 96L, "ASOS", 122, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3834), null, "Bronx" },
                    { 123, 13138L, "ASOS", 123, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3835), null, "Glamorous" },
                    { 124, 16633L, "ASOS", 124, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3836), null, "Missyempire" },
                    { 125, 21166L, "ASOS", 125, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3838), null, "Glamorous Wide Fit" },
                    { 126, 15778L, "ASOS", 126, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3863), null, "Glamorous Wide Fit" },
                    { 127, 16344L, "ASOS", 127, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3864), null, "Il Sarto" },
                    { 128, 15735L, "ASOS", 128, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3865), null, "Emory Park" },
                    { 129, 3040L, "ASOS", 129, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3866), null, "Pieces" },
                    { 130, 15720L, "ASOS", 130, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3867), null, "Nike Football" },
                    { 131, 14958L, "ASOS", 131, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3869), null, "Gym King" },
                    { 132, 746L, "ASOS", 132, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3870), null, "True Religion" },
                    { 133, 15631L, "ASOS", 133, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3871), null, "Tommy Jeans" },
                    { 134, 14334L, "ASOS", 134, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3872), null, "Helly Hansen" },
                    { 135, 15863L, "ASOS", 135, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3873), null, "Barneys Originals Plus" },
                    { 136, 16279L, "ASOS", 136, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3874), null, "Koi Footwear" },
                    { 137, 3179L, "ASOS", 137, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3876), null, "Hunter" },
                    { 138, 14353L, "ASOS", 138, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3877), null, "Buffalo" },
                    { 139, 14489L, "ASOS", 139, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3878), null, "Lee Jeans" },
                    { 140, 16500L, "ASOS", 140, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3879), null, "Barney s Original Petite" },
                    { 141, 14698L, "ASOS", 141, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3887), null, "Brave Soul Plus" },
                    { 142, 3009L, "ASOS", 142, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3888), null, "Steve Madden" },
                    { 143, 15805L, "ASOS", 143, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3890), null, "Coco & Eve" },
                    { 144, 16380L, "ASOS", 144, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3891), null, "Bleach London" },
                    { 145, 14339L, "ASOS", 145, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3892), null, "Bulldog" },
                    { 146, 14600L, "ASOS", 146, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3893), null, "Lola May" },
                    { 147, 14100L, "ASOS", 147, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3895), null, "Rains" },
                    { 148, 62251L, "ASOS", 148, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3896), null, "Made By Mitchell" },
                    { 149, 16216L, "ASOS", 149, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3897), null, "Zoe Ayla" },
                    { 150, 16637L, "ASOS", 150, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3898), null, "Pretty Lavish Curve" },
                    { 151, 15718L, "ASOS", 151, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3899), null, "Glamorous Curve" },
                    { 152, 13512L, "ASOS", 152, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3900), null, "ASOS Petite" },
                    { 153, 14513L, "ASOS", 153, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3902), null, "Champion" },
                    { 154, 15099L, "ASOS", 154, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3903), null, "My Accessories" },
                    { 155, 13881L, "ASOS", 155, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3904), null, "Volcom" },
                    { 156, 3182L, "ASOS", 156, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3905), null, "New Era" },
                    { 157, 15849L, "ASOS", 157, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3906), null, "Puma Golf" },
                    { 158, 14751L, "ASOS", 158, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3909), null, "A Star Is Born" },
                    { 159, 16711L, "ASOS", 159, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3910), null, "VAI21" },
                    { 160, 22855L, "ASOS", 160, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3911), null, "DIFF Eyewear" },
                    { 161, 712L, "ASOS", 161, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3912), null, "Ted Baker" },
                    { 162, 716L, "ASOS", 162, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3914), null, "TFNC" },
                    { 163, 15368L, "ASOS", 163, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3915), null, "Maya" },
                    { 164, 299L, "ASOS", 164, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3916), null, "Hummel" },
                    { 165, 13688L, "ASOS", 165, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3917), null, "Asics" },
                    { 166, 16727L, "ASOS", 166, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3918), null, "On Running" },
                    { 167, 14269L, "ASOS", 167, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3919), null, "Jordan" },
                    { 168, 589L, "ASOS", 168, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3921), null, "Puma" },
                    { 169, 13687L, "ASOS", 169, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3922), null, "Native Youth" },
                    { 170, 391L, "ASOS", 170, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3923), null, "Lacoste" },
                    { 171, 16082L, "ASOS", 171, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3924), null, "Versace Jeans Couture" },
                    { 172, 15059L, "ASOS", 172, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3926), null, "Columbia" },
                    { 173, 16333L, "ASOS", 173, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3927), null, "My Accessories Curve" },
                    { 174, 13927L, "ASOS", 174, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3928), null, "Noisy May" },
                    { 175, 16649L, "ASOS", 175, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3930), null, "BOSS Bodywear" },
                    { 176, 14969L, "ASOS", 176, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3931), null, "DesignB London" },
                    { 177, 14955L, "ASOS", 177, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3932), null, "Loungeable" },
                    { 178, 15146L, "ASOS", 178, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3934), null, "Boux Avenue" },
                    { 179, 16568L, "ASOS", 179, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3935), null, "Schuh" },
                    { 180, 752L, "ASOS", 180, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3936), null, "UGG" },
                    { 181, 15139L, "ASOS", 181, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3937), null, "HUGO" },
                    { 182, 12927L, "ASOS", 182, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3938), null, "Sorel" },
                    { 183, 22005L, "ASOS", 183, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3939), null, "Charles & Keith" },
                    { 184, 17855L, "ASOS", 184, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3941), null, "Monday Haircare" },
                    { 185, 13126L, "ASOS", 185, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3942), null, "Herschel Supply Co" },
                    { 186, 12144L, "ASOS", 186, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3943), null, "Tangle Teezer" },
                    { 187, 14059L, "ASOS", 187, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3944), null, "Santa Cruz" },
                    { 188, 16183L, "ASOS", 188, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3946), null, "Lullabellz" },
                    { 189, 16471L, "ASOS", 189, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3947), null, "NEOM" },
                    { 190, 16477L, "ASOS", 190, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3948), null, "Aveeno" },
                    { 191, 16131L, "ASOS", 191, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3949), null, "Karl Kani" },
                    { 192, 3098L, "ASOS", 192, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3951), null, "Vero Moda" },
                    { 193, 14076L, "ASOS", 193, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3952), null, "Neon Rose" },
                    { 194, 15994L, "ASOS", 194, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3954), null, "Neon Rose Plus" },
                    { 195, 160L, "ASOS", 195, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3955), null, "DKNY" },
                    { 196, 3119L, "ASOS", 196, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3956), null, "Gossard" },
                    { 197, 15807L, "ASOS", 197, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3957), null, "The Couture Club" },
                    { 198, 13510L, "ASOS", 198, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3958), null, "ASOS Maternity" },
                    { 199, 14042L, "ASOS", 199, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3959), null, "Bluebella" },
                    { 200, 16631L, "ASOS", 200, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3961), null, "ASOS LUXE" },
                    { 201, 16508L, "ASOS", 201, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3962), null, "LAUREN by RALPH LAUREN" },
                    { 202, 15882L, "ASOS", 202, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3968), null, "Lindex" },
                    { 203, 12255L, "ASOS", 203, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3969), null, "Orelia" },
                    { 204, 20202L, "ASOS", 204, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3971), null, "Esmee Curve" },
                    { 205, 3738L, "ASOS", 205, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3972), null, "Dune" },
                    { 206, 12840L, "ASOS", 206, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3973), null, "Selected" },
                    { 207, 15687L, "ASOS", 207, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3974), null, "Flounce London" },
                    { 208, 12205L, "ASOS", 208, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3975), null, "LAB Series" },
                    { 209, 3379L, "ASOS", 209, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3978), null, "Elemis" },
                    { 210, 20551L, "ASOS", 210, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3979), null, "Flamingo" },
                    { 211, 22805L, "ASOS", 211, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3980), null, "Doll Beauty" },
                    { 212, 20701L, "ASOS", 212, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4005), null, "Revolution Man" },
                    { 213, 15563L, "ASOS", 213, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4006), null, "Apothecary 87" },
                    { 214, 12930L, "ASOS", 214, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4007), null, "bareMinerals" },
                    { 215, 15585L, "ASOS", 215, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4008), null, "Murdock London" },
                    { 216, 16337L, "ASOS", 216, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4009), null, "Style Cheat" },
                    { 217, 14988L, "ASOS", 217, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4011), null, "Amy Lynn" },
                    { 218, 12507L, "ASOS", 218, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4012), null, "Calvin Klein Jeans" },
                    { 219, 15715L, "ASOS", 219, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4013), null, "Barbour International" },
                    { 220, 14630L, "ASOS", 220, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4014), null, "Beauty Extras" },
                    { 221, 16338L, "ASOS", 221, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4016), null, "Planks" },
                    { 222, 15643L, "ASOS", 222, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4017), null, "ASOS 4505" },
                    { 223, 12113L, "ASOS", 223, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4018), null, "Berghaus" },
                    { 224, 16546L, "ASOS", 224, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4019), null, "Be Mine Wide Fit" },
                    { 225, 16059L, "ASOS", 225, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4021), null, "4th & Reckless" },
                    { 226, 62151L, "ASOS", 226, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4023), null, "Sachajuan" },
                    { 227, 15747L, "ASOS", 227, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4024), null, "HIIT" },
                    { 228, 13078L, "ASOS", 228, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4025), null, "Nars" },
                    { 229, 13527L, "ASOS", 229, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4026), null, "Revolution" },
                    { 230, 15898L, "ASOS", 230, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4027), null, "Philip Kingsley" },
                    { 231, 16190L, "ASOS", 231, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4029), null, "Cantu" },
                    { 232, 16264L, "ASOS", 232, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4030), null, "Wrangler Plus" },
                    { 233, 15230L, "ASOS", 233, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4031), null, "River Island Petite" },
                    { 234, 22659L, "ASOS", 234, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4032), null, "Michael Kors Fragrances" },
                    { 235, 13488L, "ASOS", 235, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4033), null, "Issey Miyake" },
                    { 236, 62061L, "ASOS", 236, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4034), null, "Megababe" },
                    { 237, 16205L, "ASOS", 237, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4036), null, "Crocs" },
                    { 238, 612L, "ASOS", 238, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4037), null, "Replay" },
                    { 239, 3272L, "ASOS", 239, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4038), null, "Speedo" },
                    { 240, 16670L, "ASOS", 240, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4039), null, "Bailey Rose" },
                    { 241, 15441L, "ASOS", 241, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4040), null, "Influence Plus" },
                    { 242, 13632L, "ASOS", 242, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4045), null, "Frock and Frill" },
                    { 243, 21555L, "ASOS", 243, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4046), null, "Something New" },
                    { 244, 14565L, "ASOS", 244, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4047), null, "NaaNaa" },
                    { 245, 20650L, "ASOS", 245, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4048), null, "e.l.f." },
                    { 246, 15818L, "ASOS", 246, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4049), null, "Bobbi Brown" },
                    { 247, 740L, "ASOS", 247, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4051), null, "Too Faced Cosmetics" },
                    { 248, 16543L, "ASOS", 248, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4052), null, "Mylee" },
                    { 249, 16551L, "ASOS", 249, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4053), null, "Acnecide" },
                    { 250, 16552L, "ASOS", 250, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4054), null, "Sunday Riley" },
                    { 251, 15943L, "ASOS", 251, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4055), null, "Laura Mercier" },
                    { 252, 15939L, "ASOS", 252, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4057), null, "Origins" },
                    { 253, 13931L, "ASOS", 253, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4058), null, "Brave Soul" },
                    { 254, 14989L, "ASOS", 254, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4059), null, "UNIQUE21" },
                    { 255, 20750L, "ASOS", 255, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4060), null, "Cherry Beach" },
                    { 256, 21960L, "ASOS", 256, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4061), null, "GUESS Originals" },
                    { 257, 21706L, "ASOS", 257, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4062), null, "PACSUN" },
                    { 258, 18850L, "ASOS", 258, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4063), null, "First Distraction" },
                    { 259, 14434L, "ASOS", 259, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4065), null, "L'Oreal" },
                    { 260, 16340L, "ASOS", 260, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4067), null, "Beauut" },
                    { 261, 13679L, "ASOS", 261, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4068), null, "Influence" },
                    { 262, 15950L, "ASOS", 262, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4069), null, "Nike Basketball" },
                    { 263, 21661L, "ASOS", 263, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4070), null, "Commando" },
                    { 264, 14490L, "ASOS", 264, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4071), null, "Good For Nothing" },
                    { 265, 16377L, "ASOS", 265, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4073), null, "We Are We Wear" },
                    { 266, 14607L, "ASOS", 266, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4074), null, "Flook" },
                    { 267, 15301L, "ASOS", 267, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4075), null, "Lace & Beads" },
                    { 268, 14369L, "ASOS", 268, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4076), null, "Parisian" },
                    { 269, 16715L, "ASOS", 269, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4077), null, "Urban Revivo" },
                    { 270, 12512L, "ASOS", 270, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4079), null, "Skechers" },
                    { 271, 13575L, "ASOS", 271, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4080), null, "Little Mistress" },
                    { 272, 166L, "ASOS", 272, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4081), null, "Dr Denim" },
                    { 273, 16554L, "ASOS", 273, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4082), null, "SNDYS" },
                    { 274, 12732L, "ASOS", 274, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4083), null, "Barbour" },
                    { 275, 16623L, "ASOS", 275, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4085), null, "Salomon" },
                    { 276, 14823L, "ASOS", 276, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4087), null, "Public Desire" },
                    { 277, 15723L, "ASOS", 277, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4088), null, "adidas Golf" },
                    { 278, 582L, "ASOS", 278, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4089), null, "Pretty Polly" },
                    { 279, 12359L, "ASOS", 279, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4090), null, "Mama.licious" },
                    { 280, 3563L, "ASOS", 280, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4091), null, "Oakley" },
                    { 281, 3624L, "ASOS", 281, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4093), null, "Roxy" },
                    { 282, 15129L, "ASOS", 282, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4094), null, "Miss Selfridge Petite" },
                    { 283, 13889L, "ASOS", 283, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4095), null, "Quay Australia" },
                    { 284, 16641L, "ASOS", 284, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4096), null, "Lapp The Brand" },
                    { 285, 15648L, "ASOS", 285, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4097), null, "TYPO" },
                    { 286, 16657L, "ASOS", 286, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4099), null, "Morphe" },
                    { 287, 14664L, "ASOS", 287, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4100), null, "Brave Soul Tall" },
                    { 288, 15817L, "ASOS", 288, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4101), null, "Clinique" },
                    { 289, 15796L, "ASOS", 289, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4102), null, "MAC" },
                    { 290, 15407L, "ASOS", 290, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4103), null, "Soul Star" },
                    { 291, 13027L, "ASOS", 291, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4104), null, "Nip+Fab" },
                    { 292, 3470L, "ASOS", 292, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4106), null, "Muubaa" },
                    { 293, 15841L, "ASOS", 293, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4108), null, "Dr Dennis Gross" },
                    { 294, 14722L, "ASOS", 294, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4109), null, "EA7" },
                    { 295, 16445L, "ASOS", 295, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4110), null, "Revolution Pro" },
                    { 296, 15379L, "ASOS", 296, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4111), null, "Invisibobble" },
                    { 297, 22605L, "ASOS", 297, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4137), null, "Object Tall" },
                    { 298, 15928L, "ASOS", 298, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4139), null, "THE INKEY LIST" },
                    { 299, 15461L, "ASOS", 299, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4140), null, "L'Oreal Men Expert" },
                    { 300, 16360L, "ASOS", 300, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4141), null, "Public Desire Wide Fit" },
                    { 301, 23255L, "ASOS", 301, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4142), null, "The Beauty Crop" },
                    { 302, 21502L, "ASOS", 302, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4143), null, "AZALEA WANG" },
                    { 303, 15665L, "ASOS", 303, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4145), null, "Shea Moisture" },
                    { 304, 22955L, "ASOS", 304, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4146), null, "Luna" },
                    { 305, 16355L, "ASOS", 305, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4147), null, "4th & Reckless Petite" },
                    { 306, 16354L, "ASOS", 306, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4148), null, "4th & Reckless Tall" },
                    { 307, 22159L, "ASOS", 307, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4149), null, "4th & Reckless Plus" },
                    { 308, 16478L, "ASOS", 308, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4151), null, "OLAPLEX" },
                    { 309, 15751L, "ASOS", 309, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4152), null, "Forever New Petite" },
                    { 310, 15709L, "ASOS", 310, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4154), null, "Flounce London Plus" },
                    { 311, 14459L, "ASOS", 311, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4155), null, "Starlet" },
                    { 312, 14510L, "ASOS", 312, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4157), null, "Never Fully Dressed" },
                    { 313, 15058L, "ASOS", 313, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4158), null, "Daisy Street Plus" },
                    { 314, 22906L, "ASOS", 314, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4159), null, "JDY Tall" },
                    { 315, 22905L, "ASOS", 315, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4160), null, "JDY Petite" },
                    { 316, 131L, "ASOS", 316, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4161), null, "Converse" },
                    { 317, 12279L, "ASOS", 317, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4162), null, "Gap" },
                    { 318, 18500L, "ASOS", 318, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4163), null, "ASOS WEEKEND COLLECTIVE" },
                    { 319, 17802L, "ASOS", 319, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4165), null, "Revolution Hair" },
                    { 320, 13621L, "ASOS", 320, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4166), null, "Quiksilver" },
                    { 321, 15700L, "ASOS", 321, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4167), null, "AFRM" },
                    { 322, 15831L, "ASOS", 322, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4168), null, "Twisted Tailor" },
                    { 323, 15619L, "ASOS", 323, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4169), null, "Forever New" },
                    { 324, 62059L, "ASOS", 324, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4171), null, "Daska" },
                    { 325, 16173L, "ASOS", 325, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4172), null, "Vila Petite" },
                    { 326, 21657L, "ASOS", 326, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4174), null, "Kaiia" },
                    { 327, 14251L, "ASOS", 327, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4175), null, "Ripcurl" },
                    { 328, 16575L, "ASOS", 328, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4176), null, "AsYou" },
                    { 329, 15360L, "ASOS", 329, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4178), null, "Hunkemoller" },
                    { 330, 16696L, "ASOS", 330, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4179), null, "Valentino Bags" },
                    { 331, 15902L, "ASOS", 331, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4180), null, "SIMMI Shoes" },
                    { 332, 22505L, "ASOS", 332, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4181), null, "IIQUAL" },
                    { 333, 20702L, "ASOS", 333, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4182), null, "Easy Tiger" },
                    { 334, 22305L, "ASOS", 334, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4183), null, "It’s Now Cool" },
                    { 335, 16322L, "ASOS", 335, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4185), null, "Never Fully Dressed Plus" },
                    { 336, 13942L, "ASOS", 336, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4186), null, "The Ragged Priest" },
                    { 337, 16269L, "ASOS", 337, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4187), null, "Cotton:On" },
                    { 338, 18653L, "ASOS", 338, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4188), null, "JJXX" },
                    { 339, 15900L, "ASOS", 339, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4189), null, "In The Style" },
                    { 340, 13073L, "ASOS", 340, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4190), null, "Lyle & Scott" },
                    { 341, 16191L, "ASOS", 341, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4192), null, "In The Style Plus" },
                    { 342, 14164L, "ASOS", 342, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4193), null, "SikSilk" },
                    { 343, 15828L, "ASOS", 343, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4200), null, "ONLY Tall" },
                    { 344, 15685L, "ASOS", 344, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4201), null, "Be Mine" },
                    { 345, 13214L, "ASOS", 345, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4202), null, "Marshall Artist" },
                    { 346, 16650L, "ASOS", 346, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4204), null, "HUGO Bodywear" },
                    { 347, 17650L, "ASOS", 347, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4205), null, "LUSH" },
                    { 348, 13727L, "ASOS", 348, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4206), null, "Malin + Goetz" },
                    { 349, 13886L, "ASOS", 349, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4207), null, "Closet London" },
                    { 350, 13644L, "ASOS", 350, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4208), null, "47 Brand" },
                    { 351, 16724L, "ASOS", 351, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4210), null, "KAYALI" },
                    { 352, 22155L, "ASOS", 352, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4211), null, "Floral Street" },
                    { 353, 62062L, "ASOS", 353, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4212), null, "Messy Weekend" },
                    { 354, 13652L, "ASOS", 354, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4213), null, "HUF" },
                    { 355, 20612L, "ASOS", 355, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4214), null, "Narciso Rodriguez" },
                    { 356, 14379L, "ASOS", 356, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4215), null, "AAPE BY A BATHING APE®" },
                    { 357, 3008L, "ASOS", 357, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4217), null, "Billabong" },
                    { 358, 16592L, "ASOS", 358, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4218), null, "River Island Tall" },
                    { 359, 21000L, "ASOS", 359, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4219), null, "Curlsmith" },
                    { 360, 16547L, "ASOS", 360, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4221), null, "Living Proof" },
                    { 361, 21755L, "ASOS", 361, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4222), null, "ARKIVE" },
                    { 362, 2994L, "ASOS", 362, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4224), null, "ghd" },
                    { 363, 18904L, "ASOS", 363, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4225), null, "Face Halo" },
                    { 364, 14291L, "ASOS", 364, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4226), null, "Foreo" },
                    { 365, 15741L, "ASOS", 365, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4227), null, "Sand & Sky" },
                    { 366, 15919L, "ASOS", 366, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4228), null, "Estee Lauder" },
                    { 367, 15247L, "ASOS", 367, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4229), null, "The Ordinary" },
                    { 368, 16585L, "ASOS", 368, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4230), null, "Simmi Wide Fit" },
                    { 369, 16114L, "ASOS", 369, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4232), null, "Revolution Skincare" },
                    { 370, 2955L, "ASOS", 370, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4233), null, "Spanx" },
                    { 371, 13987L, "ASOS", 371, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4234), null, "Y.A.S" },
                    { 372, 13943L, "ASOS", 372, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4235), null, "Lavish Alice" },
                    { 373, 16204L, "ASOS", 373, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4236), null, "Pretty Lavish" },
                    { 374, 16710L, "ASOS", 374, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4237), null, "Simmi Clothing" },
                    { 375, 16638L, "ASOS", 375, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4239), null, "Collective the Label Curve" },
                    { 376, 16308L, "ASOS", 376, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4240), null, "Topshop Tall" },
                    { 377, 14304L, "ASOS", 377, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4242), null, "Vero Moda Petite" },
                    { 378, 16487L, "ASOS", 378, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4243), null, "Urban Threads Petite" },
                    { 379, 15395L, "ASOS", 379, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4244), null, "Heartbreak" },
                    { 380, 20611L, "ASOS", 380, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4246), null, "Night Addict Plus" },
                    { 381, 15910L, "ASOS", 381, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4247), null, "Influence Maternity" },
                    { 382, 14457L, "ASOS", 382, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4262), null, "Vero Moda Tall" },
                    { 383, 3606L, "ASOS", 383, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4264), null, "Whistles" },
                    { 384, 62550L, "ASOS", 384, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4265), null, "Hugo Red" },
                    { 385, 12090L, "ASOS", 385, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4266), null, "BOSS Orange" },
                    { 386, 3454L, "ASOS", 386, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4267), null, "Free People" },
                    { 387, 443L, "ASOS", 387, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4268), null, "Marc Jacobs" },
                    { 388, 15224L, "ASOS", 388, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4270), null, "Dermalogica" },
                    { 389, 21169L, "ASOS", 389, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4271), null, "Dr Denim Plus" },
                    { 390, 15739L, "ASOS", 390, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4272), null, "Barber Pro" },
                    { 391, 22355L, "ASOS", 391, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4273), null, "Dsquared" },
                    { 392, 22757L, "ASOS", 392, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4274), null, "Petit Moments" },
                    { 393, 16683L, "ASOS", 393, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4278), null, "Extro & Vert" },
                    { 394, 16144L, "ASOS", 394, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4281), null, "ONLY Curve" },
                    { 395, 22657L, "ASOS", 395, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4282), null, "Whistles Petite" },
                    { 396, 16307L, "ASOS", 396, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4283), null, "Topshop Petite" },
                    { 397, 16394L, "ASOS", 397, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4284), null, "I Saw It First" },
                    { 398, 479L, "ASOS", 398, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4286), null, "Morgan" },
                    { 399, 14230L, "ASOS", 399, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4287), null, "Uppercut Deluxe" },
                    { 400, 3352L, "ASOS", 400, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4288), null, "Clarks Originals" },
                    { 401, 13579L, "ASOS", 401, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4289), null, "AJ Morgan" },
                    { 402, 673L, "ASOS", 402, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4290), null, "Spitfire" },
                    { 403, 16434L, "ASOS", 403, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4291), null, "Labelrail" },
                    { 404, 12456L, "ASOS", 404, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4293), null, "Pretty Green" },
                    { 405, 15488L, "ASOS", 405, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4294), null, "Calvin Klein Golf" },
                    { 406, 17952L, "ASOS", 406, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4295), null, "Pieces Plus" },
                    { 407, 62400L, "ASOS", 407, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4296), null, "Milk Makeup" },
                    { 408, 3498L, "ASOS", 408, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4297), null, "Benefit" },
                    { 409, 15020L, "ASOS", 409, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4299), null, "Kitsch" },
                    { 410, 17900L, "ASOS", 410, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4300), null, "Urban Classics" },
                    { 411, 14821L, "ASOS", 411, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4302), null, "Hope & Ivy" },
                    { 412, 15672L, "ASOS", 412, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4303), null, "BOSS Athleisure" },
                    { 413, 13991L, "ASOS", 413, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4304), null, "JDY" },
                    { 414, 202L, "ASOS", 414, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4305), null, "Fila" },
                    { 415, 12092L, "ASOS", 415, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4307), null, "BOSS Green" },
                    { 416, 14564L, "ASOS", 416, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4308), null, "Object" },
                    { 417, 15000L, "ASOS", 417, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4309), null, "Von Dutch" },
                    { 418, 16506L, "ASOS", 418, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4310), null, "Charlotte Tilbury" },
                    { 419, 15973L, "ASOS", 419, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4311), null, "Dr.Jart+" },
                    { 420, 20201L, "ASOS", 420, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4313), null, "The Frolic" },
                    { 421, 16525L, "ASOS", 421, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4314), null, "Annorlunda" },
                    { 422, 20300L, "ASOS", 422, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4315), null, "Threadbare Plus Fitness" },
                    { 423, 16097L, "ASOS", 423, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4316), null, "Collective The Label" },
                    { 424, 62058L, "ASOS", 424, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4317), null, "Girls Crew" },
                    { 425, 17857L, "ASOS", 425, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4319), null, "Mario Badescu" },
                    { 426, 16412L, "ASOS", 426, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4320), null, "Collective The Label Petite" },
                    { 427, 15668L, "ASOS", 427, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4322), null, "Le Mini Macaron" },
                    { 428, 14730L, "ASOS", 428, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4323), null, "Noak" },
                    { 429, 13891L, "ASOS", 429, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4324), null, "South Beach" },
                    { 430, 15921L, "ASOS", 430, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4326), null, "Barbour Beacon" },
                    { 431, 274L, "ASOS", 431, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4327), null, "Havaianas" },
                    { 432, 16530L, "ASOS", 432, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4328), null, "Esmée" },
                    { 433, 16243L, "ASOS", 433, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4329), null, "Viggo" },
                    { 434, 14139L, "ASOS", 434, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4331), null, "Moon Boot" },
                    { 435, 62412L, "ASOS", 435, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4332), null, "Drybar" },
                    { 436, 62406L, "ASOS", 436, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4333), null, "Kylie Cosmetics by Kylie Jenner" },
                    { 437, 21857L, "ASOS", 437, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4334), null, "Neutrogena" },
                    { 438, 16636L, "ASOS", 438, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4335), null, "Threadbare Maternity" },
                    { 439, 14345L, "ASOS", 439, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4337), null, "Bardot" },
                    { 440, 17852L, "ASOS", 440, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4338), null, "In The Style Petite" },
                    { 441, 17858L, "ASOS", 441, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4339), null, "In The Style Tall" },
                    { 442, 62051L, "ASOS", 442, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4340), null, "Circus NY" },
                    { 443, 22706L, "ASOS", 443, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4341), null, "Good News" },
                    { 444, 16016L, "ASOS", 444, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4344), null, "Anaya" },
                    { 445, 16007L, "ASOS", 445, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4345), null, "Candypants" },
                    { 446, 16587L, "ASOS", 446, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4346), null, "Anaya Tall" },
                    { 447, 21150L, "ASOS", 447, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4347), null, "Closet London Tall" },
                    { 448, 16400L, "ASOS", 448, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4348), null, "Anaya Petite" },
                    { 449, 20502L, "ASOS", 449, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4350), null, "Naked Wardrobe" },
                    { 450, 14688L, "ASOS", 450, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4351), null, "Babyliss" },
                    { 451, 14041L, "ASOS", 451, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4352), null, "Classics 77" },
                    { 452, 16565L, "ASOS", 452, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4353), null, "ASOS Dark Future" },
                    { 453, 19952L, "ASOS", 453, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4357), null, "COSRX" },
                    { 454, 15295L, "ASOS", 454, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4359), null, "frank body" },
                    { 455, 15957L, "ASOS", 455, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4360), null, "Shay & Blue" },
                    { 456, 3018L, "ASOS", 456, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4361), null, "Rimmel London" },
                    { 457, 13852L, "ASOS", 457, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4362), null, "Chelsea Peers" },
                    { 458, 15753L, "ASOS", 458, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4363), null, "Raid Wide Fit" },
                    { 459, 21350L, "ASOS", 459, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4364), null, "Coola" },
                    { 460, 23105L, "ASOS", 460, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4366), null, "Six Stories" },
                    { 461, 18250L, "ASOS", 461, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4368), null, "WetBrush" },
                    { 462, 15390L, "ASOS", 462, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4369), null, "OUAI" },
                    { 463, 20600L, "ASOS", 463, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4370), null, "Topshop Curve" },
                    { 464, 15010L, "ASOS", 464, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4371), null, "Office" },
                    { 465, 66L, "ASOS", 465, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4419), null, "Barry M" },
                    { 466, 14884L, "ASOS", 466, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4421), null, "NYX Professional Makeup" },
                    { 467, 16719L, "ASOS", 467, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4422), null, "Huda Beauty" },
                    { 468, 16498L, "ASOS", 468, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4423), null, "Beauty Works" },
                    { 469, 18800L, "ASOS", 469, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4425), null, "Kristin Ess" },
                    { 470, 13844L, "ASOS", 470, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4427), null, "New Look Plus" },
                    { 471, 16391L, "ASOS", 471, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4428), null, "Femme Luxe" },
                    { 472, 16443L, "ASOS", 472, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4429), null, "Noisy May Curve" },
                    { 473, 16634L, "ASOS", 473, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4430), null, "Vila Curve" },
                    { 474, 16232L, "ASOS", 474, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4435), null, "Shiseido" },
                    { 475, 16537L, "ASOS", 475, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4436), null, "Threadbare Tall" },
                    { 476, 15169L, "ASOS", 476, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4438), null, "ASOS MADE IN" },
                    { 477, 16047L, "ASOS", 477, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4439), null, "Tommy Hilfiger Sport" },
                    { 478, 16470L, "ASOS", 478, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4441), null, "I Heart Revolution" },
                    { 479, 16398L, "ASOS", 479, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4442), null, "Anaya Plus" },
                    { 480, 259L, "ASOS", 480, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4444), null, "Guess" },
                    { 481, 18052L, "ASOS", 481, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4445), null, "Madewell" },
                    { 482, 16553L, "ASOS", 482, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4446), null, "Cetaphil" },
                    { 483, 16128L, "ASOS", 483, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4447), null, "New Girl Order Curve" },
                    { 484, 17951L, "ASOS", 484, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4448), null, "Pieces Petite" },
                    { 485, 15145L, "ASOS", 485, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4449), null, "Raid" },
                    { 486, 21557L, "ASOS", 486, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4451), null, "Coney Island Picnic" },
                    { 487, 3192L, "ASOS", 487, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4452), null, "this works" },
                    { 488, 3212L, "ASOS", 488, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4453), null, "Superga" },
                    { 489, 13685L, "ASOS", 489, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4455), null, "Protest" },
                    { 490, 17L, "ASOS", 490, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4456), null, "adidas" },
                    { 491, 21559L, "ASOS", 491, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4457), null, "Bye Bra" },
                    { 492, 20500L, "ASOS", 492, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4458), null, "Chelsea Peers Tall" },
                    { 493, 20454L, "ASOS", 493, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4459), null, "Chelsea Peers Petite" },
                    { 494, 14544L, "ASOS", 494, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4461), null, "Dr Paw Paw" },
                    { 495, 3190L, "ASOS", 495, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4463), null, "Pixi" },
                    { 496, 20501L, "ASOS", 496, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4464), null, "Vero Moda Maternity" },
                    { 497, 625L, "ASOS", 497, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4465), null, "Rocketdog" },
                    { 498, 15214L, "ASOS", 498, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4466), null, "Vesper Tall" },
                    { 499, 16486L, "ASOS", 499, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4467), null, "Zemeta" },
                    { 500, 16557L, "ASOS", 500, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4469), null, "DesignB London Curve" },
                    { 501, 17953L, "ASOS", 501, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4470), null, "Bolongaro Trevor Sport" },
                    { 502, 110L, "ASOS", 502, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4471), null, "Casio" },
                    { 503, 298L, "ASOS", 503, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4472), null, "BOSS" },
                    { 504, 504L, "ASOS", 504, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4473), null, "Nixon" },
                    { 505, 15237L, "ASOS", 505, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4474), null, "Nobody's Child" },
                    { 506, 20850L, "ASOS", 506, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4475), null, "Tammy Girl" },
                    { 507, 16427L, "ASOS", 507, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4477), null, "ASRA" },
                    { 508, 156L, "ASOS", 508, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4478), null, "Diesel" },
                    { 509, 16535L, "ASOS", 509, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4479), null, "Threadbare Curve" },
                    { 510, 16536L, "ASOS", 510, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4480), null, "Threadbare Petite" },
                    { 511, 262L, "ASOS", 511, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4482), null, "H by Hudson" },
                    { 512, 16497L, "ASOS", 512, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4484), null, "ICONIC LONDON" },
                    { 513, 12203L, "ASOS", 513, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4485), null, "Juicy Couture" },
                    { 514, 16706L, "ASOS", 514, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4486), null, "Wild Lovers" },
                    { 515, 16166L, "ASOS", 515, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4487), null, "Garnier" },
                    { 516, 15708L, "ASOS", 516, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4488), null, "Tan Luxe" },
                    { 517, 20251L, "ASOS", 517, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4490), null, "The Frolic Plus" },
                    { 518, 777L, "ASOS", 518, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4491), null, "Wahl" },
                    { 519, 16138L, "ASOS", 519, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4492), null, "CeraVe" },
                    { 520, 16266L, "ASOS", 520, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4493), null, "Native Youth Plus" },
                    { 521, 14448L, "ASOS", 521, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4494), null, "Noisy May Petite" },
                    { 522, 23205L, "ASOS", 522, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4496), null, "Patchology" },
                    { 523, 15393L, "ASOS", 523, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4497), null, "Alpha-H" },
                    { 524, 15600L, "ASOS", 524, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4498), null, "Maya Plus" },
                    { 525, 14810L, "ASOS", 525, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4499), null, "Maya Tall" },
                    { 526, 15503L, "ASOS", 526, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4500), null, "LEVIS SKATEBOARDING" },
                    { 527, 15833L, "ASOS", 527, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4501), null, "Urban Threads" },
                    { 528, 178L, "ASOS", 528, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4504), null, "Elegant Touch" },
                    { 529, 196L, "ASOS", 529, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4505), null, "Eylure" },
                    { 530, 16315L, "ASOS", 530, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4506), null, "Lace & Beads Plus" },
                    { 531, 14248L, "ASOS", 531, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4507), null, "New Look Tall" },
                    { 532, 16655L, "ASOS", 532, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4513), null, "Threadbare Fitness Tall" },
                    { 533, 16654L, "ASOS", 533, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4514), null, "Threadbare Fitness Petite" },
                    { 534, 15140L, "ASOS", 534, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4515), null, "Embryolisse" },
                    { 535, 14327L, "ASOS", 535, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4516), null, "Maya Petite" },
                    { 536, 16529L, "ASOS", 536, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4518), null, "Iisla & Bird" },
                    { 537, 16421L, "ASOS", 537, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4519), null, "Real Techniques" },
                    { 538, 14176L, "ASOS", 538, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4520), null, "Truffle Collection" },
                    { 539, 14590L, "ASOS", 539, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4521), null, "Missguided" },
                    { 540, 15770L, "ASOS", 540, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4522), null, "Fashionkilla" },
                    { 541, 21554L, "ASOS", 541, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4523), null, "Edikted" },
                    { 542, 14714L, "ASOS", 542, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4525), null, "In Your Dreams" },
                    { 543, 20150L, "ASOS", 543, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4526), null, "Pull&Bear Tall" },
                    { 544, 14119L, "ASOS", 544, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4527), null, "New Look Petite" },
                    { 545, 16386L, "ASOS", 545, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4529), null, "American Eagle" },
                    { 546, 15307L, "ASOS", 546, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4530), null, "Gilly Hicks" },
                    { 547, 3492L, "ASOS", 547, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4531), null, "FCUK" },
                    { 548, 12833L, "ASOS", 548, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4532), null, "Maurie & Eve" },
                    { 549, 16494L, "ASOS", 549, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4534), null, "Stan Ray" },
                    { 550, 20705L, "ASOS", 550, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4535), null, "MIM" },
                    { 551, 13849L, "ASOS", 551, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4568), null, "Vogue" },
                    { 552, 21958L, "ASOS", 552, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4569), null, "Dr. Barbara Sturm" },
                    { 553, 12431L, "ASOS", 553, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4570), null, "Kickers" },
                    { 554, 12477L, "ASOS", 554, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4571), null, "We The Free by Free People" },
                    { 555, 16589L, "ASOS", 555, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4572), null, "KAVU" },
                    { 556, 16378L, "ASOS", 556, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4574), null, "Wednesday's Girl Maternity" },
                    { 557, 21200L, "ASOS", 557, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4575), null, "Nobody’s Child Petite" },
                    { 558, 16682L, "ASOS", 558, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4576), null, "Nobody's Child Plus" },
                    { 559, 12311L, "ASOS", 559, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4577), null, "Base London" },
                    { 560, 16319L, "ASOS", 560, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4578), null, "Les Girls Les Boys" },
                    { 561, 15869L, "ASOS", 561, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4579), null, "Elsie & Fred" },
                    { 562, 16339L, "ASOS", 562, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4582), null, "M.A.D Beauty" },
                    { 563, 15757L, "ASOS", 563, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4583), null, "Madden Girl" },
                    { 564, 20452L, "ASOS", 564, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4584), null, "Kanya London" },
                    { 565, 15350L, "ASOS", 565, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4585), null, "Ultrasun" },
                    { 566, 16507L, "ASOS", 566, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4587), null, "Sun Bum" },
                    { 567, 14555L, "ASOS", 567, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4591), null, "Lottie" },
                    { 568, 20607L, "ASOS", 568, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4592), null, "Tatti Lashes" },
                    { 569, 12191L, "ASOS", 569, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4593), null, "Ed Hardy" },
                    { 570, 12724L, "ASOS", 570, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4595), null, "Alpha Industries" },
                    { 571, 15609L, "ASOS", 571, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4596), null, "Parlez" },
                    { 572, 16164L, "ASOS", 572, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4597), null, "Wednesday's Girl Curve" },
                    { 573, 12731L, "ASOS", 573, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4598), null, "Fiorucci" },
                    { 574, 16401L, "ASOS", 574, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4599), null, "L'Oreal Elvive" },
                    { 575, 16193L, "ASOS", 575, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4600), null, "Sunday Rain" },
                    { 576, 13843L, "ASOS", 576, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4602), null, "New Look Maternity" },
                    { 577, 16709L, "ASOS", 577, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4603), null, "Sergio Tacchini" },
                    { 578, 676L, "ASOS", 578, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4604), null, "St. Tropez" },
                    { 579, 16619L, "ASOS", 579, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4606), null, "Aaron Wallace" },
                    { 580, 22356L, "ASOS", 580, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4607), null, "Sarah Chapman" },
                    { 581, 16233L, "ASOS", 581, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4608), null, "Piz Buin" },
                    { 582, 20400L, "ASOS", 582, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4610), null, "FADED FUTURE" },
                    { 583, 16607L, "ASOS", 583, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4611), null, "Lancaster" },
                    { 584, 15338L, "ASOS", 584, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4612), null, "Pureology" },
                    { 585, 21955L, "ASOS", 585, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4613), null, "Grown Alchemist" },
                    { 586, 12168L, "ASOS", 586, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4614), null, "Beauty Blender" },
                    { 587, 20605L, "ASOS", 587, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4615), null, "KYO" },
                    { 588, 16447L, "ASOS", 588, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4617), null, "HARRY'S" },
                    { 589, 16116L, "ASOS", 589, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4618), null, "OGX" },
                    { 590, 3735L, "ASOS", 590, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4619), null, "G-Star" },
                    { 591, 12455L, "ASOS", 591, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4620), null, "Palladium" },
                    { 592, 12681L, "ASOS", 592, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4621), null, "Vita Liberata" },
                    { 593, 15589L, "ASOS", 593, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4623), null, "Spectrum" },
                    { 594, 16514L, "ASOS", 594, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4624), null, "Veet" },
                    { 595, 15473L, "ASOS", 595, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4625), null, "MasqueBAR" },
                    { 596, 15816L, "ASOS", 596, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4627), null, "Aveda" },
                    { 597, 16203L, "ASOS", 597, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4628), null, "Gillette" },
                    { 598, 16022L, "ASOS", 598, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4630), null, "New Girl Order" },
                    { 599, 16618L, "ASOS", 599, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4631), null, "EGO" },
                    { 600, 20051L, "ASOS", 600, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4632), null, "Jamaican Mango & Lime" },
                    { 601, 17701L, "ASOS", 601, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4633), null, "Hairburst" },
                    { 602, 14451L, "ASOS", 602, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4634), null, "Rule London" },
                    { 603, 16414L, "ASOS", 603, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4636), null, "Damson Madder" },
                    { 604, 18050L, "ASOS", 604, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4637), null, "Bali Body" },
                    { 605, 20951L, "ASOS", 605, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4638), null, "Extro & Vert Tall" },
                    { 606, 16578L, "ASOS", 606, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4639), null, "Vesper Petite" },
                    { 607, 12635L, "ASOS", 607, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4640), null, "Murad" },
                    { 608, 17950L, "ASOS", 608, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4641), null, "Pieces Tall" },
                    { 609, 16475L, "ASOS", 609, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4643), null, "Glow Hub" },
                    { 610, 16423L, "ASOS", 610, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4644), null, "Aria Cove" },
                    { 611, 15752L, "ASOS", 611, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4645), null, "First Aid Beauty" },
                    { 612, 13827L, "ASOS", 612, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4647), null, "RVCA" },
                    { 613, 16438L, "ASOS", 613, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4648), null, "Easilocks" },
                    { 614, 3392L, "ASOS", 614, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4650), null, "Rare" },
                    { 615, 16705L, "ASOS", 615, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4651), null, "HVISK" },
                    { 616, 21959L, "ASOS", 616, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4652), null, "Spotlight" },
                    { 617, 15815L, "ASOS", 617, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4653), null, "Bumble and Bumble" },
                    { 618, 16267L, "ASOS", 618, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4654), null, "My White Secret" },
                    { 619, 15961L, "ASOS", 619, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4655), null, "David Beckham" },
                    { 620, 23055L, "ASOS", 620, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4656), null, "Sui Ava" },
                    { 621, 21807L, "ASOS", 621, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4658), null, "Sundae Body" },
                    { 622, 19500L, "ASOS", 622, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4659), null, "Carbon Theory" },
                    { 623, 16112L, "ASOS", 623, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4660), null, "Flat Lay Company" },
                    { 624, 16679L, "ASOS", 624, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4661), null, "Shaka" },
                    { 625, 3755L, "ASOS", 625, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4662), null, "DKNY Active" },
                    { 626, 62101L, "ASOS", 626, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4663), null, "Messina Hembry Clothing Ltd" },
                    { 627, 13597L, "ASOS", 627, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4664), null, "Icon Brand" },
                    { 628, 16431L, "ASOS", 628, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4669), null, "Sixth June Plus" },
                    { 629, 15248L, "ASOS", 629, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4671), null, "Johnny's Chop Shop" },
                    { 630, 20950L, "ASOS", 630, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4672), null, "Extro & Vert Petite" },
                    { 631, 15811L, "ASOS", 631, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4673), null, "Y.A.S Petite" },
                    { 632, 13656L, "ASOS", 632, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4674), null, "Cat Footwear" },
                    { 633, 22455L, "ASOS", 633, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4675), null, "Bouclème" },
                    { 634, 15067L, "ASOS", 634, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4676), null, "Missguided Maternity" },
                    { 635, 12491L, "ASOS", 635, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4678), null, "Barneys Originals" },
                    { 636, 62450L, "ASOS", 636, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4702), null, "JACK1T" },
                    { 637, 3414L, "ASOS", 637, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4704), null, "Schott" },
                    { 638, 13017L, "ASOS", 638, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4705), null, "Crooked Tongues" },
                    { 639, 62250L, "ASOS", 639, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4706), null, "OOSC" },
                    { 640, 15591L, "ASOS", 640, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4707), null, "Jack Wolfskin" },
                    { 641, 16005L, "ASOS", 641, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4708), null, "Women'secret" },
                    { 642, 15895L, "ASOS", 642, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4710), null, "Sally Hansen" },
                    { 643, 14300L, "ASOS", 643, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4711), null, "Jaded London" },
                    { 644, 62503L, "ASOS", 644, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4712), null, "Soho Skin" },
                    { 645, 16250L, "ASOS", 645, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4713), null, "Dickies Girl" },
                    { 646, 21855L, "ASOS", 646, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4716), null, "Lace & Beads Petite" },
                    { 647, 16135L, "ASOS", 647, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4717), null, "StylPro" },
                    { 648, 16461L, "ASOS", 648, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4718), null, "The O Dolls Collection" },
                    { 649, 16178L, "ASOS", 649, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4719), null, "Go Guy" },
                    { 650, 14444L, "ASOS", 650, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4720), null, "Little Mistress Plus" },
                    { 651, 16393L, "ASOS", 651, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4721), null, "Eivy" },
                    { 652, 12552L, "ASOS", 652, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4723), null, "The Hundreds" },
                    { 653, 480L, "ASOS", 653, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4724), null, "Moschino" },
                    { 654, 15351L, "ASOS", 654, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4725), null, "L Oréal Pa" },
                    { 655, 20050L, "ASOS", 655, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4726), null, "Eco Style" },
                    { 656, 20606L, "ASOS", 656, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4727), null, "Extro & Vert Plus" },
                    { 657, 16723L, "ASOS", 657, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4729), null, "Wishful" },
                    { 658, 16180L, "ASOS", 658, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4730), null, "Psychic Sisters" },
                    { 659, 16652L, "ASOS", 659, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4731), null, "Threadbare Fitness Curve" },
                    { 660, 14803L, "ASOS", 660, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4732), null, "Missguided Plus" },
                    { 661, 21055L, "ASOS", 661, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4733), null, "Loungeable Tall" },
                    { 662, 21450L, "ASOS", 662, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4734), null, "Basic Pleasure Mode" },
                    { 663, 16072L, "ASOS", 663, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4736), null, "Dr Denim Tall" },
                    { 664, 16387L, "ASOS", 664, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4738), null, "Hope & Ivy Plus" },
                    { 665, 15091L, "ASOS", 665, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4739), null, "Hope & Ivy Maternity" },
                    { 666, 16581L, "ASOS", 666, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4740), null, "Violet Romance Petite" },
                    { 667, 13305L, "ASOS", 667, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4741), null, "REN" },
                    { 668, 15003L, "ASOS", 668, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4742), null, "Harry Brown" },
                    { 669, 15364L, "ASOS", 669, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4743), null, "Gianni Feraud" },
                    { 670, 19900L, "ASOS", 670, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4747), null, "Shambhala" },
                    { 671, 14557L, "ASOS", 671, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4749), null, "Jayley" },
                    { 672, 13518L, "ASOS", 672, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4750), null, "Hurley" },
                    { 673, 13935L, "ASOS", 673, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4751), null, "Deus Ex Machina" },
                    { 674, 16432L, "ASOS", 674, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4752), null, "A.Kjaerbede" },
                    { 675, 15821L, "ASOS", 675, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4753), null, "CHICKIDEE" },
                    { 676, 14974L, "ASOS", 676, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4754), null, "Sisters of the Tribe" },
                    { 677, 21156L, "ASOS", 677, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4756), null, "Truffle Collection Wide Fit" },
                    { 678, 18151L, "ASOS", 678, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4757), null, "BeYou" },
                    { 679, 13573L, "ASOS", 679, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4758), null, "Rhythm" },
                    { 680, 16214L, "ASOS", 680, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4760), null, "Tonymoly" },
                    { 681, 62789L, "ASOS", 681, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4761), null, "Denim Project" },
                    { 682, 14187L, "ASOS", 682, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4762), null, "CAT" },
                    { 683, 13761L, "ASOS", 683, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4763), null, "Fat Moose" },
                    { 684, 13962L, "ASOS", 684, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4765), null, "Limit" },
                    { 685, 3675L, "ASOS", 685, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4766), null, "Urbancode" },
                    { 686, 14449L, "ASOS", 686, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4767), null, "Noisy May Tall" },
                    { 687, 12626L, "ASOS", 687, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4768), null, "L'Occitane" },
                    { 688, 12754L, "ASOS", 688, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4769), null, "Dare 2b" },
                    { 689, 15584L, "ASOS", 689, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4770), null, "Brave Soul Petite" },
                    { 690, 20601L, "ASOS", 690, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4772), null, "Topshop Hourglass" },
                    { 691, 62798L, "ASOS", 691, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4773), null, "Off The Hook" },
                    { 692, 16244L, "ASOS", 692, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4774), null, "Shelby & Sons" },
                    { 693, 647L, "ASOS", 693, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4775), null, "Sean John" },
                    { 694, 16406L, "ASOS", 694, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4776), null, "Forever New Curve" },
                    { 695, 15297L, "ASOS", 695, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4777), null, "Lamoda" },
                    { 696, 62700L, "ASOS", 696, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4779), null, "Regatta" },
                    { 697, 16528L, "ASOS", 697, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4781), null, "The Kript" },
                    { 698, 15827L, "ASOS", 698, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4782), null, "ONLY Petite" },
                    { 699, 3154L, "ASOS", 699, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4783), null, "Helene Berman" },
                    { 700, 62410L, "ASOS", 700, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4784), null, "Pajar" },
                    { 701, 3513L, "ASOS", 701, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4785), null, "Claudia Canova" },
                    { 702, 15143L, "ASOS", 702, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4786), null, "Dorina" },
                    { 703, 16039L, "ASOS", 703, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4787), null, "Thinx" },
                    { 704, 481L, "ASOS", 704, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4789), null, "Motel" },
                    { 705, 13839L, "ASOS", 705, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4790), null, "Call it Spring" },
                    { 706, 15355L, "ASOS", 706, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4791), null, "Tommy Hilfiger Denim" },
                    { 707, 16306L, "ASOS", 707, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4792), null, "Topshop Maternity" },
                    { 708, 62799L, "ASOS", 708, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4793), null, "SENSSE" },
                    { 709, 12527L, "ASOS", 709, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4794), null, "Accurist" },
                    { 710, 16534L, "ASOS", 710, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4795), null, "VIOLET ROMANCE" },
                    { 711, 18901L, "ASOS", 711, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4797), null, "Edited" },
                    { 712, 14616L, "ASOS", 712, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4798), null, "Kingsley Ryan" },
                    { 713, 15710L, "ASOS", 713, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4799), null, "Flounce London Maternity" },
                    { 714, 13668L, "ASOS", 714, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4800), null, "AX Paris" },
                    { 715, 14629L, "ASOS", 715, new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4801), null, "Devils Advocate" }
                });

            migrationBuilder.InsertData(
                table: "ProductWeightPrice",
                columns: new[] { "Id", "CreatedOnUtc", "CurrencyId", "ExtraPrice", "NormalPrice", "UpdatedOnUtc", "WeightId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4363), 2, 1m, 1m, null, 1 },
                    { 2, new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4369), 2, 18.3m, 15.75m, null, 2 },
                    { 3, new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4373), 2, 24.7m, 22.2m, null, 3 },
                    { 4, new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4374), 2, 29.1m, 26.7m, null, 4 },
                    { 5, new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4376), 2, 29.55m, 27.15m, null, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CatalogBrandApi_CatalogBrandId",
                table: "CatalogBrandApi",
                column: "CatalogBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryApis_ParentCategoryId",
                table: "CategoryApis",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyConversions_FromCurrencyId",
                table: "CurrencyConversions",
                column: "FromCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyConversions_ToCurrencyId",
                table: "CurrencyConversions",
                column: "ToCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyCountry_CountryId",
                table: "CurrencyCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyCountry_CurrencyId",
                table: "CurrencyCountry",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_CustomerId",
                table: "CustomerOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CustomerOrderId",
                table: "OrderItem",
                column: "CustomerOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerOrderId",
                table: "Payments",
                column: "CustomerOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMediaFile_MediaFileId",
                table: "ProductMediaFile",
                column: "MediaFileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMediaFile_ProductId",
                table: "ProductMediaFile",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductTag_ProductTagId",
                table: "ProductProductTag",
                column: "ProductTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatalogBrandId",
                table: "Products",
                column: "CatalogBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PriceCurrencyId",
                table: "Products",
                column: "PriceCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductId",
                table: "ProductSpecifications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductWeightPrice_CurrencyId",
                table: "ProductWeightPrice",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductWeightPrice_WeightId",
                table: "ProductWeightPrice",
                column: "WeightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingInfo_CustomerOrderId",
                table: "ShippingInfo",
                column: "CustomerOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCategoryToApis_ApiCategoryId",
                table: "SiteCategoryToApis",
                column: "ApiCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteCategoryToApis_SiteCategoryId",
                table: "SiteCategoryToApis",
                column: "SiteCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "CatalogBrandApi");

            migrationBuilder.DropTable(
                name: "CurrencyConversions");

            migrationBuilder.DropTable(
                name: "CurrencyCountry");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductMediaFile");

            migrationBuilder.DropTable(
                name: "ProductProductTag");

            migrationBuilder.DropTable(
                name: "ProductSpecifications");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductWeightPrice");

            migrationBuilder.DropTable(
                name: "RawProductData");

            migrationBuilder.DropTable(
                name: "ShippingInfo");

            migrationBuilder.DropTable(
                name: "SiteCategoryToApis");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "MediaFiles");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WeightSource");

            migrationBuilder.DropTable(
                name: "CustomerOrders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryApis");

            migrationBuilder.DropTable(
                name: "CatalogBrands");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
