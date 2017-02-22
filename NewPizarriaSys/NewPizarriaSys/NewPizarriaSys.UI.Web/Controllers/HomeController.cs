using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewPizarriaSys.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Somos especializados em Pizzas desde 2017.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contate-nos para sua festa ou para domicílio.";

            return View();
        }
    }
}