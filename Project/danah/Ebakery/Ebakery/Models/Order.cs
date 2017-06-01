using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public bool HasDiscount { get; set; }
       
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual User Customer { get; set; }  // h ka8e paraggelia exei ena customer 

        [ForeignKey("Basket")]
        public int BasketId { get; set; }
        public Basket Basket { get; set; }

    }
}