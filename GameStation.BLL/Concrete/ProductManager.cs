using GameStation.BLL.Abstract;
using GameStation.DAL.Abstract;
using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(_productDal.Get(x => x.ProductID == productId));
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(x => x.CategoryID == categoryId);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(x => x.ProductID == productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
