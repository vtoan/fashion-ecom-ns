using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpdateDeleteRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings");

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7557));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7581), 300000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7597));

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7607));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7613), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7617));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7631), 300000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7637));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7653), 300000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7660), 199000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7666));

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7729));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7736), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7739), 199000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7812), 230000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 34, 39, 230, DateTimeKind.Local).AddTicks(7831), 350000.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings");

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5849));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5874), 450000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5948), 199000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5973), 230000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5983));

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6006), 450000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6021), 199000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6036), 300000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6051));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6075), 250000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6098));

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6149));

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6274), 250000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6281), 350000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6303), 159000.0 });

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
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6319), 159000.0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6352), 350000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 4, 29, 16, 28, 27, 831, DateTimeKind.Local).AddTicks(6362), 230000.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
