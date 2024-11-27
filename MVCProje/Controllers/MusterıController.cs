using MVCProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class MusterıController : Controller
    {

        DbStokEntities1 db = new DbStokEntities1();
        // GET: Musterı
        public ActionResult Index(string p)
        {
            var degerler = from d in db.TblMusterıler select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.MusterıAd.Contains(p));
            }
            return View(degerler.ToList());
            //var values = db.TblMusterıler.ToList();
            //return View(values);
        }

        [HttpGet]
        public ActionResult MusterıEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MusterıEkle(TblMusterıler musterıler)
        {
            var values = db.TblMusterıler.Add(musterıler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteMusterı(int id)
        {
            var musterı = db.TblMusterıler.Find(id);
            db.TblMusterıler.Remove(musterı);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult MusterıUpdate(int id)
        {
            var mus = db.TblMusterıler.Find(id);

            return View(mus);
        }

        [HttpPost]
        public ActionResult MusterıUpdate(TblMusterıler musterıler)
        {
            var musterı = db.TblMusterıler.Find(musterıler.MusterıId);
            musterı.MusterıAd = musterıler.MusterıAd;
            musterı.MusterıSoyad = musterıler.MusterıSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}