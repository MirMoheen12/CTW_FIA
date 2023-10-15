using CTW_FIA.Interface;
using CTW_FIA.Models;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Web;

namespace CTW_FIA.Controllers
{
    
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

        //[HttpPost]
        //public IActionResult Login(Login user)
        //{
        //    if (!string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password))
        //    {
        //        UserDto UserData = userRepo.Login(user.UserName, user.Password);

        //        if (UserData != null)
        //        {
        //            string userRole = UserData.UserRole;
        //            HttpContext.Session.SetString("UserRole", userRole);
        //            HttpContext.Session.SetString("UserName", UserData.UserName);
        //            return RedirectToAction("Index", "Dashboard");
        //        }
        //        ModelState.AddModelError("UserName", "Invalid Username or Password.");
        //    }
        //    return View(user);

        //}


        [HttpPost]
        public IActionResult Login(Login user)
        {
            if (!string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password))
            {
                UserDto UserData = userRepo.Login(user.UserName, user.Password);
                int depid = 0;
                int offid = 0;
                if (UserData != null)
                {
                    depid = int.Parse(UserData.DepartmentID);
                    offid = int.Parse(UserData.OfficeID);
                }

                if (UserData != null)
                {
                    string userRole = UserData.UserRole;

                    // Compare the client's MAC address from the hidden input field with those stored in the database
                    string ma = userRepo.GetLocalMacAddress();
                    bool isMacAddressValid=false;
                    if (ma != null)
                    {
                        isMacAddressValid = userRepo.IsMacAddressValid(ma, depid, offid);
                    }
                    else
                    {
                        ModelState.AddModelError("UserName", "MacAddress Not Found");
                    }
                    if (isMacAddressValid)
                    {
                        HttpContext.Session.SetString("UserRole", userRole);
                        HttpContext.Session.SetString("UserName", UserData.UserName);
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("UserName", "Your Computer System is not Registered! Please Contact Administrator.");
                    }


                }
                else
                {
                    ModelState.AddModelError("UserName", "Invalid Username or Password.");
                }
            }
            return View(user);
        }




        public IActionResult Signout()
        {
            HttpContext.Session.Remove("UserRole");
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Login", "Accounts");
        }

    }
    }
