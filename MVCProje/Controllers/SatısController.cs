using MVCProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCProje.Controllers
{
    public class SatısController : Controller
    {
        // GET: Satıs
        DbStokEntities1 db=new DbStokEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Satıs() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Satıs(TblSatıs satıs)
        {
            db.TblSatıs.Add(satıs);
            db.SaveChanges();

            return View("Index");
        }
    }
}