using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class SeedDatas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(2,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CustomerDistrict = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CustomerProvince = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: true),
                    Fees = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_TypeProducts_TypeProductId",
                        column: x => x.TypeProductId,
                        principalTable: "TypeProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isDel = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Material = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    TypeProductId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    DateModified = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TypeProducts_TypeProductId",
                        column: x => x.TypeProductId,
                        principalTable: "TypeProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    SaleCount = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttrs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttrs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Rate = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductAttrId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductAttrId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductAttrs_ProductAttrId",
                        column: x => x.ProductAttrId,
                        principalTable: "ProductAttrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fees",
                columns: new[] { "Id", "Cost", "Name" },
                values: new object[] { 1, 0.05m, "Tax" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shirts" },
                    { 2, "Pants" },
                    { 3, "Jackets" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "TypeProductId" },
                values: new object[,]
                {
                    { 1, "T-Shirts", 1 },
                    { 2, "Polos", 1 },
                    { 3, "Texedo Shirts", 1 },
                    { 4, "Kakis", 2 },
                    { 5, "Jeans", 2 },
                    { 6, "Jogger", 2 },
                    { 7, "Hoodies", 3 },
                    { 8, "Coats", 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Image", "Material", "Name", "Origin", "Price", "ProductDescription", "TypeProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 27, 8, 59, 3, 363, DateTimeKind.Local).AddTicks(8885), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 58, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2648), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 57, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2645), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 56, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2642), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 55, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2639), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 54, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2635), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 53, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2632), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 52, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2629), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 59, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2651), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 51, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2626), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 49, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2620), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 48, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2617), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 47, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2614), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 46, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2611), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 45, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2608), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 44, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2605), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 43, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2602), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 50, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2623), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 42, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2598), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 60, 6, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2654), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 62, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2660), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 78, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2710), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 77, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2707), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 76, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2704), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 75, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2701), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 74, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2698), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 73, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2695), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 72, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2692), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 61, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2657), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 71, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2689), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 69, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2683), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 68, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2680), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 67, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2677), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 66, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2673), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 65, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2669), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 64, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2666), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 63, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2663), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 70, 7, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2686), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 41, 5, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2524), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 40, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2521), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 39, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2518), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 17, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2449), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Image", "Material", "Name", "Origin", "Price", "ProductDescription", "TypeProductId" },
                values: new object[,]
                {
                    { 16, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2446), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 15, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2443), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 14, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2439), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 13, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2436), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 12, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2433), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 11, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2430), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 18, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2453), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 10, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2426), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 8, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2418), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 7, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2415), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 6, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2411), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 5, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2405), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 4, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2403), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 3, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2398), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 2, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2365), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 9, 1, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2422), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 19, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2456), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 20, 2, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2458), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 21, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2462), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 38, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2515), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 37, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2512), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 36, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2509), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 230000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 35, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2506), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 34, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2503), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 33, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2499), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 32, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2496), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 31, 4, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2493), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 2 },
                    { 30, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2489), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 29, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2486), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 28, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2483), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 27, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2480), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 26, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2477), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 25, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2474), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 300000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 24, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2471), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 159000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 23, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2468), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 250000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 22, 3, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2465), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 199000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 1 },
                    { 79, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2713), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 350000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 },
                    { 80, 8, new DateTime(2021, 4, 27, 8, 59, 3, 366, DateTimeKind.Local).AddTicks(2716), null, null, "High quality water slide, with sun protection.", "Product Name", "Viet nam", 450000.0, "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttrs",
                columns: new[] { "Id", "ProductId", "SaleCount", "Size" },
                values: new object[,]
                {
                    { 1, 1, 0, "S" },
                    { 103, 52, 0, "S" },
                    { 104, 52, 0, "L" },
                    { 105, 53, 0, "S" },
                    { 106, 53, 0, "L" },
                    { 107, 54, 0, "S" },
                    { 108, 54, 0, "L" },
                    { 109, 55, 0, "S" },
                    { 102, 51, 0, "L" },
                    { 110, 55, 0, "L" },
                    { 112, 56, 0, "L" },
                    { 113, 57, 0, "S" },
                    { 114, 57, 0, "L" },
                    { 115, 58, 0, "S" },
                    { 116, 58, 0, "L" },
                    { 117, 59, 0, "S" },
                    { 118, 59, 0, "L" },
                    { 111, 56, 0, "S" },
                    { 119, 60, 0, "S" },
                    { 101, 51, 0, "S" },
                    { 99, 50, 0, "S" },
                    { 83, 42, 0, "S" },
                    { 84, 42, 0, "L" },
                    { 85, 43, 0, "S" },
                    { 86, 43, 0, "L" },
                    { 87, 44, 0, "S" },
                    { 88, 44, 0, "L" },
                    { 89, 45, 0, "S" },
                    { 100, 50, 0, "L" },
                    { 90, 45, 0, "L" },
                    { 92, 46, 0, "L" },
                    { 93, 47, 0, "S" },
                    { 94, 47, 0, "L" },
                    { 95, 48, 0, "S" },
                    { 96, 48, 0, "L" },
                    { 97, 49, 0, "S" },
                    { 98, 49, 0, "L" },
                    { 91, 46, 0, "S" },
                    { 82, 41, 0, "L" },
                    { 120, 60, 0, "L" },
                    { 122, 61, 0, "L" },
                    { 143, 72, 0, "S" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttrs",
                columns: new[] { "Id", "ProductId", "SaleCount", "Size" },
                values: new object[,]
                {
                    { 144, 72, 0, "L" },
                    { 145, 73, 0, "S" },
                    { 146, 73, 0, "L" },
                    { 147, 74, 0, "S" },
                    { 148, 74, 0, "L" },
                    { 149, 75, 0, "S" },
                    { 142, 71, 0, "L" },
                    { 150, 75, 0, "L" },
                    { 152, 76, 0, "L" },
                    { 153, 77, 0, "S" },
                    { 154, 77, 0, "L" },
                    { 155, 78, 0, "S" },
                    { 156, 78, 0, "L" },
                    { 157, 79, 0, "S" },
                    { 158, 79, 0, "L" },
                    { 151, 76, 0, "S" },
                    { 121, 61, 0, "S" },
                    { 141, 71, 0, "S" },
                    { 139, 70, 0, "S" },
                    { 123, 62, 0, "S" },
                    { 124, 62, 0, "L" },
                    { 125, 63, 0, "S" },
                    { 126, 63, 0, "L" },
                    { 127, 64, 0, "S" },
                    { 128, 64, 0, "L" },
                    { 129, 65, 0, "S" },
                    { 140, 70, 0, "L" },
                    { 130, 65, 0, "L" },
                    { 132, 66, 0, "L" },
                    { 133, 67, 0, "S" },
                    { 134, 67, 0, "L" },
                    { 135, 68, 0, "S" },
                    { 136, 68, 0, "L" },
                    { 137, 69, 0, "S" },
                    { 138, 69, 0, "L" },
                    { 131, 66, 0, "S" },
                    { 81, 41, 0, "S" },
                    { 80, 40, 0, "L" },
                    { 79, 40, 0, "S" },
                    { 22, 11, 0, "L" },
                    { 23, 12, 0, "S" },
                    { 24, 12, 0, "L" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttrs",
                columns: new[] { "Id", "ProductId", "SaleCount", "Size" },
                values: new object[,]
                {
                    { 25, 13, 0, "S" },
                    { 26, 13, 0, "L" },
                    { 27, 14, 0, "S" },
                    { 28, 14, 0, "L" },
                    { 21, 11, 0, "S" },
                    { 29, 15, 0, "S" },
                    { 31, 16, 0, "S" },
                    { 32, 16, 0, "L" },
                    { 33, 17, 0, "S" },
                    { 34, 17, 0, "L" },
                    { 35, 18, 0, "S" },
                    { 36, 18, 0, "L" },
                    { 37, 19, 0, "S" },
                    { 30, 15, 0, "L" },
                    { 38, 19, 0, "L" },
                    { 20, 10, 0, "L" },
                    { 18, 9, 0, "L" },
                    { 2, 1, 0, "L" },
                    { 3, 2, 0, "S" },
                    { 4, 2, 0, "L" },
                    { 5, 3, 0, "S" },
                    { 6, 3, 0, "L" },
                    { 7, 4, 0, "S" },
                    { 8, 4, 0, "L" },
                    { 19, 10, 0, "S" },
                    { 9, 5, 0, "S" },
                    { 11, 6, 0, "S" },
                    { 12, 6, 0, "L" },
                    { 13, 7, 0, "S" },
                    { 14, 7, 0, "L" },
                    { 15, 8, 0, "S" },
                    { 16, 8, 0, "L" },
                    { 17, 9, 0, "S" },
                    { 10, 5, 0, "L" },
                    { 39, 20, 0, "S" },
                    { 40, 20, 0, "L" },
                    { 41, 21, 0, "S" },
                    { 63, 32, 0, "S" },
                    { 64, 32, 0, "L" },
                    { 65, 33, 0, "S" },
                    { 66, 33, 0, "L" },
                    { 67, 34, 0, "S" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttrs",
                columns: new[] { "Id", "ProductId", "SaleCount", "Size" },
                values: new object[,]
                {
                    { 68, 34, 0, "L" },
                    { 69, 35, 0, "S" },
                    { 62, 31, 0, "L" },
                    { 70, 35, 0, "L" },
                    { 72, 36, 0, "L" },
                    { 73, 37, 0, "S" },
                    { 74, 37, 0, "L" },
                    { 75, 38, 0, "S" },
                    { 76, 38, 0, "L" },
                    { 77, 39, 0, "S" },
                    { 78, 39, 0, "L" },
                    { 71, 36, 0, "S" },
                    { 61, 31, 0, "S" },
                    { 60, 30, 0, "L" },
                    { 59, 30, 0, "S" },
                    { 42, 21, 0, "L" },
                    { 43, 22, 0, "S" },
                    { 44, 22, 0, "L" },
                    { 45, 23, 0, "S" },
                    { 46, 23, 0, "L" },
                    { 47, 24, 0, "S" },
                    { 48, 24, 0, "L" },
                    { 49, 25, 0, "S" },
                    { 50, 25, 0, "L" },
                    { 51, 26, 0, "S" },
                    { 52, 26, 0, "L" },
                    { 53, 27, 0, "S" },
                    { 54, 27, 0, "L" },
                    { 55, 28, 0, "S" },
                    { 56, 28, 0, "L" },
                    { 57, 29, 0, "S" },
                    { 58, 29, 0, "L" },
                    { 159, 80, 0, "S" },
                    { 160, 80, 0, "L" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TypeProductId",
                table: "Categories",
                column: "TypeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductAttrId",
                table: "OrderDetails",
                column: "ProductAttrId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttrs_ProductId",
                table: "ProductAttrs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeProductId",
                table: "Products",
                column: "TypeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductId",
                table: "Ratings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductAttrs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TypeProducts");
        }
    }
}
