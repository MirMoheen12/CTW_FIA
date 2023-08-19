using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class OrdinanceController : Controller
    {
        private readonly IOrdinance ordinance;
        private readonly ITerrorist terrorist;
        public OrdinanceController(IOrdinance ordinance, ITerrorist terrorist)
        {
            this.ordinance = ordinance;
            this.terrorist = terrorist;
        }
        public IActionResult AllOrdinance()
        {
            var dat=ordinance.AllOrdinance();
            return View(dat);
        }
        [HttpGet]
        public IActionResult AddOrdinance()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }

        [HttpPost]
        public IActionResult AddOrdinance(Ordnance ord)
        {

           ordinance.AddNewOrdinance(ord);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }

        [HttpGet]
        public IActionResult EditOrdinance(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = ordinance.OrdinanceDetails(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditOrdinance(Ordnance c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            ordinance.PostEditOrdance(c);
            return RedirectToAction("index", "Dashboard");
        }

    }
}
