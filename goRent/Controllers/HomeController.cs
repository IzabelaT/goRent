﻿using goRent.Class;
using goRent.Models;
using goRent.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace goRent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService rentCarService;

        public HomeController(ICarService rentCarService)
        {
            this.rentCarService = rentCarService;
        }

        public IActionResult Index()
        {
            return View(this.rentCarService.GetCar());
        }

        [HttpGet]
        public IActionResult AddCar()
        {

            return View();
        }

        public IActionResult Cities()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCar(Car car)
        {
            this.rentCarService.AddCar(car);
            return RedirectToAction("Index");
        }

        public IActionResult GetCar(int id)
        {
            var car = this.rentCarService.GetById(id);
            return View(car);
        }

        public IActionResult EditCar(Car carToEdit)
        {
            this.rentCarService.EditCar(carToEdit);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCar(int id)
        {
            this.rentCarService.DeleteCar(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
