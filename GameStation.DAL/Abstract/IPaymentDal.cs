using GameStation.Core.DAL;
using MVCeTicaret.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Abstract
{
    public interface IPaymentDal : IEntityRepository<Payment>
    {
    }
}
