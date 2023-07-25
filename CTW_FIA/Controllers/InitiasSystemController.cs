using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class InitiasSystemController : Controller
    {
        private readonly IIntianSystem intian;
        public InitiasSystemController(IIntianSystem intian)
        {
            this.intian = intian;
        }
        public IActionResult AllIntianSystem()
        {
            var data = intian.AllSystem();
            return View(data);
        }
    }
}
