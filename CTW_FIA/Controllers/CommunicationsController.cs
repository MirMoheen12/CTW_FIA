using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class CommunicationsController : Controller
    {
        private readonly ICommunication communication;
        public CommunicationsController(ICommunication communication)
        {
            this.communication = communication;
        }
        public IActionResult AllCommunications()
        {
            var data = communication.AllCommunication();
            return View(data);
        }
    }
}
