﻿using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        Product GetById(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
