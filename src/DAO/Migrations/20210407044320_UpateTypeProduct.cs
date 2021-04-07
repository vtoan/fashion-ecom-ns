using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpateTypeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeProductId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TypeProductId",
                table: "Categories",
                column: "TypeProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_TypeProducts_TypeProductId",
                table: "Categories",
                column: "TypeProductId",
                principalTable: "TypeProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_TypeProducts_TypeProductId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_TypeProductId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TypeProductId",
                table: "Categories");
        }
    }
}
