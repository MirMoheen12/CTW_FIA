using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
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
        private readonly ICommonlinks commonlinks;
        private readonly ITerrorist terrorist;
        public incidentsController(ITerrorist terrorist, IDashboard dashboard, IIncident incident, IRecord record, ICommonlinks commonlinks)
        {
            this.dashboard = dashboard;
            this.terrorist=terrorist;
            this.incident = incident;
            this.record = record;
            this.commonlinks = commonlinks;
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
            var Linkres=commonlinks.getAlllinksCount(strurn);
            ViewBag.link = Linkres;
            var data = (PreviewIncidentByStrUrn)(incident.getIncidentID(strurn));
            return View(data);
        }
        [HttpGet]
        public ActionResult NewIncident()
        {

            //ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Agencies = terrorist.AllAgencies();
            return View();
        }
        [HttpPost]
        public ActionResult NewIncident(Incident inc)
        {
            incident.AddNewIncident(inc);
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Agencies = terrorist.AllAgencies();
            return RedirectToAction("AddRecord", "Record", new { pagname="Incidents", pagestatus="Updated" });
        }




        [HttpGet]
        public IActionResult EditIncident(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = incident.GetEditIncident(StrURN);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditIncident(Incident i)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            incident.PostEditIncident(i);
            return RedirectToAction("index", "Dashboard");
        }
    }
}
