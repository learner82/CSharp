using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }

        [ForeignKey("Owner")]
        public int UserId { get; set; }
        public virtual User Owner { get; set; }

    }
}