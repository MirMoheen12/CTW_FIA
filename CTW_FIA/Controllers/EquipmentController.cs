using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class EquipmentController : Controller
    {
        private readonly IEquipments equipments;
        public EquipmentController(IEquipments equipments)
        {
            this.equipments=equipments;
        }
        public IActionResult AllEquipments()
        {
            var data=equipments.AllEquipments();
            return View(data);
        }
    }
}
