using CTW_FIA.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class FiearmsController : Controller
    {
        private readonly IFearams fearams;
        public FiearmsController(IFearams fearams)
        {
            this.fearams = fearams;
        }
        public IActionResult allFiearms()
        {
            var data=fearams.allfearms();
            return View(data);
        }
    }
}
