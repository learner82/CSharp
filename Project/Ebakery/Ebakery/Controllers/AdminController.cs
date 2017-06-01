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


        [Authorize]
        public ActionResult Index()
        {
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("Signin", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        [Authorize]
        public ActionResult CouponCreation()
        {
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("SignΙn", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CouponCreation(Coupon coupon)
        {
            if (db.Coupons.Count(x=>x.Name==coupon.Name) == 0)
            {
                User u = (User)Session["User"];
                coupon.UserId = u.Id;
                db.Coupons.Add(coupon);
                
                db.SaveChanges();

                return RedirectToAction("Coupons");
            }
            else
            {
                ViewBag.IdExists = true;
                return View();
            }
        }

        [Authorize]
        public ActionResult MyCustomers()
        {

            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("Signin", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();

        }



        [Authorize]
        public ActionResult Coupons()
        {
            User u = (User)Session["User"];
            if (u == null)
            {
                return RedirectToAction("Signin", "Home");
            }
            if (u.IsAdmin == false)
            {
                return RedirectToAction("Index", "Home");
            }

            UserCouponCombinedViewModel vm = new UserCouponCombinedViewModel();
            vm.Coupons = db.Coupons.ToList();
            return View(vm);
        }

        public ActionResult NewsLetter()
        {
           UserCouponCombinedViewModel vmNewsLetter = new UserCouponCombinedViewModel();
           vmNewsLetter.Coupons = db.Coupons.ToList();
           return View(vmNewsLetter);
        }



    }

}