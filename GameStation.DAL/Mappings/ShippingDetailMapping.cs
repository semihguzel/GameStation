using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class ShippingDetailMapping : IEntityTypeConfiguration<ShippingDetail>
    {
        public void Configure(EntityTypeBuilder<ShippingDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}
