using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class ChemicalController : Controller
    {
        private readonly Ichemical chemical;
        public ChemicalController(Ichemical chemical)
        {
            this.chemical = chemical;
        }
        public IActionResult Allcheimcal()
        {
            var data = chemical.allChemical();
            return View(data);
        }


        public IActionResult AddCheimcal(PowerSource ps)
        {
            String Name = @User.Identity.Name;
           
            return RedirectToAction("GetSinglePowerSource", "PowerSource", new { id = ps.StrURN });

        }

        public IActionResult GetSingleCheimcal(String id)
        {

            return View();
        }
    }
}
