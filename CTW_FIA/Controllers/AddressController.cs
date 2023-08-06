using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class AddressController : Controller
    {
        private readonly IRecord record;
        private readonly IAddress iaddress;
        private readonly IIncident incident;
        private readonly ICommonlinks commonlinks;
        private readonly ITerrorist terrorist;
        public AddressController(ITerrorist terrorist, IAddress iaddress, IIncident incident, IRecord record, ICommonlinks commonlinks)
        {
            this.iaddress = iaddress;
            this.terrorist = terrorist;
            this.incident = incident;
            this.record = record;
            this.commonlinks = commonlinks;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewAddrees()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Agencies = terrorist.AllAgencies();
            return View();
        }
        [HttpPost]
        public IActionResult NewAddrees(Address address)
        {
            var res = iaddress.AddAddress(address);
            ViewBag.Allcountries = terrorist.AllCountry();
            ViewBag.Agencies = terrorist.AllAgencies();
            return RedirectToAction("AddRecord", "Record", new { pagname = "Address", pagestatus = "Updated" });
        }
    }
}
