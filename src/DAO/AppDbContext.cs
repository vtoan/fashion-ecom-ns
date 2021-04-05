using System;
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
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
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
            modelBuilder.Entity<Order>().Property(o => o.Promotions).HasMaxLength(150);
            modelBuilder.Entity<Order>().Property(o => o.Fees).HasMaxLength(150);
            //OrderDetail
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ProductId });
            modelBuilder.Entity<OrderDetail>().Property(p => p.Discount).HasColumnType("decimal(2,2)");
            //Product
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(250);
            modelBuilder.Entity<Product>().Property(p => p.Image).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.isDel).HasDefaultValue(false);
            modelBuilder.Entity<Product>().Property(p => p.SaleCount).HasDefaultValue(0);
            modelBuilder.Entity<Product>().Property(p => p.Material).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.Origin).HasDefaultValue(150);
            modelBuilder.Entity<Product>().Property(p => p.ProductDescription).HasDefaultValue(250);
            //ProductDetail
            modelBuilder.Entity<ProductDetail>().Property(p => p.Size).HasMaxLength(20);
            modelBuilder.Entity<ProductDetail>().Property(p => p.Color).HasMaxLength(20);
            //Rating
            modelBuilder.Entity<Rating>().HasKey(od => new { od.ProductId, od.UserId });
            modelBuilder.Entity<Rating>().Property(p => p.Feedback).HasMaxLength(250);
            //Config Promotion
            modelBuilder.Entity<Promotion>().Property(p => p.ToDate).HasColumnType("smalldatetime");
            modelBuilder.Entity<Promotion>().Property(p => p.FromDate).HasColumnType("smalldatetime");
            modelBuilder.Entity<Promotion>().Property(p => p.isAll).HasDefaultValue(false);
            modelBuilder.Entity<Promotion>().Property(p => p.Discount).HasColumnType("decimal(2,2)");
            modelBuilder.Entity<Promotion>().Property(p => p.TypeIds).HasMaxLength(20);
            modelBuilder.Entity<Promotion>().Property(p => p.CateIds).HasMaxLength(30);
            modelBuilder.Entity<Promotion>().Property(p => p.ProductIds).HasMaxLength(250);
            //Identity
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }


    }
}
