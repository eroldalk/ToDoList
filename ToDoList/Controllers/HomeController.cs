using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listele()
        {
            //arama motoru

            TodolistEntitiesConnectionstring db = new TodolistEntitiesConnectionstring();
            ViewBag.liste = db.lists;
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(list a,String Title,string Description)
        {
            TodolistEntitiesConnectionstring db = new TodolistEntitiesConnectionstring();
            db.lists.Add(a);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpPost]
        public ActionResult Duzenle(list d)
        {
            TodolistEntitiesConnectionstring db = new TodolistEntitiesConnectionstring();
            list KL = db.lists.FirstOrDefault(x => x.id == d.id);
            KL.Title = d.Title;
            KL.Description = d.Description;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

        public ActionResult Sil(int id)
        {
            TodolistEntitiesConnectionstring db = new TodolistEntitiesConnectionstring();
            list silinecek = db.lists.FirstOrDefault(x => x.id == id);
            db.lists.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }



    }
}