using Ebakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebakery.Controllers
{
    public class NewsLetterController : Controller
    {
        private MyContext db = new MyContext();


        public ActionResult RegisterToNewsLetter()
        {

            return View();
        }

        public ActionResult AlreadyRegToNewsLetter()
        {

            return View();
        }
        [HttpPost]
        public ActionResult RegisterNewsletter(string email)
        {
   
               NewsletterTrue e = new NewsletterTrue() { Email = email };

            if (db.NewsletterTrues.Count(x=>x.Email==e.Email)==1)
            {
                return RedirectToAction("AlreadyRegToNewsletter");
            }
            else
            db.NewsletterTrues.Add(e);  //edw prepei na to kanw cast mesa sto email se string h na to allaksw sto input?
            db.SaveChanges();
            return RedirectToAction("RegisterToNewsletter");
        }



    }
}