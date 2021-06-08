using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnblockMe.Models;
using UnblockMe.Models.Entities;

namespace UnblockMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("{id}")]
        public Vehicle GetCar(int id)
        {

            Vehicle temp = new Vehicle
            {
                Id = id,
                Make = "Dacia",
                Model = "Logan",
                RegPlate = "DJ12DJD"
            };

            return temp;
        }

        [HttpDelete("{id}")]
        public Vehicle DeleteCar(int id)
        {
            Vehicle temp = new Vehicle
            {
                Id = id,
                Make = "Dacia",
                Model = "Logan",
                RegPlate = "DJ12DJD"
            };
            
            return temp;
        }

        [HttpPost("{id}")]
        public Vehicle PostCar(Vehicle vehicle)
        {
            return vehicle;
        }

        [HttpPut("{id}")]
        public Vehicle PutCar(int id)
        {
            Vehicle temp = new Vehicle
            {
                Id = id,
                Make = "Dacia",
                Model = "Logan",
                RegPlate = "DJ12DJD"
            };

            return temp;
        }
    }
}
