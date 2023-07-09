using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class RecordController : Controller
    {
        public IActionResult AddRecord()
        {
            return View();
        }
    }
}
