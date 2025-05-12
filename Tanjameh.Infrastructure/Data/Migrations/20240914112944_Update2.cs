using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanjameh.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItem_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItem");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShoppingCartId",
                table: "ShoppingCartItem",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductVariants",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DisplaySizeText",
                table: "ProductVariants",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "ProductVariants",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BrandSize",
                table: "ProductVariants",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRateTime",
                table: "OrderItem",
                type: "decimal(20,4)",
                precision: 20,
                scale: 4,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Context = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Body = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TimeInUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Color",
                table: "ProductVariants",
                column: "Colour");

            migrationBuilder.CreateIndex(
                name: "IX_Names_Descending1",
                table: "ProductVariants",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Names1",
                table: "ProductVariants",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Size",
                table: "ProductVariants",
                columns: new[] { "BrandSize", "DisplaySizeText", "SizeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Exist",
                table: "Products",
                column: "Exist");

            migrationBuilder.CreateIndex(
                name: "IX_Names",
                table: "Products",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Names_Descending",
                table: "Products",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Price",
                table: "Products",
                columns: new[] { "Price", "OldPrice" });

            migrationBuilder.CreateIndex(
                name: "IX_Price_Descending",
                table: "Products",
                columns: new[] { "Price", "OldPrice" },
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_Descending",
                table: "Products",
                column: "Rating",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Update",
                table: "Products",
                column: "UpdatedOnUtc");

            migrationBuilder.CreateIndex(
                name: "IX_Update_Descending",
                table: "Products",
                column: "UpdatedOnUtc",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItem_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItem",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItem_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItem");

            migrationBuilder.DropTable(
                name: "EventLogs");

            migrationBuilder.DropIndex(
                name: "IX_Color",
                table: "ProductVariants");

            migrationBuilder.DropIndex(
                name: "IX_Names_Descending1",
                table: "ProductVariants");

            migrationBuilder.DropIndex(
                name: "IX_Names1",
                table: "ProductVariants");

            migrationBuilder.DropIndex(
                name: "IX_Size",
                table: "ProductVariants");

            migrationBuilder.DropIndex(
                name: "IX_Exist",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Names",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Names_Descending",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Price",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Price_Descending",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Rating_Descending",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Update",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Update_Descending",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ExchangeRateTime",
                table: "OrderItem");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShoppingCartId",
                table: "ShoppingCartItem",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductVariants",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DisplaySizeText",
                table: "ProductVariants",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "ProductVariants",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BrandSize",
                table: "ProductVariants",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItem_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItem",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");
        }
    }
}
