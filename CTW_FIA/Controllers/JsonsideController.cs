using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class JsonsideController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly ITerrorist terrorist;
        public JsonsideController(IDashboard dashboard, ITerrorist terrorist)
        {
            this.dashboard = dashboard;
            this.terrorist = terrorist;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetLeftsidesCounts()
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = dashboard.getCtwdashboardsLeftnavigation();
            return Json(data);
        }
        [HttpGet]
        public JsonResult GetReportingAgency()
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = terrorist.AllAgencies();
            return Json(data);
        }

    }
}
