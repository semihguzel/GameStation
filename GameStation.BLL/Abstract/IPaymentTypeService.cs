using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface IPaymentTypeService
    {
        List<PaymentType> GetAll();
        void Add(PaymentType paymentType);
        void Update(PaymentType paymentType);
        void Delete(int paymentTypeId);
    }
}
