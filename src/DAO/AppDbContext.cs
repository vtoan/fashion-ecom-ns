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
            modelBuilder.Entity<Product>().Property(p => p.Material).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.Origin).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.ProductDescription).HasMaxLength(250);
            modelBuilder.Entity<Product>().Property(o => o.DateCreated).HasColumnType("smalldatetime");
            modelBuilder.Entity<Product>().Property(o => o.DateModified).HasColumnType("smalldatetime");
            //ProductDetail
            modelBuilder.Entity<ProductAttr>().HasKey(p => p.Id);
            modelBuilder.Entity<ProductAttr>().Property(p => p.Size).HasMaxLength(20);
            modelBuilder.Entity<ProductAttr>().Property(p => p.SaleCount).HasDefaultValue(0);
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

            _seedData(modelBuilder);
        }

        private void _seedData(ModelBuilder modelBuilder)
        {
            var SeedTypeProducts = new List<TypeProduct>(){
                new TypeProduct { Id = 1, Name = "Shirts" },
                new TypeProduct { Id = 2, Name = "Pants" },
                new TypeProduct { Id = 3, Name = "Jackets" }
            };

            var SeedCategorys = new List<Category>(){
                new Category { Id = 1, Name = "T-Shirts", TypeProductId = 1 },
                new Category { Id = 2, Name = "Polos", TypeProductId = 1 },
                new Category { Id = 3, Name = "Texedo Shirts", TypeProductId = 1 },
                new Category { Id = 4, Name = "Kakis", TypeProductId = 2 },
                new Category { Id = 5, Name = "Jeans", TypeProductId = 2 },
                new Category { Id = 6, Name = "Jogger", TypeProductId = 2 },
                new Category { Id = 7, Name = "Hoodies", TypeProductId = 3 },
                new Category { Id = 8, Name = "Coats", TypeProductId = 3 }
            };

            var SeedPrice = new double[] { 159000, 230000, 199000, 300000, 450000, 250000, 350000, 500000 };
            var SeedProducts = new List<Product>();
            //product;
            int productPerCate = 10;
            int idInitProduct = 1;
            var rd = new Random();
            for (int i = 0; i < SeedCategorys.Count; i++)
            {
                for (int j = 0; j < productPerCate; j++)
                {
                    var priceIndex = rd.Next(0, 7);
                    SeedProducts.Add(new Product
                    {
                        Id = idInitProduct,
                        Name = "Product Name",
                        Price = SeedPrice[priceIndex],
                        Material = "High quality water slide, with sun protection.",
                        Origin = "Viet nam",
                        ProductDescription = "The ultimate summer staplt./Just dont call them./These shorts are Real Good: made in a factory that meets our standards for water recycling and reduction./High stretch level that keeps its shape.",
                        CategoryId = SeedCategorys[i].Id,
                        TypeProductId = SeedCategorys[i].TypeProductId,
                        DateCreated = DateTime.Now,
                    });
                    idInitProduct++;
                }
            }

            //
            var SeedAttributes = new List<ProductAttr>();
            int idInitAttr = 1;
            for (int i = 0; i < SeedProducts.Count; i++)
            {
                SeedAttributes.Add(new ProductAttr() { Id = idInitAttr, Size = "S", ProductId = SeedProducts[i].Id, SaleCount = 0 });
                idInitAttr++;
                SeedAttributes.Add(new ProductAttr() { Id = idInitAttr, Size = "L", ProductId = SeedProducts[i].Id, SaleCount = 0 });
                idInitAttr++;
            }

            modelBuilder.Entity<Fee>().HasData(
                          new Fee { Id = 1, Name = "Tax", Cost = 0.05 }
                      );
            modelBuilder.Entity<TypeProduct>().HasData(SeedTypeProducts);
            modelBuilder.Entity<Category>().HasData(SeedCategorys);
            modelBuilder.Entity<Product>().HasData(SeedProducts);
            modelBuilder.Entity<ProductAttr>().HasData(SeedAttributes);
            //
        }
    }
}
