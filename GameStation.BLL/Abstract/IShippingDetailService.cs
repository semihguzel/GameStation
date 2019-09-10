using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    public interface IShippingDetailService
    {
        List<ShippingDetail> GetAll();
        ShippingDetail GetById(int Id);

        void Add(ShippingDetail shippingDetail);
        void Update(ShippingDetail shippingDetail);
        void Delete(int shippingDetailId);
    }
}
