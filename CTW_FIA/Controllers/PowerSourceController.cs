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
    }
}
