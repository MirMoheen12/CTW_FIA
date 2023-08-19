using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class FiearmsController : Controller
    {
        private readonly IFearams fearams;
        private readonly ITerrorist terrorist;
        public FiearmsController(IFearams fearams, ITerrorist terrorist)
        {
            this.fearams = fearams;
            this.terrorist = terrorist;
        }
        public IActionResult allFiearms()
        {
            var data=fearams.allfearms();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddFiearms()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }

        [HttpPost]
        public IActionResult AddFiearms(Firearms c)
        {
            fearams.AddNewFiearms(c);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "Fiearms", pagestatus = "Updated" });
        }
    }
}
