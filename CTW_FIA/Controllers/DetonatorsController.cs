using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class DetonatorsController : Controller
    {
        private readonly IDetonators detonators;
        private readonly ITerrorist terrorist;
        public DetonatorsController(IDetonators detonators,ITerrorist terrorist)
        {
            this.detonators = detonators;
            this.terrorist = terrorist;
        }
        public IActionResult Index()
        {
            var dta = detonators.alldetonators();
            return View(dta);
        }
        [HttpGet]
        public IActionResult AddDetonators()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View(new Detonator());
        }
        [HttpPost]
        public IActionResult AddDetonators(Detonator D)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var res = detonators.AddDetonators(D);
            return View(new Detonator());
        }
    }
}
