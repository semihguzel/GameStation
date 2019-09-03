using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.ProductID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.QuantityPerUnit).HasMaxLength(50);
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("money");
            builder.Property(x => x.OldPrice).HasColumnType("money");
            builder.Property(x => x.UnitWeight).HasMaxLength(30);
            builder.Property(x => x.Size).HasMaxLength(30);
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(500);
            builder.Property(x => x.AltText).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(300);
            builder.Property(x => x.LongDescription).IsRequired().HasMaxLength(1500);
            builder.Property(x => x.Picture1).HasMaxLength(500);
            builder.Property(x => x.Picture2).HasMaxLength(500);
            builder.Property(x => x.Picture3).HasMaxLength(500);
            builder.Property(x => x.Picture4).HasMaxLength(500);
            builder.Property(x => x.Notes).HasMaxLength(250);

            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductID);
            builder.HasMany(x => x.RecentlyViews).WithOne(x => x.Product).HasForeignKey(x => x.ProductID);
            builder.HasMany(x => x.Reviews).WithOne(x => x.Product).HasForeignKey(x => x.ProductID);
            builder.HasMany(x => x.WishLists).WithOne(x => x.Product).HasForeignKey(x => x.ProductID);
        }
    }
}
