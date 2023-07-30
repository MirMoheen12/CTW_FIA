using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class VehicleController : Controller
    {
        private readonly IVehicle vehicle;
        public VehicleController(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllVehicle()
        {
            var data = vehicle.AllVehicle();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddNewVehicle()
        {
         
            return View(new Vehicle());
        }
        [HttpPost]
        public IActionResult AddNewVehicle(Vehicle veh)
        {
            var res=vehicle.AddNewVehicle(veh);
            return View(new Vehicle());
        }
    }
}
