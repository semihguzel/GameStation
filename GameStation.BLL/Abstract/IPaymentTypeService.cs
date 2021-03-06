﻿using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    public interface IPaymentTypeService
    {
        List<PaymentType> GetAll();
        PaymentType GetById(int Id);

        void Add(PaymentType paymentType);
        void Update(PaymentType paymentType);
        void Delete(int paymentTypeId);
    }
}
