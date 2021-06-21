﻿using CV.Core.DTOs;
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
                UserName = register.UserName,
                FatherName = register.FatherName,
                BirthPlace = register.BirthPlace,
                Address = register.Address,
                WorkTraits = register.WorkTraits,
                WorkProjects = register.WorkProjects,
                Interests = register.Interests,
                LifeGoal = register.LifeGoal,
                ExpectedSalary = register.ExpectedSalary,
                OtherWork = register.OtherWork,
                //Jobs= register.Jobs,
                BirthDate = register.BirthDate,
                DegreeOfEducation = register.DegreeOfEducation,
                Dependants = register.Dependants,
                DutyPossition = register.DutyPossition,
                EmergencyNumber = register.EmergencyNumber,
                EnglishReading = register.EnglishReading,
                EnglishSpeaking = register.EnglishSpeaking,
                EnglishWriting = register.EnglishWriting,
                FatherJob = register.FatherJob,
                FieldOfEducation = register.FieldOfEducation,
                IdNumber = register.IdNumber,
                IsMarried = register.IsMarried,
                Mobile = register.Mobile,
                Nation = register.Nation,
                OtherLanguages = register.OtherLanguages,
                RegisterTime = DateTime.Now,
                //Religion=register.Religion,
                ResidentialSituation= register.ResidentialSituation,
                Telephone= register.Telephone,
                UniversityEndYear= register.UniversityEndYear,
                UniversityName= register.UniversityName,
                UniversityStartYear=register.UniversityStartYear,
                UserImageName=register.UserImageName
            };
            _userService.AddUser(user);

            return View("SuccessRegister", user);

        }

        public void AddWork(List<JobViewModel> jobs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(jobs);
            //}

            //foreach(var item in jobs)
            //{
            //    Job job = new Job()
            //    {
            //        User = User.
            //    }
            //}
            //User user = new User()
            //{
            //    UserName = jobs.UserName,
            //};
            //_userService.AddUser(user);

            //return View("SuccessRegister", user);

        }

        #endregion
    }
}
