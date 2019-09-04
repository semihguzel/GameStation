using GameStation.Core.DAL.EntityFramework;
using GameStation.DAL.Abstract;
using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, GameStationContext>, IProductDal
    {

    }
}
