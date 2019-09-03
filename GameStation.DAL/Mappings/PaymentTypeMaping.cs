using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class PaymentTypeMaping : IEntityTypeConfiguration<PaymentType>
    {
        public void Configure(EntityTypeBuilder<PaymentType> builder)
        {
            throw new NotImplementedException();
        }
    }
}
