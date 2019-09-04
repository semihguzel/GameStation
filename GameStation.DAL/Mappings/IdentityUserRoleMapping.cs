using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class IdentityUserRoleMapping : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            string adminId = Tools.adminId.ToString();
            string userId = Tools.userId.ToString();

            builder.HasData
            (
                new IdentityUserRole<string>
                {
                    RoleId = adminId,
                    UserId = userId
                }
            );
        }
    }
}
