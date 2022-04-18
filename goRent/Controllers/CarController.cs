using Microsoft.AspNetCore.Mvc;

namespace goRent.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
