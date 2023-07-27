using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
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
            var data = terrorist.GetPeronByID(STRURN);
            return View(data);
        }


    }
}
