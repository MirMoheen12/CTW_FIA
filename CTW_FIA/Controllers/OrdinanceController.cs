using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class OrdinanceController : Controller
    {
        private readonly IOrdinance ordinance;
        public OrdinanceController(IOrdinance ordinance)
        {
            this.ordinance = ordinance;
        }
        public IActionResult AllOrdinance()
        {
            var dat=ordinance.AllOrdinance();
            return View(dat);
        }
    }
}
