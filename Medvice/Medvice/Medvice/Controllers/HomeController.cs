using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medvice.Models;
using PagedList.Mvc;
using PagedList;

namespace Medvice.Controllers
{
    public class HomeController : Controller
    {
        MedviceContext db = new MedviceContext();
        public ActionResult Index(string searchWord)
        {
            if (searchWord == null || searchWord == "")
            {
                ViewBag.Diseases = db.Diseases.ToList();
                ViewBag.Simpotoms = db.Simpotoms.ToList();
                ViewBag.Medicine = db.Medicines.ToList();
            }
            else
            {
                ViewBag.Diseases = db.Diseases.ToList().Where(x => x.Name.ToLower().Contains(searchWord) || x.Description.ToLower().Contains(searchWord));
                ViewBag.Simpotoms = db.Simpotoms.ToList().Where(x => x.Name.ToLower().Contains(searchWord) || x.ShortDescription.ToLower().Contains(searchWord));
                ViewBag.Medicine = db.Medicines.ToList();
            }
            return View();
        }

        public ActionResult DiseaseView(string Id)
        {
            ViewBag.Disease = db.Diseases.Where(x => x.DiseaseId == Id).First();
            return View();
        }
        public ActionResult SimpotomView(string Id)
        {
            ViewBag.Simpotom = db.Simpotoms.Where(x => x.SimpotomId == Id).First();
            return View();
        }


        public ActionResult Simpotom(int? page)
        {
            int pageSize = 7;
            int pageNumber = (page ?? 1);
            ViewBag.Message = "Your application description page.";
            ViewBag.Simpotoms = db.Simpotoms.ToList();
            return View(db.Simpotoms.ToList().ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Diseases(int? page)
        {
            int pageSize = 7;
            int pageNumber = (page ?? 1);
            
            ViewBag.Diseases = db.Simpotoms.ToList();
            return View(db.Diseases.ToList().ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Medicine()
        {
            return View();
        }


    }
}