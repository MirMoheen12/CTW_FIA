using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class JsonsideController : Controller
    {
        private readonly IDashboard dashboard;
        public JsonsideController(IDashboard dashboard)
        {
            this.dashboard = dashboard;
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
    }
}
