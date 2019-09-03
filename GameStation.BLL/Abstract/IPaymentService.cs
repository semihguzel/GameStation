using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IPaymentService
    {
        List<Payment> GetAll();
        Payment GetById(int Id);

        void Add(Payment payment);
        void Update(Payment payment);
        void Delete(int paymentId);
    }
}
