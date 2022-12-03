using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyPortfolioProject.Controllers
{
    public class LoginController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin p)
        {
            var values = db.Tbl_Admin.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                var bisey = db.Tbl_Message.Where(x => x.Status == false).Count();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        public ActionResult LogOut()
        {
            Session.Remove("NewMessage");
            return RedirectToAction("Index");
        }
    }
}