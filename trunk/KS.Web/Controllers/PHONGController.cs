using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KS.Core.Interface.Service;
using KS.Web.NumberIndex;
using KS.Web.Filters;

namespace KS.Web.Controllers
{

    public class PhongController : Controller
    {

        private readonly IPHONGService phongservice;
        private int sophonghienthingoaitrangchu = AppConfig.Sophonghienthingoaitrangchu;

        public PhongController(IPHONGService phongservice)
        {
            this.phongservice = phongservice;
        }
        public ActionResult Index()
        {
            ViewBag.phongthuong = phongservice.GetThuong(sophonghienthingoaitrangchu);
            //ViewBag.phongvip = phongservice.GetVip(sophonghienthingoaitrangchu);
            //ViewBag.phongdon = phongservice.GetDon(sophonghienthingoaitrangchu);
            //ViewBag.phongdoi = phongservice.GetDoi(sophonghienthingoaitrangchu);
            return View();
        }
        public ActionResult chitiet()
        {
            return View();
        }

    }
}
