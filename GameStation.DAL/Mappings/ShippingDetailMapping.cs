using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class ShippingDetailMapping : IEntityTypeConfiguration<ShippingDetail>
    {
        public void Configure(EntityTypeBuilder<ShippingDetail> builder)
        {
            builder.ToTable("ShippingDetails");
            builder.HasKey(x => x.ShippingDetailID);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Mobile).HasMaxLength(30);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Province).HasMaxLength(30);
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.PostalCode).HasMaxLength(25);

            builder.HasMany(x => x.Orders).WithOne(x => x.ShippingDetail).HasForeignKey(x => x.ShippingDetailID).IsRequired();
        }
    }
}
