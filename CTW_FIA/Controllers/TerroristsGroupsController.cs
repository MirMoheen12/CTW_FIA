using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class TerroristsGroupsController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly ITerrorist terrorist;
        private readonly ICommonlinks commonlinks;
        public TerroristsGroupsController(ICommonlinks commonlinks, IDashboard dashboard,ITerrorist terrorist)
        {
            this.dashboard = dashboard;
            this.terrorist = terrorist;
            this.commonlinks= commonlinks;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public JsonResult Getdashboard()
        {
            var data = dashboard.getCtwdashboardsGraphwise();
            return Json(data);
        }
        public IActionResult AllGroups()
        {
            var data = terrorist.GetAllTerrorist();
            return View(data);
        }
        public IActionResult TerroristGroupsDetails(string STRURN)
        {
            var Linkres = commonlinks.getAlllinksCount(STRURN);
            ViewBag.link = Linkres;
            ///QuickSearchPerson_sel_Result
            var data = terrorist.GetGroupsByStrurn(STRURN);
            return View(data);
        }
        [HttpGet]
        public IActionResult AddTerroristGroup()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Agencies = terrorist.AllAgencies();
            return View(new Group());
        }
        [HttpPost]
        public IActionResult AddTerroristGroup(Group group)
        {
            var res = terrorist.AddNewGroup(group);
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Agencies = terrorist.AllAgencies();
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }
        [HttpGet]
        public IActionResult EditTerroristGroup(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = terrorist.GetGroupsByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditTerroristGroup(Group c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            terrorist.PostEditGroup(c);
            return RedirectToAction("index", "Dashboard");
        }
    }
}
