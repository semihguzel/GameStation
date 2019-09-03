using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }

        public int OrderDetailID { get; set; }

        public int PaymentID { get; set; }

        public int ShippingDetailID { get; set; }

        public decimal Discount { get; set; }

        public decimal? Taxes { get; set; }

        public decimal TotalAmount { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime OrderDate { get; set; }

        public bool Dispatched { get; set; }

        public DateTime DispatchDate { get; set; }

        public bool Shipped { get; set; }

        public DateTime ShippedDate { get; set; }

        public bool Deliver { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Notes { get; set; }

        public bool CancelOrder { get; set; }



        public virtual OrderDetail OrderDetail { get; set; }

        public virtual ShippingDetail ShippingDetail { get; set; }

        public virtual Payment Payment { get; set; }
    }
}