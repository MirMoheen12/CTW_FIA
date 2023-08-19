using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class CBRNController : Controller
    {
        private readonly ICBRN cBRN;
        private readonly ITerrorist terrorist;
        public CBRNController(ICBRN cBRN, ITerrorist terrorist)
        {
            this.cBRN = cBRN;
            this.terrorist = terrorist;
        }
        public IActionResult AllCbrn()
        {
            var data = cBRN.Allcbrn();
            return View(data);
        }

        [HttpGet]
         public IActionResult AddCBRN()
        {           
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }

        [HttpPost]
        public IActionResult AddCBRN(CBRN c)
        {
           cBRN.AddNewComponent(c);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "CBRN", pagestatus = "Updated" });
        }

        [HttpGet]
        public IActionResult EditCBRN(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = cBRN.getCBRNByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditCBRN(CBRN c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            cBRN.PostEditCBRN(c);
            return RedirectToAction("index", "Dashboard");
        }
    }
}
