using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Supplier : IEntity
    {
        public int SupplierID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string Country { get; set; }



        public virtual ICollection<Product> Products { get; set; }
    }
}