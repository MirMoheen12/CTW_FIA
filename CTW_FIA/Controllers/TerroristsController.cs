using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class TerroristsController : Controller
    {

        private readonly IDashboard dashboard;
        private readonly ITerrorist terrorist;
        public TerroristsController(IDashboard dashboard, ITerrorist terrorist)
        {
            this.dashboard = dashboard;
            this.terrorist = terrorist;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult PersonprovinseWise(string Province)
        {
            var data = terrorist.GetPeronProvincewise(Province);
            return View(data);
        }
        public JsonResult Getdashboard()
        {
            var data = dashboard.getCtwdashboardsterroristtwise();
            return Json(data);
        }
    }
}
