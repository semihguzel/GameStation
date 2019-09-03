using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IShippingDetailService
    {
        List<ShippingDetail> GetAll();
        void Add(ShippingDetail shippingDetail);
        void Update(ShippingDetail shippingDetail);
        void Delete(int shippingDetailId);
    }
}
