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

        // GET: Hsuit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Look()
        {
            Hsuit suit = new Hsuit();
            return View(suit);
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