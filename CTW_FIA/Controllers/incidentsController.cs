using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class incidentsController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly IIncident incident;
        public incidentsController(IDashboard dashboard, IIncident incident)
        {
            this.dashboard = dashboard;
            this.incident = incident;
        }
        public IActionResult Index()
        {

            return View();
        }
        public JsonResult Getdashboard()
        {
            var data = dashboard.getCtwdashboardsIncidentwise();
            return Json(data);
        }
        public IActionResult IncidentProvincewise(string Provinsewise)
        {
            var data = incident.getIncidentProvincewiese(Provinsewise);
            return View(data);
        }
        public IActionResult IncidentDetails(string strurn)
        {
            var data = (PreviewIncidentByStrUrn)(incident.getIncidentID(strurn));
            return View(data);
        }
    }
}
