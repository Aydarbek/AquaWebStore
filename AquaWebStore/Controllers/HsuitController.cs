using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AquaWebStore.Models;

namespace AquaWebStore.Controllers
{
    public class HsuitController : Controller
    {

        Context db = new Context();



            // GET: Hsuit
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Look(int Id)
        {
                Hsuit hsuit = db.Hsuits.First(h => h.Id == Id);
                IEnumerable<Photo> photos = db.Photos.Where(p => p.hsuit.Id == Id);

                ViewBag.hsuit = hsuit;
                ViewBag.photos = photos;
                return View();
        }

        public ActionResult Buy()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }



    }
}