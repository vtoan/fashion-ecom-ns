using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Shirts" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Pants" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "TypeProductId" },
                values: new object[,]
                {
                    { 1, "T-Shirtss", 1 },
                    { 2, "Polos", 1 },
                    { 3, "Texedo Shirts", 1 },
                    { 4, "Tank Tops", 1 },
                    { 5, "Dress Shirts", 1 },
                    { 6, "Kakis", 2 },
                    { 7, "Jeans", 2 },
                    { 8, "Jogger", 2 },
                    { 9, "Slim fit", 2 },
                    { 10, "Dress Pants", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
