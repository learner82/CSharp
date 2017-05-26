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
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public bool Validity { get; set; }
        public DateTime Date { get; set; }
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Description Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public decimal Discount { get; set; }

        [ForeignKey("Owner")]
        public int UserId { get; set; }
        public virtual User Owner { get; set; }

        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}