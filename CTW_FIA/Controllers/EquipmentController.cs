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
        private readonly ICommonlinks commonlinks;
        public EquipmentController(ICommonlinks commonlinks,IEquipments equipments)
        {
            this.equipments=equipments;
            this.commonlinks=commonlinks;
        }
        public IActionResult AllEquipments()
        {
            var data=equipments.AllEquipments();
            return View(data);
        }

        public IActionResult EquipmentDetails(string STRURN)
        {
            var Linkres = commonlinks.getAlllinksCount(STRURN);
            ViewBag.link = Linkres;
            ///QuickSearchPerson_sel_Result
            var data = equipments.GetGroupsByStrurn(STRURN);
            return View(data);
        }
    }
}
