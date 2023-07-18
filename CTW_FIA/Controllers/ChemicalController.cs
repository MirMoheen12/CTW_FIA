using CTW_FIA.Interface;
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
    }
}
