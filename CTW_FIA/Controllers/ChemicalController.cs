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
        private readonly ITerrorist terrorist;
        public ChemicalController(Ichemical chemical, ITerrorist terrorist)
        {
            this.chemical = chemical;
            this.terrorist = terrorist;
        }
        public IActionResult Allcheimcal()
        {
            var data = chemical.allChemical();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddCheimcal(Chemical chemical)
        {
            String Name = @User.Identity.Name;

            return RedirectToAction("AddRecord", "Record", new { pagname = "Chemical", pagestatus = "Updated" });

        }

        public IActionResult GetSingleCheimcal(String id)
        {

            return View();
        }


        [HttpGet]
        public IActionResult EditChemical(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = chemical.ChemicalByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditChemical(Chemical c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            chemical.PostEditChemical(c);
            return RedirectToAction("index", "Dashboard");
        }
    }
}
