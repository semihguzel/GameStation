using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Picture1 { get; set; }

        public string Picture2 { get; set; }

        public bool IsActive { get; set; }



        public virtual ICollection<Product> Products { get; set; }
    }
}