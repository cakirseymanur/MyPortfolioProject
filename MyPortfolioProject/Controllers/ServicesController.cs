using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(Tbl_Services tbl_Services)
        {
            db.Tbl_Services.Add(tbl_Services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var values = db.Tbl_Services.Find(id);
            db.Tbl_Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var values = db.Tbl_Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateService(Tbl_Services p)
        {
            var values = db.Tbl_Services.Find(p.ServicesID);
            values.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}