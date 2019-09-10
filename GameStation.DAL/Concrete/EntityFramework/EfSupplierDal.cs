using GameStation.Core.DAL;
using GameStation.Core.DAL.EntityFramework;
using GameStation.DAL.Abstract;
using GameStation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Concrete.EntityFramework
{
    public class EfSupplierDal : EfEntityRepositoryBase<Supplier,GameStationContext>,ISupplierDal
    {

    }
}
