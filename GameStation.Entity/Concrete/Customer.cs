using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string Organization { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public string AltEmail { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Mobile1 { get; set; }

        public string Mobile2 { get; set; }

        public string Address { get; set; }

        public string Picture { get; set; }

        public string Status { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Notes { get; set; }



        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<WishList> WishLists { get; set; }
    }
}