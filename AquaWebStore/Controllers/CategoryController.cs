using AquaWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AquaWebStore.Controllers
{
    public class CategoryController : Controller
    {
        Context db = new Context();
        // GET: Collection
        public ActionResult Index()
        {   
            ViewBag.suits = db.Hsuits;
            ViewBag.Categories = db.Categories;
            return View();
        }


        [HttpGet]
        public ActionResult Look(int Id)
        {
            IEnumerable<Hsuit> suits = db.Hsuits.Where(s => s.Category.CategoryId == Id);
            Category cat = db.Categories.First(c => c.CategoryId == Id);

            ViewBag.cat = cat;
            ViewBag.suits = suits;
            return View();
        }







    }
}