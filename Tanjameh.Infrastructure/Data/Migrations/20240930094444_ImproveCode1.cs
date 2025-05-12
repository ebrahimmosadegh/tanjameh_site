using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanjameh.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImproveCode1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Exist",
                table: "ProductVariants",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteLink",
                table: "Products",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exist",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "SiteLink",
                table: "Products");
        }
    }
}
