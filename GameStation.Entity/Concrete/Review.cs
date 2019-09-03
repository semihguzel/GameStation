using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Review : IEntity
    {
        public int ReviewID { get; set; }

        public string CustomerID { get; set; }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Comment { get; set; }

        public int Rate { get; set; }

        public DateTime Datetime { get; set; }

        public bool IsDeleted { get; set; }



        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

    }
}