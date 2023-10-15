using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class PersonController : Controller
    {   private readonly ICommonlinks _commonLinks;  
        private readonly ITerrorist terrorist;
        public PersonController(ICommonlinks _commonLinks,ITerrorist terrorist)
        {
            this.terrorist=terrorist;
            this._commonLinks = _commonLinks;
        }
        public IActionResult AddPerson()
        {
            ViewBag.Agencies = terrorist.AllAgencies();
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.AccusationList=terrorist.Accusationlist();
            return View();
        }
        [HttpGet]
        public IActionResult EditPerson(string StrURN)
        {
            ViewBag.Agencies = terrorist.AllAgencies();
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = terrorist.EditPerson(StrURN);
            return View(data);
        }
        [HttpPost]
        public IActionResult AddPerson(Person P,IFormFile file)
        {
            if (P.Country != "Pakistan")
            {
                // Set Province and District to default values when not mandatory
                P.Province = "Unknown";   // You can change this to an appropriate default value
                P.District = "Unknown";   // You can change this to an appropriate default value
            }
            var res = terrorist.AddNewPerson(P,file);
            ViewBag.Agencies = terrorist.AllAgencies();
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }
        public IActionResult PersonDetails(string STRURN)
        {
            var data=terrorist.GetPeronByID(STRURN);
            return RedirectToAction("RecordDetails", "Record", new { STRUN=STRURN, modelname= "Person" });
        }
      
    }
}
