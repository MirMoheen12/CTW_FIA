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

        public ExplosivesController(IDashboard dashboard,IExplosive explosive)
        {
            this.explosive = explosive;
            this.dashboard = dashboard;
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
            return View(new Explosive());
        }
        [HttpPost]
        public IActionResult AddExplosive(Explosive E)
        {
            explosive.AddExplosive(E);
            return View(new Explosive());
        }

    }
}
