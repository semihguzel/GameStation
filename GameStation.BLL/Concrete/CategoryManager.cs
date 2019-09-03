using GameStation.BLL.Abstract;
using GameStation.DAL.Abstract;
using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(_categoryDal.Get(x => x.CategoryID == categoryId));
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(x => x.CategoryID == categoryId);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
