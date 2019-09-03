using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class PaymentTypeMaping : IEntityTypeConfiguration<PaymentType>
    {
        public void Configure(EntityTypeBuilder<PaymentType> builder)
        {
            builder.ToTable("PaymentTypes");
            builder.HasKey(x => x.PaymentTypeID);
            builder.Property(x => x.TypeName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(150);

            builder.HasMany(x => x.Payments).WithOne(x => x.PaymentType).HasForeignKey(x => x.PaymentTypeID).IsRequired();
        }
    }
}
