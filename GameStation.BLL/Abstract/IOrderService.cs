using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int Id);

        void Add(Order order);
        void Update(Order order);
        void Delete(int orderId);
    }
}
