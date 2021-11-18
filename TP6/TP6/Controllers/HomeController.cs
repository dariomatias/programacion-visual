using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP6.Models;

namespace TP6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Historia()
        {
            return View();
        }
        
        public ActionResult Galeria()
        {
            return View();
        }
    }
}