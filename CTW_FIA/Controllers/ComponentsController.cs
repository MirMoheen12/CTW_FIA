using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class ComponentsController : Controller
    {
        private readonly IComponents components;
        public ComponentsController(IComponents components)
        {
            this.components = components;
        }
        public IActionResult AllComponenst()
        {
            var data=components.AllComponents();
            return View(data);
        }
    }
}
