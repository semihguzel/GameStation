using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class RecentlyView : IEntity
    {
        public int RecentlyViewID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public DateTime ViewDate { get; set; }

        public string Notes { get; set; }



        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}