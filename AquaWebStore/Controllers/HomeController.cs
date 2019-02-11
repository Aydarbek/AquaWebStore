using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AquaWebStore.Models;

namespace AquaWebStore.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}