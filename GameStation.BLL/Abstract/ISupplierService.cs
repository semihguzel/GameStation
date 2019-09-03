using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface ISupplierService
    {
        List<Supplier> GetAll();
        Supplier GetById(int Id);

        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int supplierId);
    }
}
