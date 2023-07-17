using CTW_FIA.Interface;
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
    }
}
