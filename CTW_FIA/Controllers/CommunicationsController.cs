using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class CommunicationsController : Controller
    {
        private readonly ICommunication communication;
        private readonly ITerrorist terrorist;
        public CommunicationsController(ICommunication communication, ITerrorist terrorist)
        {
            this.communication = communication;
            this.terrorist = terrorist;

        }
        public IActionResult AllCommunications()
        {
            var data = communication.AllCommunication();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddCommunicaion()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View(new Communications());
        }
        [HttpPost]
        public IActionResult AddCommunicaion(Communications c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var res = communication.AddNewcommunication(c);
            return View(new Communications());
        }
    }
}
