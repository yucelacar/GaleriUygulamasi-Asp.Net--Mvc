using GaleriUygulamasi.Extension;
using GaleriUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GaleriUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        GaleriContext _db;
        public HomeController()
        {
            _db = new GaleriContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult Galeri()
        {
            return View(_db.Dosyalar.ToList());
        }

        public ActionResult UploadData()
        {
            HttpPostedFileBase file = HttpContext.Request.Files[0];
            //disposable
            using (BinaryReader reader = new BinaryReader(file.InputStream))
            {
                byte[] deger = reader.ReadBytes(file.ContentLength);

                if (Session["Alafortanfoni"] == null)
                {
                    Session["Alafortanfoni"] = deger;
                }
                else
                {
                    Session["Alafortanfoni"] = UtilityManager.ByteBirlestir((byte[])Session["Alafortanfoni"], deger);
                }
                if(file.ContentLength<10000)
                {
                    _db.Dosyalar.Add(new Dosya
                    {
                        Deger = (byte[])Session["Alafortanfoni"],
                        DosyaAdi = file.FileName,
                        DosyaBoyutu = ((byte[])Session["Alafortanfoni"]).Length,
                        DosyaTipi = file.ContentType,
                        IkonBootstrap = UtilityManager.setIcon(file.ContentType),
                        IkonResim=UtilityManager.setImage(file.ContentType),
                        KayitTarihi = DateTime.Now,
                    });
                    _db.SaveChanges();
                    
                    Session.Remove("Alafortanfoni");
                }



            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        
        [HttpPost]
        public ActionResult GetDosyaByID(int ID)
        {
            var dosya = _db.Dosyalar.Find(ID);
            return Json(dosya);
        }


        [HttpPost]
        public ActionResult DegisiklikKaydet(int ID,string Aciklama,string Baslik)
        {
            Dosya dosya = _db.Dosyalar.Find(ID);
            dosya.Aciklama = Aciklama;
            dosya.Baslik = Baslik;
            _db.SaveChanges();
            return Json("");
        }
    }
}