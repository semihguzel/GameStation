using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        OrderDetail GetById(int Id);

        void Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int orderDetailId);
    }
}
