using challenge_mvc_asp.Interfaces;
using challenge_mvc_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace challenge_mvc_asp.Controllers
{
    public class HomeController : Controller, IHomeController 
    {
        //BEGIN_CHALLENGE
        public ActionResult Index()
        {
            return View("HelloWorld");
        }

        public ActionResult Page(int id)
        {
            if (id <= 0)
                return RedirectToAction("Index");
            return View(new PageViewModel { Id = id });
        }

        public ActionResult Deal()
        {
            return View();
        }
        //END_CHALLENGE
    }
}