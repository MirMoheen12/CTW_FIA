using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class ComponentsController : Controller
    {
        private readonly IComponents components;
        private readonly ITerrorist terrorist;
        public ComponentsController(IComponents components, ITerrorist terrorist)
        {
            this.components = components;
            this.terrorist = terrorist;
        }
        public IActionResult AllComponenst()
        {
            var data=components.AllComponents();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddComponent()
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }

        [HttpPost]
        
        public IActionResult AddComponent([Bind("strURN, Type, CountryOrigin, Material, Manufacturer, Description, MethodDelivery, QuantityWeight, QuantityNo, CountryRecovered, Length, Width, Height, Diameter, Colour, Markings, memRemarks")] Components c)
        {
        components.AddNewComponent(c);
            ViewBag.Allcountries = terrorist.AllCountry();
            return RedirectToAction("AddRecord", "Record", new { pagname = "Components", pagestatus = "Updated" });


        }

        [HttpGet]
        public IActionResult EditComponent(string StrURN)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            var data = components.GetComponByStrurn(StrURN);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditComponent(Components c)
        {
            ViewBag.Allcountries = terrorist.AllCountry();
            components.PostEditComponent(c);
            return RedirectToAction("index", "Dashboard");
        }

    }
}
