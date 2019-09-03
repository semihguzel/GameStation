﻿using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class ShippingDetail : IEntity
    {
        public int ShippingDetailID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }



        public virtual ICollection<Order> Orders { get; set; }
    }
}