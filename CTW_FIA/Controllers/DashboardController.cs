using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    
    public class DashboardController : Controller
    {
        private readonly IDashboard dashboard;
        public DashboardController(IDashboard dashboard)
        {
            this.dashboard = dashboard;
        }
        // [Authorize(Policy = "SupervisorPolicy")]
        //[Authorize]
        public IActionResult Index()
        {
            //var data = dashboard.getCtwdashboard();
            string userRole = HttpContext.Session.GetString("UserRole");
            ViewBag.UserRole = userRole;
            return View();
        }
        public JsonResult Getdashboard()
        {
            var data = dashboard.getCtwdashboard();
            return Json(data);
        }



    }
}
