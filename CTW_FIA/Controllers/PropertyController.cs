using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProperty()
        {
            return View();
        }
    }
}
