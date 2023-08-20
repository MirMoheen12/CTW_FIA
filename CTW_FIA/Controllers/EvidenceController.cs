using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using Evidence = CTW_FIA.Models.DatabaseModels.Evidence;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class EvidenceController : Controller
    {
        private readonly IEvidence evidence;
        private readonly ITerrorist terrorist;
        public EvidenceController(IEvidence evidence, ITerrorist terrorist)
        {
            this.evidence = evidence;
            this.terrorist = terrorist;
        }
        public IActionResult AllEvidence()
        {
           var dat = evidence.AllEvidence();
            return View();
        }
        [HttpGet]
        public IActionResult AddEvidence()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }


        [HttpPost]
        public IActionResult AddEvidence(Evidence evd)
        {

            evidence.AddNewEvidence(evd);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "P", pagestatus = "Updated" });
        }


        [HttpGet]
        public IActionResult EditEvidence(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = evidence.GetEvidenceByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditEvidence(Evidence c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            evidence.PostEditEvidence(c);
            return RedirectToAction("index", "Dashboard");
        }
    }
}
