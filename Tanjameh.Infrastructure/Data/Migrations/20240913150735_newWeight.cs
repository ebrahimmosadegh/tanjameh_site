using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanjameh.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class newWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOnUtc",
                table: "ProductWeightPrice");

            migrationBuilder.AddColumn<int>(
                name: "WeightId",
                table: "Categories",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeightId",
                table: "Categories");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnUtc",
                table: "ProductWeightPrice",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 21, 4, 45, 289, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 21, 4, 45, 289, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 21, 4, 45, 289, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 21, 4, 45, 289, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 21, 4, 45, 289, DateTimeKind.Utc).AddTicks(2104));
        }
    }
}
