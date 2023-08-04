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
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person P,IFormFile file)
        {
            var res = terrorist.AddNewPerson(P,file);
            ViewBag.Agencies = terrorist.AllAgencies();
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }
        public IActionResult PersonDetails(string STRURN)
        {
            var data=terrorist.GetPeronByID(STRURN);
            return RedirectToAction("RecordDetails", "Record", new { STRUN=STRURN, modelname= "Person" });
        }
      
    }
}
