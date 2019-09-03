using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.OrderID);
            builder.Property(x => x.TotalAmount).HasColumnType("money");
            builder.Property(x => x.OrderDate).HasColumnType("datetime2");
            builder.Property(x => x.DispatchDate).HasColumnType("datetime2");
            builder.Property(x => x.ShippedDate).HasColumnType("datetime2");
            builder.Property(x => x.DeliveryDate).HasColumnType("datetime2");
            builder.Property(x => x.Notes).HasMaxLength(150);
        }
    }
}
