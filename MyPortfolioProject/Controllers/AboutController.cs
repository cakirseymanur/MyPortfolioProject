using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        // GET: About
        [HttpGet]
        public ActionResult Index()
        {
            var values = db.Tbl_About.First();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Tbl_About about)
        {
            var values = db.Tbl_About.Find(about.AboutID);
            values.Address = about.Address;
            values.Description = about.Description;
            values.Email = about.Email;
            values.NameSurname = about.NameSurname;
            values.Tel = about.Tel;
            values.Title = about.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}