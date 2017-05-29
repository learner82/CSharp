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
            if (Session["Email"] == null)
            {
                return RedirectToAction("Signin");
            }
            User u = db.Users.Find((string)Session["Email"]);
            if (u == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CouponCreation(Coupon coupon)
        {
            if (db.Coupons.Find(coupon.Id) == null)
            {
                db.Coupons.Add(coupon);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.IdExists = true;
                return View();
            }
        }

        [HttpPost]
        public ActionResult Register(string email)
        {
            return View();
        }

        public ActionResult MyCustomers()
        {

            return View();
        }
    }
}