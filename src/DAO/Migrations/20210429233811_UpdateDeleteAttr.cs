using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpdateDeleteAttr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttrs_Products_ProductId",
                table: "ProductAttrs");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 845, DateTimeKind.Local).AddTicks(308), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2210), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2242), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2247), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2251), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2258), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2261), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2264), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2268), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2276), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2280), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2283), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2286), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2290), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2293), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2296), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2300), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2304), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2310), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2313), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2316), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2319), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2323), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2329), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2332), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2335), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2338), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2342), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2353), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2361), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2367), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2370), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2373), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2376), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2379), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2382), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2385), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2389), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2392), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2395), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2398), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2401), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2414), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2417), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2420), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2423), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2426), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2429), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2432), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2435), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2438), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2441), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2445), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2448), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2451), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2454), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2457), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2461), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2464), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2466), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2469), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2473), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2480), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2484), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2487), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2493), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2496), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2499), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2505), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 38, 10, 847, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttrs_Products_ProductId",
                table: "ProductAttrs",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttrs_Products_ProductId",
                table: "ProductAttrs");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 228, DateTimeKind.Local).AddTicks(5099), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7464), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7500), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7557), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7561), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7567), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7571), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7574), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7577), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7584), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7587), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7590), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7593), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7597), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7600), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7603), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7607), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7610), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7617), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7619), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7622), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7625), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7628), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7634), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7637), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7640), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7643), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7647), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7650), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7657), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7663), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7666), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7668), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7671), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7674), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7677), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7680), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7683), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7686), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7689), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7726), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7729), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7742), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7745), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7748), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7751), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7754), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7757), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7760), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7763), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7766), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7769), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7772), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7775), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7778), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7781), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7784), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7788), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7791), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7794), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7797), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7800), 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7803), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7806), 199000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7809), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7815), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7819), 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7821), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7828), 159000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttrs_Products_ProductId",
                table: "ProductAttrs",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
