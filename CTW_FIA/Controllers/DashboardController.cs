using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        private readonly IDashboard dashboard;
        public DashboardController(IDashboard dashboard)
        {
            this.dashboard = dashboard;
        }
        public IActionResult Index()
        {
            //var data = dashboard.getCtwdashboard();
            return View();
        }
        public JsonResult Getdashboard()
        {
            var data = dashboard.getCtwdashboard();
            return Json(data);
        }



    }
}
