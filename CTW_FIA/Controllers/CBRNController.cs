using CTW_FIA.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class CBRNController : Controller
    {
        private readonly ICBRN cBRN;
        public CBRNController(ICBRN cBRN)
        {
            this.cBRN = cBRN;
        }
        public IActionResult AllCbrn()
        {
            var data = cBRN.Allcbrn();
            return View(data);
        }
    }
}
