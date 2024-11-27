using MVCProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        DbStokEntities1 db = new DbStokEntities1();
        private void EkleDropDown()
        {
            var categoryList = db.TblKategorıler.ToList();
            List<SelectListItem> degerler = (from i in categoryList
                                             select new SelectListItem
                                             {
                                                 Text = i.KategorıAd,
                                                 Value = i.KategorıId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
        }
        public ActionResult Index()
        {
            var values=db.TblUrunler.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            EkleDropDown();
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(TblUrunler urunler)
        {
            if (ModelState.IsValid)
            {
                EkleDropDown();


                db.TblUrunler.Add(urunler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //var values = db.TblKategorıler.Where(i => i.KategorıId == urunler.TblKategorıler.KategorıId).FirstOrDefault();
            //urunler.TblKategorıler = values;
            EkleDropDown();
            return View(urunler);

        }

        public ActionResult DeletUrun(int id)
        {
            var urun = db.TblUrunler.Find(id);
            db.TblUrunler.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateUrun(int id)
        {
            var values = db.TblUrunler.Find(id);
            EkleDropDown();
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateUrun(TblUrunler urunler)
        {

            EkleDropDown();
            var values = db.TblUrunler.Find(urunler.UrunId);
            values.UrunAd = urunler.UrunAd;
            values.Marka = urunler.Marka;
            values.UrunKategorı = urunler.UrunKategorı;
            //var ktg = db.TblKategorıler.Where(m => m.KategorıId == urunler.TblKategorıler.KategorıId).FirstOrDefault();
            //urunler.UrunKategorı = ktg.KategorıId;
            values.Fıyat = urunler.Fıyat;
            values.Stok=urunler.Stok;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}