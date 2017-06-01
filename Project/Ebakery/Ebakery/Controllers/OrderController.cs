using Ebakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebakery.Controllers
{
    public class OrderController : Controller
    {
        private MyContext db = new MyContext();

        // GET: Order
        public ActionResult AddOrderItem(int Id) // Ayto na phgainei kai na kanei add sto session to product gia to order
        {
            return View();
        }


        public ActionResult CheckCoupon(string Couponcode)   // Na kanei ton elegxo gia to kouponi
        {
            return View();
        }
    }
}