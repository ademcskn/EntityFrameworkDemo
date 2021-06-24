using EntityFrameworkDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //fluent mapping
        //    //modelBuilder.HasDefaultSchema("dbo");

        //    modelBuilder.Entity<Product>().ToTable("Products");

        //    modelBuilder.Entity<Product>().Property(p => p.ProductId).HasColumnType("ProductID");
        //    modelBuilder.Entity<Product>().Property(p => p.CategoryId).HasColumnType("CategoryID");
        //    modelBuilder.Entity<Product>().Property(p => p.ProductName).HasColumnName("ProductName");
        //    modelBuilder.Entity<Product>().Property(p => p.QuantityPerUnit).HasColumnName("QuantityPerUnit");
        //    modelBuilder.Entity<Product>().Property(p => p.UnitPrice).HasColumnName("UnitPrice");
        //    modelBuilder.Entity<Product>().Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");
        //}
    }
}
