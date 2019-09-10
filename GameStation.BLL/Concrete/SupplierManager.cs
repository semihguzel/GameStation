using GameStation.BLL.Abstract;
using GameStation.DAL.Abstract;
using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }
        public void Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
        }

        public void Delete(int supplierId)
        {
            _supplierDal.Delete(_supplierDal.Get(x => x.SupplierID == supplierId));
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetList();
        }

        public Supplier GetById(int Id)
        {
            return _supplierDal.Get(x => x.SupplierID == Id);
        }

        public void Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
        }
    }
}
