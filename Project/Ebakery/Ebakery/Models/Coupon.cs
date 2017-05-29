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

        public string Name { get; set; }
        public DateTime Date { get; set; }
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Description Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public decimal Discount { get; set; }

        [ForeignKey("Owner")]
        public int UserId { get; set; }
        public virtual User Owner { get; set; }

    }
}