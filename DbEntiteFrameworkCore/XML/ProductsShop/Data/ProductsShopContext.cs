using Microsoft.EntityFrameworkCore;
using ProductsShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsShop.Data
{
    public class ProductsShopContext : DbContext
    {
        public ProductsShopContext()
        {
        }

        public ProductsShopContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProduct> CategoriesProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            builder.Entity<CategoryProduct>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.ProductId });
            });

            builder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.BuyerId)
                .IsRequired(false);

                entity.HasOne(e => e.Seller)
                .WithMany(c => c.Sold);

                entity.HasOne(e => e.Buyer)
                .WithMany(e => e.Bought);
            });

            builder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName)
                .IsRequired(false);

                entity.Property(e => e.Age)
                .IsRequired(false);
            });
        }

    }
}
