using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class CustomIdentityRoleMapping : IEntityTypeConfiguration<CustomIdentityRole>
    {
        public void Configure(EntityTypeBuilder<CustomIdentityRole> builder)
        {
            string adminId = Tools.adminId.ToString();
            builder.HasData
            (   
                new CustomIdentityRole
                {
                    Id = adminId,
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                }
            );
        }
    }
}
