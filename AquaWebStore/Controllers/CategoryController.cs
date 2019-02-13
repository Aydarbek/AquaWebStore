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
            IEnumerable<Hsuit> hsuits = db.Hsuits;
            IEnumerable<Category> categories = db.Categories;

            Photo photo = db.Photos.First(f => f.hsuit.Id == 1);


            ViewBag.Hsuits = hsuits;
            ViewBag.Photos = photo;
            ViewBag.Categories = categories;



            return View();
        }
    }
}