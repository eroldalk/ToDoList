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
            TodolistEntitiesConnectionstring db = new TodolistEntitiesConnectionstring();
            ViewBag.liste = db.lists;
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(list a)
        {
            TodolistEntitiesConnectionstring db = new TodolistEntitiesConnectionstring();
            db.lists.Add(a);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }


    }
}