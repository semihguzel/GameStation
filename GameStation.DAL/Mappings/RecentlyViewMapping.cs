using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class RecentlyViewMapping : IEntityTypeConfiguration<RecentlyView>
    {
        public void Configure(EntityTypeBuilder<RecentlyView> builder)
        {
            throw new NotImplementedException();
        }
    }
}
