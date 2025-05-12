using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanjameh.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImproveOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "OrderItem",
                type: "varchar(5000)",
                maxLength: 5000,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomItemOrderId",
                table: "OrderItem",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "CustomerOrders",
                type: "varchar(5000)",
                maxLength: 5000,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomOrderId",
                table: "CustomerOrders",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "CustomerAddress",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "LatinAddress",
                table: "CustomerAddress",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LatinCity",
                table: "CustomerAddress",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    WeightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_WeightSource_WeightId",
                        column: x => x.WeightId,
                        principalTable: "WeightSource",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_PackageId",
                table: "OrderItem",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_WeightId",
                table: "Package",
                column: "WeightId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Package_PackageId",
                table: "OrderItem",
                column: "PackageId",
                principalTable: "Package",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Package_PackageId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_PackageId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "CustomItemOrderId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "CustomerOrders");

            migrationBuilder.DropColumn(
                name: "CustomOrderId",
                table: "CustomerOrders");

            migrationBuilder.DropColumn(
                name: "LatinAddress",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "LatinCity",
                table: "CustomerAddress");

            migrationBuilder.AlterColumn<sbyte>(
                name: "IsDefault",
                table: "CustomerAddress",
                type: "tinyint(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }
    }
}
