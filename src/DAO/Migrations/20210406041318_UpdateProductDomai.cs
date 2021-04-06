using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpdateProductDomai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeProducts_TypeID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "Products",
                newName: "TypeProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TypeID",
                table: "Products",
                newName: "IX_Products_TypeProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products",
                column: "TypeProductId",
                principalTable: "TypeProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TypeProductId",
                table: "Products",
                newName: "TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TypeProductId",
                table: "Products",
                newName: "IX_Products_TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeProducts_TypeID",
                table: "Products",
                column: "TypeID",
                principalTable: "TypeProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
