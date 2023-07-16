using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class TerroristsGroupsController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly ITerrorist terrorist;
        public TerroristsGroupsController(IDashboard dashboard,ITerrorist terrorist)
        {
            this.dashboard = dashboard;
            this.terrorist = terrorist;
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


    }
}
