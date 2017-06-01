using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ebakery.Models;
using System.Web.Mvc;
using System.Web.Security;

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
            
            if (db.Users.Count(x=>x.Email==user.Email) == 0)   // petaei exception oti den mporei na kanei metatroph to int se string , prepei na allaksw key?
            {
                user.IsAdmin = false;
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
        public ActionResult LogIn(string Email, string Password)
        {
            //User u = (User)(db.Users.Where(x => x.Email == Email));
            // User u =(User)(db.Users.Where((x=>x.Email==email) & (x=>x.Password==password));
            User u = db.Users.FirstOrDefault((x => x.Email == Email && x.Password == Password)); //& (x=>x.Password == password));
            if (u == null)
            {
                ViewBag.NotMatching = true;
                return View();
            }
            if (u.IsAdmin == false) 
            {
                var name = u.Name;
                // Login Successful
                FormsAuthentication.SetAuthCookie(name, false);
                Session.Add("User", u);
                return RedirectToAction("Index");
            }
             else
             {
                var name = u.Name;
                // Login Successful
                FormsAuthentication.SetAuthCookie("Admin", false);
                Session.Add("User", u);
                return RedirectToAction("Index", "Admin");
            } 
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
        public ActionResult Cart()
        {
            return View();
        }

        

    }
}