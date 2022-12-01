using MyPortfolioProject.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
    

        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Inbox()
        {
           
            var values = db.Tbl_Message.OrderByDescending(i=>i.MessageDate).ToList();
            return View(values);
        }

       
        [HttpPost]
        public JsonResult SendMesseage(Tbl_Message p)
        {
           
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.RecieverMail = db.Tbl_About.Select(s=>s.Email).FirstOrDefault();
            p.RecieverNameSurname = db.Tbl_About.Select(s => s.NameSurname).FirstOrDefault();
            p.Status = false;
            db.Tbl_Message.Add(p);
            db.SaveChanges();
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public ActionResult MesseageDetails(int id)
        {
            var mesajDetay = db.Tbl_Message.Where(x => x.MessageID == id).FirstOrDefault();
            mesajDetay.Status = true;
            db.SaveChanges();
            ViewBag.mesaj = mesajDetay;
            return View();
        }
        public ActionResult DeleteMesseage(int id)
        {
            var values = db.Tbl_Message.Find(id);
            db.Tbl_Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}