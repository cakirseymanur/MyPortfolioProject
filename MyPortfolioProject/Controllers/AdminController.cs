using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var values = db.Tbl_Admin.First();
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin admin)
        {
            var values = db.Tbl_Admin.Find(admin.AdminID);
            values.UserName = admin.UserName;
            values.Password = admin.Password;
            values.Status = admin.Status;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}