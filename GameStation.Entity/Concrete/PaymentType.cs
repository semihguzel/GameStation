using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class PaymentType : IEntity
    {
        public int PaymentTypeID { get; set; }

        public string TypeName { get; set; }

        public string Description { get; set; }



        public virtual ICollection<Payment> Payments { get; set; }

    }
}