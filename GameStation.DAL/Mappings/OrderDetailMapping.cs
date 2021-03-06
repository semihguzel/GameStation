﻿using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class OrderDetailMapping : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => x.OrderDetailID);
            builder.Property(x => x.UnitPrice).HasColumnType("money");
            builder.Property(x => x.TotalAmount).HasColumnType("money");
            builder.Property(x => x.OrderDate).HasColumnType("datetime2");

            builder.HasMany(x => x.Orders).WithOne(x => x.OrderDetail).HasForeignKey(x => x.OrderDetailID).IsRequired();
        }
    }
}
