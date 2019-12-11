using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryYApp.Models.Entity;

namespace LibraryYApp.Controllers
{
    public class DefaultController : Controller
    {
        KitaplikEntities db = new KitaplikEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeEkle(TBL p1)
        {
            db.TBLs.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}