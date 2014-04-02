using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KS.Core.Model;
using KS.Core.Interface.Service;


namespace KS.Web.Controllers
{
    public class PHONGController : Controller
    {
        //
        // GET: /PHONG/
        private readonly IPHONGService phongservice;
        public PHONGController(IPHONGService phongservice)
        {
            this.phongservice = phongservice;
        }

        public ActionResult Index()
        {
            return View(phongservice.GetAll());
        }

    }
}
