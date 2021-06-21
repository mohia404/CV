using CV.Core.DTOs;
using CV.Core.Services.Interfaces;
using CV.DataLayer.Entities;
using CV.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Web.Controllers
{
    public class RegisterController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;

        public RegisterController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }


        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(UserViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            User user = new User()
            {
                //ActiveCode = NameGenerator.GenerateUniqueCode(),
                //Email = FixedText.FixEmail(register.Email),
                //IsActive = false,
                //Password = PasswordHelper.EncodePasswordMd5(register.Password),
                //RegisterDate = DateTime.Now,
                //UserAvatar = "Default.jpg",
                UserName = register.UserName,
                FatherName = register.FatherName,
                BirthPlace = register.BirthPlace
            };
            _userService.AddUser(user);

            return View("SuccessRegister", user);

        }

        #endregion
    }
}
