using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
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

            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID).IsRequired();

            //Seed
            builder.HasData
            (
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "FPS",
                    IsActive = true,
                    Description = "First Person Shooter games",
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "TPS",
                    IsActive = true,
                    Description = "Third Person Shooter games"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "RPG",
                    IsActive = true,
                    Description = "Role Playing Game"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Strategy",
                    IsActive = true,
                    Description = "Strategy Game"
                }
            );
        }
    }
}
