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

            builder.HasMany(x => x.SubCategories).WithOne(x => x.Category).HasForeignKey(x => x.SubCategoryID).IsRequired();

            //Seed
            builder.HasData
            (
                new Category
                {
                    CategoryName = "Steam",
                    Description = "Steam is a video game digital distribution platform developed by Valve Corporation. It was launched in September 2003 as a way for Valve to provide automatic updates for their games, but eventually expanded to include games from third-party publishers. Steam offers digital rights management (DRM), matchmaking servers, video streaming, and social networking services. It also provides the user with installation and automatic updating of games, and community features such as friends lists and groups, cloud saving, and in-game voice and chat functionality.",
                    IsActive = true,
                    Picture1 = Tools.PicturesDirectory + "/SubCategoryPictures/steam_logo.png"
                },
                new Category
                {
                    CategoryName = "Origin",
                    Description = "Origin is a digital distribution platform developed by Electronic Arts for purchasing and playing video games. The platform's software client is available for personal computer and mobile platforms.",
                    IsActive = true,
                    Picture1 = Tools.PicturesDirectory + "/SubCategoryPictures/origin_logo.png"
                }
            );
        }
    }
}
