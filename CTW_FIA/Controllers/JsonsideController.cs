using CTW_FIA.Interface;
using CTW_FIA.Models;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class JsonsideController : Controller
    {
        private readonly IDashboard dashboard;
        private readonly ITerrorist terrorist;
        private readonly AppDbContext dbContext;
        private readonly ConverterModel converterModel;
        private readonly IJson jsn;
        public JsonsideController(ConverterModel converterModel,IDashboard dashboard, ITerrorist terrorist, AppDbContext dbContext, IJson jsn)
        {
            this.dashboard = dashboard;
            this.converterModel = converterModel;
            this.terrorist = terrorist;
            dbContext = dbContext;
            this.jsn = jsn;
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
        [HttpGet]
        public JsonResult GetAllReportingAgency()
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = jsn.GetReportingAgencies();
            return Json(data);
        }
        [HttpGet]
        public JsonResult GetAllDatabaselist()
        {
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = jsn.databaseLists();
            return Json(data);
        }

        [HttpGet]
        public JsonResult GetSingleRec(int ID,string TableName,string Search)
        {
            if (TableName == null)
            {
                return null;
            }
            //var data = dashboard.getCtwdashboardsIncidentwise().Where(X => X.tablename == "PW").ToList(); 
            var data = jsn.GetRecordData(TableName,Search,ID);
        
            var data2 = converterModel.GetModelFromDataTable(data);
            return Json(data2);
        }

    }
}
