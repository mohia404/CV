using CV.Core.DTOs;
using CV.Core.Services.Interfaces;
using CV.DataLayer.Entities;
using CV.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace CV.Web.Controllers
{
    public class RegisterController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;
        //private IHostingEnvironment _hostingEnv;

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
        public async Task<IActionResult> Register(UserViewModel register, IFormFile UserImageName)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            string filename;
            
            if(UserImageName!=null)
            {
                filename = ContentDispositionHeaderValue.Parse(UserImageName.ContentDisposition).FileName.Trim('"');
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UserAvatar", UserImageName.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    await UserImageName.CopyToAsync(stream);
                }
            }
            else
            {
                filename = "defult.jpg";
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
                ResidentialSituation = register.ResidentialSituation,
                Telephone = register.Telephone,
                UniversityEndYear = register.UniversityEndYear,
                UniversityName = register.UniversityName,
                UniversityStartYear = register.UniversityStartYear,
                UserImageName = filename
            };

            user.Jobs = new List<Job>();

            for (int i = 0; i < register.Jobs.Count(); i++)
            {
                if (register.Jobs[i].JobName != null)
                {
                    user.Jobs.Add(new Job()
                    {
                        StartYear = register.Jobs[i].StartYear,
                        JobSalary = register.Jobs[i].JobSalary,
                        EndYear = register.Jobs[i].EndYear,
                        JobNumber = register.Jobs[i].JobNumber,
                        JobName = register.Jobs[i].JobName,
                        JobAddress = register.Jobs[i].JobAddress,
                        JobDetails = register.Jobs[i].JobDetails,
                        JobEndReason = register.Jobs[i].JobEndReason
                    });
                }
            }
            _userService.AddUser(user);

            return View("SuccessRegister", user);

        }

        #endregion

        [Route("Login")]
        public IActionResult Login()
        {
            var dataUsers = _userService.GetAllUsers();
            var users = new List<TableUserViewModel>();
            foreach (var item in dataUsers)
            {

                var newUser = new TableUserViewModel()
                {
                    UserName = item.UserName,
                    FatherName = item.FatherName,
                    BirthPlace = item.BirthPlace,
                    Address = item.Address,
                    WorkTraits = item.WorkTraits,
                    WorkProjects = item.WorkProjects,
                    Interests = item.Interests,
                    LifeGoal = item.LifeGoal,
                    ExpectedSalary = item.ExpectedSalary,
                    OtherWork = item.OtherWork,
                    //Jobs= item.Jobs,
                    BirthDate = item.BirthDate,
                    DegreeOfEducation = item.DegreeOfEducation,
                    Dependants = item.Dependants,
                    DutyPossition = item.DutyPossition,
                    EmergencyNumber = item.EmergencyNumber,
                    FatherJob = item.FatherJob,
                    FieldOfEducation = item.FieldOfEducation,
                    IdNumber = item.IdNumber,
                    Mobile = item.Mobile,
                    Nation = item.Nation,
                    OtherLanguages = item.OtherLanguages,
                    //Religion=item.Religion,
                    ResidentialSituation = item.ResidentialSituation,
                    Telephone = item.Telephone,
                    UniversityEndYear = item.UniversityEndYear,
                    UniversityName = item.UniversityName,
                    UniversityStartYear = item.UniversityStartYear,
                    UserImageName = item.UserImageName
                };

                newUser.Jobs = new List<string>();

                if (item.EnglishReading == 2)
                {
                    newUser.EnglishReading = "خوب";
                }
                else if (item.EnglishReading == 1)
                {
                    newUser.EnglishReading = "متوسط";
                }
                else if (item.EnglishReading == 0)
                {
                    newUser.EnglishReading = "ضعیف";
                }

                if (item.EnglishWriting == 2)
                {
                    newUser.EnglishWriting = "خوب";
                }
                else if (item.EnglishWriting == 1)
                {
                    newUser.EnglishWriting = "متوسط";
                }
                else if (item.EnglishWriting == 0)
                {
                    newUser.EnglishWriting = "ضعیف";
                }

                if (item.EnglishSpeaking == 2)
                {
                    newUser.EnglishSpeaking = "خوب";
                }
                else if (item.EnglishSpeaking == 1)
                {
                    newUser.EnglishSpeaking = "متوسط";
                }
                else if (item.EnglishSpeaking == 0)
                {
                    newUser.EnglishSpeaking = "ضعیف";
                }

                if (item.IsMarried)
                {
                    newUser.IsMarried = "متاهل";
                }
                else
                {
                    newUser.IsMarried = "مجرد";
                }

                if (item.Jobs != null)
                {
                    foreach (var job in item.Jobs)
                    {
                        if (job.JobName != null)
                        {
                            var stringJob = $"در {job.JobName} با شماره {job.JobNumber} به آدرس {job.JobAddress} از تاریخ {job.StartYear} تا تاریخ {job.EndYear} با وظیفه {job.JobDetails} و حقوق {job.JobSalary} و دلیل ترک {job.JobEndReason}";
                            newUser.Jobs.Add(stringJob);
                        }

                    }
                }
                users.Add(newUser);
            }
            return View(users);
        }
    }
}
