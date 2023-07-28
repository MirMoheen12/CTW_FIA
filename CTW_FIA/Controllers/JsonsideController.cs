using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class JsonsideController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly ITerrorist terrorist;
        private readonly AppDbContext dbContext;
        public JsonsideController(IDashboard dashboard, ITerrorist terrorist, AppDbContext dbContext)
        {
            this.dashboard = dashboard;
            this.terrorist = terrorist;
            dbContext =dbContext;
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
        [HttpGet]
        public JsonResult GetAllCountries()
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = terrorist.AllCountry();
            return Json(data);
        }
        [HttpGet]
        public JsonResult GetDistrictByProvince(string Province)
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = terrorist.GetAllDistrictByProvince(Province);
            return Json(data);
        }
        [HttpGet]
        public JsonResult GetAllProvince(string country)
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = terrorist.GetALlprovinceCountryWise(country);
            return Json(data);
        }
        [HttpGet]
        public JsonResult GetAllPoliceStation()
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = terrorist.AllPliceStation();
            return Json(data);
        }

    }
}
