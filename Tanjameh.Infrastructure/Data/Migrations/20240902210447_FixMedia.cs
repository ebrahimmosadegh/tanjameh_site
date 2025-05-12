using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanjameh.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOnUtc",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOnUtc",
                table: "CatalogBrands");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "CatalogBrandApi");

            migrationBuilder.AddColumn<int>(
                name: "ThumbnailFileId",
                table: "ProductMediaFile",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 51,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 52,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 53,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 54,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 55,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 56,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 57,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 58,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 59,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 60,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 61,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 62,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 63,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 64,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 65,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 66,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 67,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 68,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 69,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 70,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 71,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 72,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 73,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 74,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 75,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 76,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 77,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 78,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 79,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 80,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 81,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 82,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 83,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 84,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 85,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 86,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 87,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 88,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 89,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 90,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 91,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 92,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 93,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 94,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 95,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 96,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 97,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 98,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 100,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 101,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 102,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 103,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 104,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 105,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 106,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 107,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 108,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 109,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 110,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 111,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 112,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 113,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 114,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 115,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 116,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 117,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 118,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 119,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 120,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 121,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 122,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 123,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 124,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 125,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 126,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 127,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 128,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 129,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 130,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 131,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 132,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 133,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 134,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 135,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 136,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 137,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 138,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 139,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 140,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 141,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 142,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 143,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 144,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 145,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 146,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 147,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 148,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 149,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 150,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 151,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 152,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 153,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 154,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 155,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 156,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 157,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 158,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 159,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 160,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 161,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 162,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 163,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 164,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 165,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 166,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 167,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 168,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 169,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 170,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 171,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 172,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 173,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 174,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 175,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 176,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 177,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 178,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 179,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 180,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 181,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 182,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 183,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 184,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 185,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 186,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 187,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 188,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 189,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 190,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 191,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 192,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 193,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 194,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 195,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 196,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 197,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 198,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 199,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 200,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 201,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 202,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 203,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 204,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 205,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 206,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 207,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 208,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 209,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 210,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 211,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 212,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 213,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 214,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 215,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 216,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 217,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 218,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 219,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 220,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 221,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 222,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 223,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 224,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 225,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 226,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 227,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 228,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 229,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 230,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 231,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 232,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 233,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 234,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 235,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 236,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 237,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 238,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 239,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 240,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 241,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 242,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 243,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 244,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 245,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 246,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 247,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 248,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 249,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 250,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 251,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 252,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 253,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 254,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 255,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 256,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 257,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 258,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 259,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 260,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 261,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 262,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 263,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 264,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 265,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 266,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 267,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 268,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 269,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 270,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 271,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 272,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 273,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 274,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 275,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 276,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 277,
                column: "UpdatedOnUtc",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 278,
                column: "UpdatedOnUtc",
                value: null);

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductMediaFile_ThumbnailFileId",
                table: "ProductMediaFile",
                column: "ThumbnailFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMediaFile_MediaFiles_ThumbnailFileId",
                table: "ProductMediaFile",
                column: "ThumbnailFileId",
                principalTable: "MediaFiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMediaFile_MediaFiles_ThumbnailFileId",
                table: "ProductMediaFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductMediaFile_ThumbnailFileId",
                table: "ProductMediaFile");

            migrationBuilder.DropColumn(
                name: "ThumbnailFileId",
                table: "ProductMediaFile");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnUtc",
                table: "ProductTypes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnUtc",
                table: "CatalogBrands",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "CatalogBrandApi",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "CatalogBrandApi",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 276, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 277, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2166), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2174), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2181), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2183), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2185), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2187), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2189), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2191), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2193), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2195), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2196), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2198), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2200), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2205), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2207), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2209), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2211), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2212), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2214), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2216), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2218), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2222), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2223), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2226), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2228), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2230), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2231), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2233), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2235), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2237), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2238), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2240), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2242), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2243), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2246), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2248), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2250), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2252), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2253), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2255), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2261), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2262), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2264), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2266), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2268), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2269), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2272), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2274), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2276), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2279), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2281), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2286), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2313), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2317), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2318), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2320), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2324), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2325), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2327), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2329), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2331), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2333), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2334), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2342), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2343), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2345), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2347), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2349), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2352), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2354), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2356), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2359), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2362), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2364), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2367), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2371), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2374), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2378), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2384), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2389), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2393), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2394), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2396), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2402), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2404), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2406), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2407), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2409), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2411), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2417), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2419), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2421), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2424), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2426), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2434), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2435), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2439), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2442), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2445), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2448), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2452), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2454), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2457), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2460), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2462), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2463), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2495), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2497), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2502), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2506), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2507), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2509), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2511), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2513), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2522), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2523), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2525), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2527), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2529), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2530), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2532), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2537), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2552), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2554), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2556), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2557), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2559), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2561), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2564), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2568), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2575), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2578), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2593), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2594), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2599), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2601), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2606), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2609), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2611), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2613), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2615), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2618), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2620), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2624), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2629), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2631), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2633), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2635), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2636), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2659), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2661), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2662), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2665), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2669), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2672), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2675), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2677), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2683), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2685), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2687), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2689), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2700), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2703), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2705), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2710), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2718), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2722), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2729), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2731), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2733), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2735), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2736), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2738), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2741), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2745), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2748), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2752), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2754), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2757), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2759), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2760), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2762), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2764), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2767), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2769), new DateTime(2024, 9, 2, 14, 46, 57, 278, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "ProductWeightPrice",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOnUtc",
                value: new DateTime(2024, 9, 2, 14, 46, 57, 282, DateTimeKind.Utc).AddTicks(4376));
        }
    }
}
