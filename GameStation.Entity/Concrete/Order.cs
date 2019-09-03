using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Order : IEntity
    {
        [Key]
        public int OrderID { get; set; }

        [Required, ForeignKey("OrderDetail")]
        public int OrderDetailID { get; set; }

        [Required, ForeignKey("Payment")]
        public int PaymentID { get; set; }

        [Required, ForeignKey("ShippingDetail")]
        public int ShippingDetailID { get; set; }

        public decimal Discount { get; set; }

        public decimal? Taxes { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public bool IsCompleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        public bool Dispatched { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DispatchDate { get; set; }

        public bool Shipped { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ShippedDate { get; set; }

        public bool Deliver { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DeliveryDate { get; set; }

        [MaxLength(150)]
        public string Notes { get; set; }

        public bool CancelOrder { get; set; }



        public virtual OrderDetail OrderDetail { get; set; }

        public virtual ShippingDetail ShippingDetail { get; set; }

        public virtual Payment Payment { get; set; }
    }
}