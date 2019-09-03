using GameStation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameStation.Entity.Concrete
{
    public class SubCategory : IEntity
    {
        [Key]
        public int SubCategoryID { get; set; }

        [Required ,ForeignKey("Category")]
        public int CategoryID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string Picture1 { get; set; }

        [MaxLength(500)]
        public string Picture2 { get; set; }

        public bool IsActive { get; set; }



        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}