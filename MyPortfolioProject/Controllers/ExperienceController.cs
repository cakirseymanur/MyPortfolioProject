using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Experience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(Tbl_Experience experience)
        {
            db.Tbl_Experience.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            var values = db.Tbl_Experience.Find(id);
            db.Tbl_Experience.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var values = db.Tbl_Experience.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Tbl_Experience p)
        {
            var values = db.Tbl_Experience.Find(p.ExperienceID);
            values.WorkplaceName = p.WorkplaceName;
            values.Description = p.Description;
            values.Position = p.Position;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}