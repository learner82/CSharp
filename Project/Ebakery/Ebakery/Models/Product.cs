using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Coupon")]
        public int CouponId { get; set; }
        public virtual Coupon Coupon { get; set; }

        [ForeignKey("OrderItem")]
        public int OrederItemId { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}