using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listele()
        {
            return View();
        }

        public ActionResult Kaydet()
        {
            return RedirectToAction("Listele");
        }


    }
}