using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class PersonController : Controller
    {   private readonly ICommonlinks _commonLinks;  
        private readonly ITerrorist terrorist;
        public PersonController(ICommonlinks _commonLinks,ITerrorist terrorist)
        {
            this.terrorist=terrorist;
            this._commonLinks = _commonLinks;
        }
        public IActionResult AddPerson()
        {
            ViewBag.Agencies = terrorist.AllAgencies();
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person P,IFormFile file)
        {
            var res = terrorist.AddNewPerson(P,file);
            ViewBag.Agencies = terrorist.AllAgencies();
            ViewBag.Allcountries = terrorist.AllCountry();
            return View();
        }
        public IActionResult PersonDetails(string STRURN)
        {
            List<DisplayModel> dm=new List<DisplayModel>();
            var Linkres = _commonLinks.getAlllinksCount(STRURN);
            ViewBag.link = Linkres;
            ///QuickSearchPerson_sel_Result
            var data=terrorist.GetPeronByID(STRURN);
            Type type = data.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                DisplayModel model = new DisplayModel();
                model.PropertName = GetDisplayName(data,property.Name);
              
                model.PropertValue = Convert.ToString(property.GetValue(data));
                dm.Add(model);  
               
            }
            return View(dm);
        }
        string GetDisplayName(object obj, string propertyName)
        {
            Type type = obj.GetType();
            var propertyInfo = type.GetProperty(propertyName);

            if (propertyInfo != null)
            {
                var displayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(DisplayAttribute));

                if (displayAttribute != null)
                {
                    return displayAttribute.Name;
                }
            }

            return null;
        }
    }
}
