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
        private readonly ICommonlinks commonlinks;
        public VehicleController(ICommonlinks commonlinks,IVehicle vehicle)
        {
            this.vehicle = vehicle;
            this.commonlinks = commonlinks;
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
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }

        //public IActionResult VehicleDetails(string STRURN)
        //{
        //    var Linkres = commonlinks.getAlllinksCount(STRURN);
        //    ViewBag.link = Linkres;
        //    ///QuickSearchPerson_sel_Result
        //    var data = vehicle.GetGroupsByStrurn(STRURN);
        //    return View(data);
        //}
    }
}
