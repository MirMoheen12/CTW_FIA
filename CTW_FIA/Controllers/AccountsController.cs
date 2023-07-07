using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
