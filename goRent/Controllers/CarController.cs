using goRent.Class;
using goRent.Service;
using Microsoft.AspNetCore.Mvc;

namespace goRent.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService rentCarService;

        public CarController(ICarService rentCarService)
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
    }
}
