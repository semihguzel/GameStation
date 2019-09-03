using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.BLL.Abstract
{
    interface ISubCategoryService
    {
        List<SubCategory> GetAll();
        void Add(SubCategory subCategory);
        void Update(SubCategory subCategory);
        void Delete(int subCategoryId);
    }
}
