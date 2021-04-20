using System;
using System.Collections.Generic;
using BUS.Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttr> ProductAttrs { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Type
            modelBuilder.Entity<TypeProduct>().Property(p => p.Name).HasMaxLength(50);
            //Category
            modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(50);
            //Fee
            modelBuilder.Entity<Fee>().Property(p => p.Name).HasMaxLength(100);
            modelBuilder.Entity<Fee>().Property(p => p.Cost).HasColumnType("decimal(2,2)");
            //Order
            modelBuilder.Entity<Order>().Property(o => o.DateCreated).HasColumnType("smalldatetime");
            modelBuilder.Entity<Order>().Property(o => o.CustomerName).HasMaxLength(250);
            modelBuilder.Entity<Order>().Property(o => o.CustomerPhone).HasMaxLength(50);
            modelBuilder.Entity<Order>().Property(o => o.CustomerEmail).HasMaxLength(150);
            modelBuilder.Entity<Order>().Property(o => o.CustomerDistrict).HasMaxLength(10);
            modelBuilder.Entity<Order>().Property(o => o.CustomerProvince).HasMaxLength(10);
            modelBuilder.Entity<Order>().Property(o => o.CustomerAddress).HasMaxLength(500);
            modelBuilder.Entity<Order>().Property(o => o.Note).HasMaxLength(750);
            modelBuilder.Entity<Order>().Property(o => o.Fees).HasMaxLength(150);
            //OrderDetail
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ProductAttrId });
            //Product
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(250);
            modelBuilder.Entity<Product>().Property(p => p.Image).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.isDel).HasDefaultValue(false);
            modelBuilder.Entity<Product>().Property(p => p.SaleCount).HasDefaultValue(0);
            modelBuilder.Entity<Product>().Property(p => p.Material).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.Origin).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.ProductDescription).HasMaxLength(250);
            modelBuilder.Entity<Product>().Property(o => o.DateCreated).HasColumnType("smalldatetime");
            modelBuilder.Entity<Product>().Property(o => o.DateModified).HasColumnType("smalldatetime");
            //ProductDetail
            modelBuilder.Entity<ProductAttr>().HasKey(p => p.Id);
            modelBuilder.Entity<ProductAttr>().Property(p => p.Size).HasMaxLength(20);
            //Rating
            modelBuilder.Entity<Rating>().HasKey(od => od.Id);
            modelBuilder.Entity<Rating>().Property(p => p.Feedback).HasMaxLength(250);
            modelBuilder.Entity<Rating>().Property(o => o.DateCreated).HasColumnType("smalldatetime");
            modelBuilder.Entity<Rating>().Property(o => o.Rate).HasColumnType("tinyint");
            //Identity
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeProduct>().HasData(
                new TypeProduct { Id = 1, Name = "Shirts" },
                new TypeProduct { Id = 2, Name = "Pants" }
            );

            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "T-Shirtss", TypeProductId = 1 },
               new Category { Id = 2, Name = "Polos", TypeProductId = 1 },
               new Category { Id = 3, Name = "Texedo Shirts", TypeProductId = 1 },
               new Category { Id = 4, Name = "Tank Tops", TypeProductId = 1 },
               new Category { Id = 5, Name = "Dress Shirts", TypeProductId = 1 },
               new Category { Id = 6, Name = "Kakis", TypeProductId = 2 },
               new Category { Id = 7, Name = "Jeans", TypeProductId = 2 },
               new Category { Id = 8, Name = "Jogger", TypeProductId = 2 },
               new Category { Id = 9, Name = "Slim fit", TypeProductId = 2 },
               new Category { Id = 10, Name = "Dress Pants", TypeProductId = 2 }
           );

            modelBuilder.Entity<Fee>().HasData(
                new Fee { Id = 1, Name = "Tax", Cost = 0.05 }
            );

            var arrTemp = new List<Product>();
            //type product 1;
            for (int i = 1; i < 10; i++)
            {
                arrTemp.Add(new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = 98000,
                    Image = "product-1.png",
                    Material = "High quality water slide, with sun protection.",
                    Origin = "Viet nam",
                    ProductDescription = "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động",
                    CategoryId = 1,
                    TypeProductId = 1,
                    DateCreated = DateTime.Now
                });
            };
            for (int i = 10; i < 20; i++)
            {
                arrTemp.Add(new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = 98000,
                    Image = "product-2.png",
                    Material = "High quality water slide, with sun protection.",
                    Origin = "Viet nam",
                    ProductDescription = "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động",
                    CategoryId = 2,
                    TypeProductId = 1,
                    DateCreated = DateTime.Now
                });
            };
            for (int i = 20; i < 30; i++)
            {
                arrTemp.Add(new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = 98000,
                    Image = "product-2.png",
                    Material = "High quality water slide, with sun protection.",
                    Origin = "Viet nam",
                    ProductDescription = "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động",
                    CategoryId = 3,
                    TypeProductId = 1,
                    DateCreated = DateTime.Now
                });
            };
            //type product 2
            for (int i = 30; i < 40; i++)
            {
                arrTemp.Add(new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = 98000,
                    Image = "product-1.png",
                    Material = "High quality water slide, with sun protection.",
                    Origin = "Viet nam",
                    ProductDescription = "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động",
                    CategoryId = 6,
                    TypeProductId = 2,
                    DateCreated = DateTime.Now
                });
            };
            for (int i = 40; i < 50; i++)
            {
                arrTemp.Add(new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = 98000,
                    Image = "product-2.png",
                    Material = "High quality water slide, with sun protection.",
                    Origin = "Viet nam",
                    ProductDescription = "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động",
                    CategoryId = 7,
                    TypeProductId = 2,
                    DateCreated = DateTime.Now
                });
            };
            for (int i = 50; i < 60; i++)
            {
                arrTemp.Add(new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = 98000,
                    Image = "product-2.png",
                    Material = "High quality water slide, with sun protection.",
                    Origin = "Viet nam",
                    ProductDescription = "Thiết kế, lên form chuẩn, tạo cảm giác thoải mái cho người mặc/Đường may tỉ mỉ/Thích hợp cho các bạn nam dạo phố, đi chơi, đi làm, tôn lên được sự trẻ trung, năng động",
                    CategoryId = 8,
                    TypeProductId = 2,
                    DateCreated = DateTime.Now
                });
            };
            modelBuilder.Entity<Product>().HasData(arrTemp);
            //
        }
    }
}
