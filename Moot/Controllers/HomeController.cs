using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moot.Controllers
{
    public class HomeController : Controller
    {
        private ITootZootService _tootZootService;
        public HomeController(ITootZootService tootZootService)
        {
            _tootZootService = tootZootService;
        }
        public ActionResult Index()
        {
            _tootZootService.GetZootByTootId(1);
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