using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KS.Core.Interface.Service;

namespace KS.Web.Controllers
{
    public class HomeController : Controller

    {
        private readonly IPHONGService PHONGService;
        public HomeController(IPHONGService PHONGService)
        {
            this.PHONGService = PHONGService;
        }

        public ActionResult Index()
        {
            return View(PHONGService.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
