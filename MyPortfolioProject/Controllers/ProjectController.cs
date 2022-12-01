using MyPortfolioProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class ProjectController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        // GET: Project
        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(Tbl_Project project, HttpPostedFileBase projectImage)
        {
            if (projectImage!=null)
            {
                string dosyaYolu = Path.GetFileName(projectImage.FileName);
                var yuklemeYeri = Path.Combine(Server.MapPath("~/ProjectImages"), dosyaYolu);
                projectImage.SaveAs(yuklemeYeri);
                project.ProjectImage= dosyaYolu;
            }
            db.Tbl_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateProject(Tbl_Project project, HttpPostedFileBase projectImage)
        {
            var values = db.Tbl_Project.Find(project.MyProjectID);
            if (projectImage != null)
            {
                string dosyaYolu = Path.GetFileName(projectImage.FileName);
                var yuklemeYeri = Path.Combine(Server.MapPath("~/ProjectImages"), dosyaYolu);
                projectImage.SaveAs(yuklemeYeri);
                values.ProjectImage = dosyaYolu;
            }
            values.ProjectLink = project.ProjectLink;
            values.ProjectName = project.ProjectName;
            values.Description = project.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}