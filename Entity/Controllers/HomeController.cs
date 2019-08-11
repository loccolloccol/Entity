using Entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var entity = new NorthwindEntities();
            var select = entity.Customers
                                    
                                    .ToList();
            
            return View(select);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}