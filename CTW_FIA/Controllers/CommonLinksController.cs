using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class CommonLinksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
