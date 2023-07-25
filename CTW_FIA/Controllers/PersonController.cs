using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class PersonController : Controller
    {
        private readonly ITerrorist terrorist;
        public PersonController(ITerrorist terrorist)
        {
            this.terrorist=terrorist;
        }
        public IActionResult AddPerson()
        {
            ViewBag.Agencies = terrorist.AllAgencies();
            return View();
        }
        public IActionResult PersonDetails(string STRURN)
        {
            ///QuickSearchPerson_sel_Result
            var data=terrorist.GetPeronByID(STRURN);
            return View(data);
        }
    }
}
