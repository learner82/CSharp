using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebakery.Models;



namespace Ebakery.Controllers
{
    public class AdminController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult CouponCreation()
        {
            return View();
        }

        public ActionResult MyCustomers()
        {
            return View();
        }
    }
}