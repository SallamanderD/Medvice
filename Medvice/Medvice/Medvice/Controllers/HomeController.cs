using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medvice.Models;

namespace Medvice.Controllers
{
    public class HomeController : Controller
    {
        MedviceContext db = new MedviceContext();
        public ActionResult Index()
        {
            ViewBag.Diseases = db.Diseases.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}