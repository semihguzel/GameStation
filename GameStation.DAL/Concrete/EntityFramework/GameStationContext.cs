using GameStation.DAL.Mappings;
using Microsoft.EntityFrameworkCore;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Concrete.EntityFramework
{
    public class GameStationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .; Database = GameStationDb; uid = sa; pwd = sa123.;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RecentlyView> RecentlyViews { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<WishList> WishLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new OrderDetailMapping());
            modelBuilder.ApplyConfiguration(new PaymentMapping());
            modelBuilder.ApplyConfiguration(new PaymentTypeMaping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new RecentlyViewMapping());
            modelBuilder.ApplyConfiguration(new ReviewMapping());
            modelBuilder.ApplyConfiguration(new ShippingDetailMapping());
            modelBuilder.ApplyConfiguration(new SubCategoryMapping());
            modelBuilder.ApplyConfiguration(new SupplierMapping());
            modelBuilder.ApplyConfiguration(new WishListMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
