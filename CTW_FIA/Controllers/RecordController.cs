using CTW_FIA.Interface;
using CTW_FIA.Models;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class RecordController : Controller
    {
        private readonly IRecord record;
        public RecordController(IRecord record) { 
        
            this.record = record;
        }
        public IActionResult AddRecord()
        {
            return View();
        }

        public ActionResult NewIncident()
        {
            var data = record.GetFirstDistrictDataPerCountry();
            ViewBag.country = data;
            return View();
        }
        public IActionResult PersonInvolved(string pid = "")
        {
            var data = record.GetFirstDistrictDataPerCountry();
            ViewBag.country = data;
            return View();
        }
        public ActionResult Groups()
        {
            var data = record.GetFirstDistrictDataPerCountry();
            ViewBag.country = data;
            return View(new Group());
        }

        public ActionResult Add_Person_Address()
        {
            return View(new Address());
        }

        public ActionResult Vehicles()
        {
            Vehicle v = new Vehicle();
            return View(v);
        }

        public ActionResult Communications()
        {
            return View(new Communications());
        }

        public IActionResult Detonators()
        {
            return View(new Detonator());
        }
        public IActionResult Explosives()
        {
            return View();
        }

        public ActionResult Ordinance()
        {
            var data = record.GetFirstDistrictDataPerCountry();
            ViewBag.country = data;
            return View();
        }

        public IActionResult Evidence()
        {
            return View(new Evidence());
        }
        public IActionResult Equipment()
        {
            return View(new Equipment());
        }

        public ActionResult InitiationSystem()
        {
            return View(new InitiationSystem());
        }

        public ActionResult Components()
        {
            return View(new Components());
        }

        public IActionResult CBRN()
        {
            return View(new CBRN());
        }
        public IActionResult Property()
        {
            return View(new Property());
        }
        public IActionResult BankAccount()
        {
            return View(new BankAccount());
        }
        public IActionResult Firearms()
        {
            return View();
        }

        public ActionResult Chemical()
        {
            return View(new Chemical());
        }

        public ActionResult PowerSource()
        {
            var data = record.GetFirstDistrictDataPerCountry();
            ViewBag.country = data;
            return View(new PowerSource());
        }
    }

}

