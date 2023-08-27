using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class EventsLogsController : Controller
    {
        public IActionResult AllLogs()
        {
            return View();
        }
    }
}
