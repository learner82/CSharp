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
       
        private MyContext db;
        public HomeController()
        {
            db = new MyContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
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
        public ActionResult Add(int id)
        {
            if (Session["basket"] == null)
            {
                Session.Add("basket", new Basket());         
            }

            Product product = db.Products.First(x => x.Id == id);
            ((Basket)Session["basket"]).Products.Add(product);
            ((Basket)Session["basket"]).Price += product.Price;
            return RedirectToAction("Order");
  
        }
        
        public ActionResult Basket()
        {
            if (Session["basket"] == null)
            {
                Basket basket = new Basket();
                
                basket.Price = 0;
                Session["basket"] = basket;
                
            }
            
            return View((Basket)Session["basket"]);
        }


        public ActionResult Contact()
        {
            var pro = db.Users.ToList();
            return View(pro);
        }

        public ActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User user)
        {

            if (db.Users.Count(x => x.Email == user.Email) == 0)   // petaei exception oti den mporei na kanei metatroph to int se string , prepei na allaksw key?
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
        [Authorize]
        public ActionResult SendOrder()
        {
            if (Session["User"] != null)
            {
                User u = (User)Session["User"];

                Basket basket = (Basket)Session["basket"];
                db.Baskets.Add(basket);
                db.SaveChanges();

                Order order = new Order();    
                order.CustomerId = u.Id;
                order.BasketId = basket.Id;
                order.TotalPrice = basket.Price;
                
                db.Orders.Add(order);
                db.SaveChanges();
            }
          
            return View();
        }
        
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(string Email, string Password)
        {
            User u = db.Users.FirstOrDefault((x => x.Email == Email&& x.Password==Password)); //& (x=>x.Password == password));
            if (u == null)
            {
                ViewBag.NotMatching = true;
                return View();
            }
            if (u.IsAdmin==false)
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
                return RedirectToAction("CouponCreation");
            }
            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Logout");
        }
        public ActionResult Cart()
        {
            return View();
        }
        //[Authorize]
        public ActionResult Order(CombinedViewModel model)
        {
            var co = new CombinedViewModel();
            co.Products = db.Products.ToList();
            return View(co);
        }

        

    }
}