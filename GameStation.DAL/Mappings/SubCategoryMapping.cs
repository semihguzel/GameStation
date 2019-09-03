using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class SubCategoryMapping : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable("SubCategories");
            builder.HasKey(x => x.SubCategoryID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Picture1).HasMaxLength(500);
            builder.Property(x => x.Picture2).HasMaxLength(500);

            builder.HasMany(x => x.Products).WithOne(x => x.SubCategory).HasForeignKey(x => x.SubCategoryID).IsRequired();
        }
    }
}
