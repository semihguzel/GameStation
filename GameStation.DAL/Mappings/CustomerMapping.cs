using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.CustomerID);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BirthDate).HasColumnType("date");
            builder.Property(x => x.Organization).HasMaxLength(50);
            builder.Property(x => x.Country).HasMaxLength(20);
            builder.Property(x => x.State).HasMaxLength(20);
            builder.Property(x => x.City).HasMaxLength(20);
            builder.Property(x => x.PostalCode).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(40);
            builder.Property(x => x.AltEmail).HasMaxLength(40);
            builder.Property(x => x.Phone1).HasMaxLength(20);
            builder.Property(x => x.Mobile1).HasMaxLength(20);
            builder.Property(x => x.Mobile2).HasMaxLength(20);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Picture).HasMaxLength(400);
            builder.Property(x => x.Status).HasMaxLength(20);
            builder.Property(x => x.LastLogin).HasColumnType("datetime2");
            builder.Property(x => x.LastLogin).HasColumnType("date");
            builder.Property(x => x.Notes).HasMaxLength(250);
            
            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerID).IsRequired();
            builder.HasMany(x => x.RecentlyViews).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerID).IsRequired();
            builder.HasMany(x => x.Reviews).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerID).IsRequired();
            builder.HasMany(x => x.WishLists).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerID).IsRequired();
        }
    }
}
