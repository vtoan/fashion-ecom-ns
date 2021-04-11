using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpdateOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderDetails",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductDetailId");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 302, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateCreated",
                value: new DateTime(2021, 4, 12, 2, 30, 34, 306, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductDetails_ProductDetailId",
                table: "OrderDetails",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductDetails_ProductDetailId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "OrderDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductDetailId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 121, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
