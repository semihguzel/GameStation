using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");
            builder.HasKey(x => x.SupplierID);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ContactName).HasMaxLength(50);
            builder.Property(x => x.ContactTitle).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(150);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.Fax).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(50);
            builder.Property(x => x.Country).HasMaxLength(50);

            builder.HasMany(x => x.Products).WithOne(x => x.Supplier).HasForeignKey(x => x.SupplierID).IsRequired();

            //Seed
            builder.HasData
            (
                new Supplier
                {
                    SupplierID = 1,
                    CompanyName = "Steam",
                    ContactName = "Gabe Newell",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    SupplierID = 2,
                    CompanyName = "Electronic Arts",
                    ContactName = "Trip Hawkins",
                    ContactTitle = "Founder"
                }
            );
        }
    }
}
