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
        private readonly ICommonlinks commonLinks;

        public ExplosivesController(ICommonlinks commonLinks, IDashboard dashboard,IExplosive explosive, ITerrorist terrorist)
        {
            this.explosive = explosive;
            this.dashboard = dashboard;
            this.terrorist = terrorist;
            this.commonLinks = commonLinks;
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
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }
        //public IActionResult ExplosiveDetails(string STRURN)
        //{
        //    var Linkres = commonLinks.getAlllinksCount(STRURN);
        //    ViewBag.link = Linkres;
        //    ///QuickSearchPerson_sel_Result
        //    var data = explosive.GetGroupsByStrurn(STRURN);
        //    return View(data);
        //}


        [HttpGet]
        public IActionResult EditExplosive(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = explosive.GetExplosiveByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditExplosive(Explosive c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            explosive.PostEditExplosive(c);
            return RedirectToAction("index", "Dashboard");
        }

    }
}
