using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OstreaLodge8209.Controllers
{
    public class ContactController : Controller
    {
       public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HowToGetHere()
        {
            ViewBag.Message = "HowToGetHere";

            return View();
        }
        
    }
}