﻿using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    public class BankAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
