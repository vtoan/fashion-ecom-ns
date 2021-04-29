using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpdateDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 829, DateTimeKind.Local).AddTicks(2760), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5792), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5841), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5849), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5855), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5863), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5869), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5956), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5962), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5968), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5978), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5983), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5989), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5994), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6001), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6011), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6016), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6026), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6031), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6041), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6046), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6051), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6055), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6060), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6065), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6071), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6082), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6088), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6093), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6098), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6103), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6109), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6114), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6119), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6124), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6128), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6132), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6136), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6140), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6149), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6155), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6159), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6165), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6211), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6217), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6222), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6226), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6229), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6234), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6238), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6242), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6247), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6252), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6258), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6263), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6268), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6287), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6292), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6297), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6308), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6314), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6324), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6328), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6333), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6336), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6342), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6362), 230000.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 363, DateTimeKind.Local).AddTicks(8885), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2365), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2398), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2403), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2405), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2411), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2415), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2426), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2430), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2433), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2439), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2443), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2446), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2449), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2453), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2458), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2462), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2468), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2471), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2477), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2480), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2483), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2486), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2489), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2493), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2496), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2503), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2506), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2509), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2512), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2515), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2518), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2521), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2524), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2598), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2602), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2605), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2608), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2611), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2617), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2620), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2623), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2626), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2629), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2632), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2635), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2639), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2642), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2645), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2648), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2651), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2654), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2657), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2660), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2663), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2666), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2677), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2680), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2683), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2689), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2692), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2698), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2701), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2704), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2707), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2710), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateCreated",
                value: new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2716), 450000.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
