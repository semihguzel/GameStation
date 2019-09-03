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
            builder.ToTable("RecentlyViews");
            builder.HasKey(x => x.RecentlyViewID);
            builder.Property(x => x.ViewDate).HasColumnType("datetime2");
            builder.Property(x => x.Notes).HasMaxLength(150);
        }
    }
}
