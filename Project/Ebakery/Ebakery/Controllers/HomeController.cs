using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ebakery.Models;
using System.Web.Mvc;

namespace Ebakery.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Deals()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User user)
        {
            if (db.Users.Find(user.Email) == null)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("LogIn");
            }
            else
            {
                ViewBag.EmailExists = true;
                return View(user);
            }
        }
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(User user)
        {
            User u = db.Users.Find(user.Email);
            if (u == null)
            {
                ViewBag.EmailNotExists = true;
                return View(user);
            }
            if (u.Password == user.Password)
            {
                // Login Successful
                Session.Add("User", u);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.NotMatching = true;
                return View(user);
            }
        }

        public ActionResult Cart()
        {
            return View();
        }

        

    }
}