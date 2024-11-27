using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hakkımda sayfamıza Hoşgeldin.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim Sayfam.";

            return View();
        }
        public ActionResult Bilgi()
        {
            return View();
        }
    }
}