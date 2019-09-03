using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class WishList : IEntity
    {
        public int WishListID { get; set; }

        public string CustomerID { get; set; }

        public int ProductID { get; set; }

        public bool IsActive { get; set; }



        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}