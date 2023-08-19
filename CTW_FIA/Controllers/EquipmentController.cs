using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class EquipmentController : Controller
    {
        private readonly IEquipments equipments;
        private readonly ITerrorist terrorist;
        public EquipmentController(IEquipments equipments, ITerrorist terrorist)
        {
            this.equipments = equipments;
            this.terrorist = terrorist;
        }
        public IActionResult AllEquipments()
        {
            var data = equipments.AllEquipments();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddEquipment()
        {

            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }
        [HttpPost]
        public IActionResult AddEquipment(Equipment equ)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "Equipments", pagestatus = "Updated" });

        }
        [HttpGet]
        public IActionResult EditEquipment(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = equipments.GetEquByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditEquipment(Equipment c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            equipments.PostEditEquipment(c);
            return RedirectToAction("index", "Dashboard");
        }

    }
}
