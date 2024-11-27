using MVCProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace MVCProje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DbStokEntities1 db = new DbStokEntities1();


        public ActionResult Index(int sayfa=1)
        {
            //var value = db.TblKategorıler.ToList();
            var value = db.TblKategorıler.ToList().ToPagedList(sayfa, 4);
            return View(value);
        }

        [HttpGet]
        public ActionResult KategorıEkle()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult KategorıEkle(TblKategorıler category)
        {
            if (ModelState.IsValid)
            {
                db.TblKategorıler.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           return View("KategorıEkle");
        }

        public ActionResult DeleteKategorı(int id)
        {
            var values = db.TblKategorıler.Find(id);
            db.TblKategorıler.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var values = db.TblKategorıler.Find(id);
            db.TblKategorıler.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KategorıUpdate(int id)
        {
            var values = db.TblKategorıler.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult KategorıUpdate(TblKategorıler kategorıler)
        {
            var values = db.TblKategorıler.Find(kategorıler.KategorıId);
            values.KategorıAd = kategorıler.KategorıAd;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}