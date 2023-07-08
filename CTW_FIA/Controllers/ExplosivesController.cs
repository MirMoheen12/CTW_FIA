using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class ExplosivesController : Controller
    {
        private readonly IDashboard dashboard;
        public ExplosivesController(IDashboard dashboard)
        {
            this.dashboard = dashboard;
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

    }
}
