using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
