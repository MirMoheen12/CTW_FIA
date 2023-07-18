using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class DetonatorsController : Controller
    {
        private readonly IDetonators detonators;
        public DetonatorsController(IDetonators detonators)
        {
            this.detonators = detonators;   
        }
        public IActionResult Index()
        {
            var dta = detonators.alldetonators();
            return View(dta);
        }
    }
}
