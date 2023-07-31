using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class ExplosivesController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly IExplosive explosive;
        private readonly ITerrorist terrorist;

        public ExplosivesController(IDashboard dashboard,IExplosive explosive, ITerrorist terrorist)
        {
            this.explosive = explosive;
            this.dashboard = dashboard;
            this.terrorist = terrorist;
        }
        public IActionResult Index()
        {

            return View();
        }
        public JsonResult Getdashboard()
        {
            var data = dashboard.getCtwdashboardsExplosivetwise();
            var dt = data.ToList().Count();
            return Json(data);
        }
        public IActionResult AllExplosive()
        {
            var data = explosive.AllExplosive();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddExplosive()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View(new Explosive());
        }
        [HttpPost]
        public IActionResult AddExplosive(Explosive E)
        {
            explosive.AddExplosive(E);
            ViewBag.Allcountries = terrorist.AllCountry();
            return View(new Explosive());
        }

    }
}
