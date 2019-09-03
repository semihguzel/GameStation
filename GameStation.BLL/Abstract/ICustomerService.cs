﻿using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
    }
}
