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
<<<<<<< HEAD
        private readonly ITerrorist terrorist;
        public EquipmentController(IEquipments equipments, ITerrorist terrorist)
        {
            this.equipments = equipments;
            this.terrorist = terrorist;
=======
        private readonly ICommonlinks commonlinks;
        public EquipmentController(ICommonlinks commonlinks,IEquipments equipments)
        {
            this.equipments=equipments;
            this.commonlinks=commonlinks;
>>>>>>> f66bd917d9a356d8879bbc292b20663fb6d79883
        }
        public IActionResult AllEquipments()
        {
            var data=equipments.AllEquipments();
            return View(data);
        }
<<<<<<< HEAD
        [HttpGet]
        public IActionResult AddEquipment()
        {

            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }
        [HttpPost]
        public IActionResult AddEquipment(Equipment equ)
        {
            equipments.AddNewEquipment(equ);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("Record", "AddRecord");
         
=======

        public IActionResult EquipmentDetails(string STRURN)
        {
            var Linkres = commonlinks.getAlllinksCount(STRURN);
            ViewBag.link = Linkres;
            ///QuickSearchPerson_sel_Result
            var data = equipments.GetGroupsByStrurn(STRURN);
            return View(data);
>>>>>>> f66bd917d9a356d8879bbc292b20663fb6d79883
        }
    }
}
