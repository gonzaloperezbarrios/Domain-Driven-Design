using Example.Application.application.services.car;
using Example.Presentation.Web.Models;
using Example.Transversal.domain.entities.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace Example.Presentation.Web.Controllers
{
    public class CarController : Controller
    {
        ICarService carService;
        IMapper mapper;
        public CarController(ICarService carService)
        {
            this.carService = carService;
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CarEntitie, CarViewModel>();
                cfg.CreateMap<CarViewModel, CarEntitie>();
            });
            mapper = config.CreateMapper();
        }

        // GET: Car
        public ActionResult Index()
        {
            var model = carService.GetCars();
            return View(model);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {         
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        public ActionResult Create(CarViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var _car = mapper.Map<CarEntitie>(model);
                    _car.Model = model.ModelCar;
                    carService.Create(_car);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                //Log
            }
            return View(model);
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Car/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Car/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
