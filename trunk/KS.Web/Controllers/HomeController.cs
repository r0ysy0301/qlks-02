using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KS.Core.Interface.Service;
using KS.Web.NumberIndex;

namespace KS.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ItintucService tintucservice;
        //private int sotintuchienthingoaitrangchu = AppConfig.Sotintuchienthingoaitrangchu;

        //public HomeController(ItintucService tintucservice)
        //{
        //    this.tintucservice = tintucservice;
        //}
        public ActionResult Index()
        {
           // ViewBag.tintuc = tintucservice.GetNew(sotintuchienthingoaitrangchu);
            return View();
        }

        public ActionResult Aboutfull()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dichvu()
        {
            return View();
        }
        public ActionResult doitac()
        {
            return View();
        }
    }
}
