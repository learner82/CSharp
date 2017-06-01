﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class CombinedViewModel
    {
        public List<User> Users { get; set; }
        public List<Coupon> Coupons { get; set; }
        public Order Order { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public CombinedViewModel()
        {
            Coupons = new List<Coupon>();
            Products = new List<Product>();
        }
    }
}