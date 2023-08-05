using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class PowerSourceController : Controller
    {
        private readonly IPowerSource powerSource;
        private readonly ICommonlinks commonlinks;
        public PowerSourceController(ICommonlinks commonlinks,IPowerSource p)
        {
            this.powerSource = p;
            this.commonlinks = commonlinks;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllPowerSource()
        {
            var data = powerSource.AllPowerSource();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddPowerSource()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPowerSource(PowerSource ps)
        {
            String Name = @User.Identity.Name;
            if (powerSource.AddPowerSource(ps, Name))
            {
                return RedirectToAction("AllPowerSource", "PowerSource");

            }
            return RedirectToAction("GetSinglePowerSource", "PowerSource", new {id = ps.strURN});

        }

        public IActionResult GetSinglePowerSource(String id)
        {

            return View();
        }

        public IActionResult PowerSourceDetails(string STRURN)
        {
            var Linkres = commonlinks.getAlllinksCount(STRURN);
            ViewBag.link = Linkres;
            ///QuickSearchPerson_sel_Result
            var data = powerSource.GetGroupsByStrurn(STRURN);
            return View(data);
        }
    }
}
