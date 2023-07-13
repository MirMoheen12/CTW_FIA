using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class incidentsController : Controller
    {

        private readonly IRecord record;
        private readonly IDashboard dashboard;
        private readonly IIncident incident;
        public incidentsController(IDashboard dashboard, IIncident incident, IRecord record)
        {
            this.dashboard = dashboard;
            this.incident = incident;
            this.record = record;
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

        public ActionResult NewIncident()
        {
            var data = record.GetFirstDistrictDataPerCountry();
            ViewBag.country = data;
            return View();
        }
    }
}
