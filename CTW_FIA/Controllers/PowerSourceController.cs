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
        public PowerSourceController(IPowerSource p)
        {
            this.powerSource = p;
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

        public IActionResult AddPowerSource(PowerSource ps)
        {
            String Name = @User.Identity.Name;
            if (powerSource.AddPowerSource(ps, Name))
            {
                return RedirectToAction("AllPowerSource", "PowerSource");

            }
            return RedirectToAction("GetSinglePowerSource", "PowerSource", new {id = ps.StrURN});

        }

        public IActionResult GetSinglePowerSource(String id)
        {
            return View();
        }

    }
}
