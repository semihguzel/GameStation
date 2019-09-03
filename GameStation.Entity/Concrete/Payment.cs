using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentID { get; set; }

        public int PaymentTypeID { get; set; }

        public decimal CreditAmount { get; set; }

        public decimal DebitAmount { get; set; }

        public decimal Balance { get; set; }

        public DateTime PaymentDatetime { get; set; }



        public virtual PaymentType PaymentType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}