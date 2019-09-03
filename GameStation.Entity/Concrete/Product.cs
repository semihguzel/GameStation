using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? OldPrice { get; set; }

        public string UnitWeight { get; set; }

        public string Size { get; set; }

        public decimal Discount { get; set; }

        public int UnitsInStock { get; set; }

        public int? UnitOnOrder { get; set; }

        public bool? ProductAvailable { get; set; }

        public string ImageUrl { get; set; }

        public string AltText { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Picture1 { get; set; }

        public string Picture2 { get; set; }

        public string Picture3 { get; set; }

        public string Picture4 { get; set; }

        public string Notes { get; set; }



        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<WishList> WishLists { get; set; }
    }
}