using GameStation.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class CustomIdentityUserMapping : IEntityTypeConfiguration<CustomIdentityUser>
    {
        public void Configure(EntityTypeBuilder<CustomIdentityUser> builder)
        {
            string userId = Tools.userId.ToString();
            var hasher = new PasswordHasher<CustomIdentityUser>();
            builder.HasData
            (
                new CustomIdentityUser
                {
                    Id = userId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin123."),
                    SecurityStamp = string.Empty
                }
            );
            
        }
    }
}
