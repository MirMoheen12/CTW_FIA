using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class InitiationSystemController : Controller
    {
        private readonly  IIntianSystem intianSystem;
        private readonly ITerrorist terrorist;
        public InitiationSystemController(IIntianSystem intianSystem, ITerrorist terrorist)
        {
            this.intianSystem = intianSystem;
            this.terrorist = terrorist;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddInitiationSystem()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }
        [HttpPost]
        public IActionResult AddInitianSystem(InitiationSystem ins)
        {
            intianSystem.AddNewInitiation(ins);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }
        public IActionResult AllIntianSystem()
        {
            var data = intianSystem.AllSystem();
            return View(data);
        }

        [HttpGet]
        public IActionResult EditInitiationSystem(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = intianSystem.GetIntianDystmByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditInitiationSystem(InitiationSystem c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            intianSystem.PostEditInitiationSystem(c);
            return RedirectToAction("index", "Dashboard");
        }

    }
}
