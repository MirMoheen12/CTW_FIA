using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTW_FIA.Controllers
{
    [AllowAnonymous]
    public class AccountsController : Controller
    {
        private readonly IUser userRepo;

        public AccountsController(IUser userRepo)
        {
            this.userRepo = userRepo;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDto user)
        {
            UserDto UserData = userRepo.Login(user.UserName, user.Password);
           if (UserData!=null)
                return RedirectToAction("Index", "Home");
           else 
                return View();
        }

    }
}
