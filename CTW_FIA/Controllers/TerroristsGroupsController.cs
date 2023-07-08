using CTW_FIA.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class TerroristsGroupsController : Controller
    {
        private readonly IDashboard dashboard;
        public TerroristsGroupsController(IDashboard dashboard)
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
