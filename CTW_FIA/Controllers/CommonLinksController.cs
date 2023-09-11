﻿using CTW_FIA.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class CommonLinksController : Controller
    {
        private readonly ICommonlinks commonlinks;
        public CommonLinksController(ICommonlinks commonlinks)
        {
            this.commonlinks = commonlinks;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult createlinks()
        {
            var data = commonlinks.GetallLinks();
            return View(data);
        }
        public JsonResult AddLink(string Srctab,string Desttab,string srcStrn,string deststrn,string SE,string RE,string RL,string BI)
        {
            try
            {
                var data = commonlinks.CreateCommonlinks(srcStrn, deststrn, Srctab, Desttab, "Linked", "", SE, RE, RL, BI);
                return Json("Success");
            }
            catch (Exception)
            {
                return Json("Fail");
            }
      
        }
    }
}
