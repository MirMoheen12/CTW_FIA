using CTW_FIA.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    
    public class QuickSearchController : Controller
    {
        private readonly IQuickSearch quickSearch;
        public QuickSearchController(IQuickSearch quickSearch)
        {
            this.quickSearch = quickSearch;
        }
        public IActionResult SearchRec(string searchval)
        {
            var res = quickSearch.getSearchdata(searchval);
            ViewBag.searchval = searchval;
            return View();
        }

        public JsonResult GetRes(string SearchVal)
        {
            var res=quickSearch.getSearchdata(SearchVal);
            return Json(res);
        }
    }
}
