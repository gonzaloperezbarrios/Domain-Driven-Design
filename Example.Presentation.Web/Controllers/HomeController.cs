using Example.Application.application.services.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        ICarService carService;

        public HomeController(ICarService carService)
        {
            this.carService = carService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Carro con, "+carService.Turbo();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}