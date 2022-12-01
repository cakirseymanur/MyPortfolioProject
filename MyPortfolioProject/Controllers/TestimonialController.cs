using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Tbl_Testimonial p)
        {
            db.Tbl_Testimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Tbl_Testimonial p)
        {
            var values = db.Tbl_Testimonial.Find(p.TestimonialID);
            values.NameSurname = p.NameSurname;
            values.Profession = p.Profession;
            values.Status = p.Status;
            values.Workplace = p.Workplace;
            values.Email = p.Email;
            values.Description = p.Description;
            values.City = p.City;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}