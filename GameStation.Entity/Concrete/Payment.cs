﻿using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Payment : IEntity
    {
        [Key]
        public int PaymentID { get; set; }

        [Required, ForeignKey("PaymentType")]
        public int PaymentTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal CreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal DebitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PaymentDatetime { get; set; }



        public virtual PaymentType PaymentType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}