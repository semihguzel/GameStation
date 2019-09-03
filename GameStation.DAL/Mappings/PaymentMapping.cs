using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class PaymentMapping : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(x => x.PaymentID);
            builder.Property(x => x.CreditAmount).HasColumnType("money");
            builder.Property(x => x.DebitAmount).HasColumnType("money");
            builder.Property(x => x.Balance).HasColumnType("money");
            builder.Property(x => x.PaymentDatetime).HasColumnType("datetime2");

            builder.HasMany(x => x.Orders).WithOne(x => x.Payment).HasForeignKey(x => x.PaymentID).IsRequired();
        }
    }
}
