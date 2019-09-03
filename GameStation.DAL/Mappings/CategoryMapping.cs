using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.CategoryID);
            builder.Property(x => x.CategoryName).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Picture1).HasMaxLength(400);
            builder.Property(x => x.Picture2).HasMaxLength(400);

            builder.HasMany(x => x.SubCategories).WithOne(x => x.Category).HasForeignKey(x => x.SubCategoryID);
        }
    }
}
