using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanjameh.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImproveProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Products",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastCalculatedWeightId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Products",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Rejected",
                table: "Products",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastCalculatedWeightId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rejected",
                table: "Products");
        }
    }
}
