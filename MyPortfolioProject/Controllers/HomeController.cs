using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        #region Partials
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = db.Tbl_Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult ExperiencePartial()
        {
            var values = db.Tbl_Experience.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult RightMenuPartial()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PageEndPartial()
        {
            return PartialView();
        }
        #endregion
        public ActionResult ContactIndex()
        {
            return View();
        }
        public ActionResult PortfolioIndex()
        {
            return View();
        }
    }
}