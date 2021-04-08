using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UpdateRating : Migration
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
                    Promotions = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Fees = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ToDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    isAll = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Discount = table.Column<decimal>(type: "decimal(2,2)", nullable: true),
                    TypeIds = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CateIds = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ProductIds = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    SaleCount = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Image = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Material = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "150"),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "250"),
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
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(2,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Size = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
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

            migrationBuilder.InsertData(
                table: "Fees",
                columns: new[] { "Id", "Cost", "Name" },
                values: new object[] { 1, 0.05m, "Tax" });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Image", "Material", "Name", "Origin", "Price", "ProductDescription", "TypeProductId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 8, 6, 4, 0, 121, DateTimeKind.Local).AddTicks(718), null, "product-1.png", "High quality water slide, with sun protection.", "Product 1", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 32, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3678), null, "product-1.png", "High quality water slide, with sun protection.", "Product 32", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 33, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3681), null, "product-1.png", "High quality water slide, with sun protection.", "Product 33", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 34, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3685), null, "product-1.png", "High quality water slide, with sun protection.", "Product 34", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 35, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3689), null, "product-1.png", "High quality water slide, with sun protection.", "Product 35", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 36, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3692), null, "product-1.png", "High quality water slide, with sun protection.", "Product 36", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 37, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3695), null, "product-1.png", "High quality water slide, with sun protection.", "Product 37", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 38, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3698), null, "product-1.png", "High quality water slide, with sun protection.", "Product 38", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 39, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3702), null, "product-1.png", "High quality water slide, with sun protection.", "Product 39", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 40, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3706), null, "product-2.png", "High quality water slide, with sun protection.", "Product 40", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 41, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3709), null, "product-2.png", "High quality water slide, with sun protection.", "Product 41", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 42, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3765), null, "product-2.png", "High quality water slide, with sun protection.", "Product 42", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 43, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3769), null, "product-2.png", "High quality water slide, with sun protection.", "Product 43", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 31, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3675), null, "product-1.png", "High quality water slide, with sun protection.", "Product 31", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 44, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3773), null, "product-2.png", "High quality water slide, with sun protection.", "Product 44", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 46, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3779), null, "product-2.png", "High quality water slide, with sun protection.", "Product 46", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 47, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3782), null, "product-2.png", "High quality water slide, with sun protection.", "Product 47", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 48, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3785), null, "product-2.png", "High quality water slide, with sun protection.", "Product 48", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 49, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3788), null, "product-2.png", "High quality water slide, with sun protection.", "Product 49", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 50, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3792), null, "product-2.png", "High quality water slide, with sun protection.", "Product 50", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 51, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3796), null, "product-2.png", "High quality water slide, with sun protection.", "Product 51", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 52, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3799), null, "product-2.png", "High quality water slide, with sun protection.", "Product 52", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 53, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3802), null, "product-2.png", "High quality water slide, with sun protection.", "Product 53", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 54, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3805), null, "product-2.png", "High quality water slide, with sun protection.", "Product 54", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 55, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3808), null, "product-2.png", "High quality water slide, with sun protection.", "Product 55", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 56, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3812), null, "product-2.png", "High quality water slide, with sun protection.", "Product 56", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 57, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3815), null, "product-2.png", "High quality water slide, with sun protection.", "Product 57", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 45, 7, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3776), null, "product-2.png", "High quality water slide, with sun protection.", "Product 45", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 58, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3818), null, "product-2.png", "High quality water slide, with sun protection.", "Product 58", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 30, 6, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3671), null, "product-1.png", "High quality water slide, with sun protection.", "Product 30", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 },
                    { 28, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3664), null, "product-2.png", "High quality water slide, with sun protection.", "Product 28", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 2, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3493), null, "product-1.png", "High quality water slide, with sun protection.", "Product 2", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 3, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3525), null, "product-1.png", "High quality water slide, with sun protection.", "Product 3", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 4, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3530), null, "product-1.png", "High quality water slide, with sun protection.", "Product 4", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 5, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3534), null, "product-1.png", "High quality water slide, with sun protection.", "Product 5", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 6, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3540), null, "product-1.png", "High quality water slide, with sun protection.", "Product 6", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 7, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3544), null, "product-1.png", "High quality water slide, with sun protection.", "Product 7", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 8, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3547), null, "product-1.png", "High quality water slide, with sun protection.", "Product 8", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 9, 1, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3551), null, "product-1.png", "High quality water slide, with sun protection.", "Product 9", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 10, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3557), null, "product-2.png", "High quality water slide, with sun protection.", "Product 10", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 11, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3561), null, "product-2.png", "High quality water slide, with sun protection.", "Product 11", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 12, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3564), null, "product-2.png", "High quality water slide, with sun protection.", "Product 12", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Image", "Material", "Name", "Origin", "Price", "ProductDescription", "TypeProductId" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3611), null, "product-2.png", "High quality water slide, with sun protection.", "Product 13", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 29, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3667), null, "product-2.png", "High quality water slide, with sun protection.", "Product 29", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 14, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3615), null, "product-2.png", "High quality water slide, with sun protection.", "Product 14", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 16, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3621), null, "product-2.png", "High quality water slide, with sun protection.", "Product 16", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 17, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3625), null, "product-2.png", "High quality water slide, with sun protection.", "Product 17", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 18, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3629), null, "product-2.png", "High quality water slide, with sun protection.", "Product 18", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 19, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3632), null, "product-2.png", "High quality water slide, with sun protection.", "Product 19", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 20, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3636), null, "product-2.png", "High quality water slide, with sun protection.", "Product 20", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 21, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3640), null, "product-2.png", "High quality water slide, with sun protection.", "Product 21", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 22, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3644), null, "product-2.png", "High quality water slide, with sun protection.", "Product 22", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 23, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3647), null, "product-2.png", "High quality water slide, with sun protection.", "Product 23", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 24, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3650), null, "product-2.png", "High quality water slide, with sun protection.", "Product 24", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 25, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3653), null, "product-2.png", "High quality water slide, with sun protection.", "Product 25", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 26, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3657), null, "product-2.png", "High quality water slide, with sun protection.", "Product 26", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 27, 3, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3660), null, "product-2.png", "High quality water slide, with sun protection.", "Product 27", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 15, 2, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3618), null, "product-2.png", "High quality water slide, with sun protection.", "Product 15", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 1 },
                    { 59, 8, new DateTime(2021, 4, 8, 6, 4, 0, 123, DateTimeKind.Local).AddTicks(3821), null, "product-2.png", "High quality water slide, with sun protection.", "Product 59", "Viet nam", 98000.0, "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TypeProductId",
                table: "Categories",
                column: "TypeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
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
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Promotions");

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
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TypeProducts");
        }
    }
}
