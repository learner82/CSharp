using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebakery.Models
{
    public class UserCouponCombinedViewModel
    {
        public List<Coupon> Coupons { get; set; }
        public User User { get; set; }
    }
}