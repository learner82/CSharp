using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebakery.Controllers
{
    public class AdminController : Controller
    {
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