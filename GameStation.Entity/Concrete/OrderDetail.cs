using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class OrderDetail : IEntity
    {
        public int OrderDetailID { get; set; }

        public int ProductID { get; set; }

        public int CustomerID { get; set; }

        public bool IsCompleted { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }



        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}