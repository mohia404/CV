using CV.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.DTOs
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string UserName { get; set; }

        [Display(Name = "محل تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string BirthPlace { get; set; }

        [Display(Name = "نام پدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string FatherName { get; set; }

        [Display(Name = "شماره شناسنامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int IdNumber { get; set; }

        [Display(Name = "ملیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Nation { get; set; }

        [Display(Name = "مذهب")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Religion { get; set; }

        [Display(Name = "شغل پدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string FatherJob { get; set; }

        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "وضعیت نظام وظیفه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string DutyPossition { get; set; }

        [Display(Name = "وضعیت تاهل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool IsMarried { get; set; }

        [Display(Name = "اخرین مدرک تحصیلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string DegreeOfEducation { get; set; }

        [Display(Name = "رشته تحصیلی و گرایش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string FieldOfEducation { get; set; }

        [Display(Name = "نام دانشگاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string UniversityName { get; set; }

        [Display(Name = "سال ورود به دانشگاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UniversityStartYear { get; set; }

        [Display(Name = "سال اخذ مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UniversityEndYear { get; set; }

        [Display(Name = "تلفن ثابت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Telephone { get; set; }

        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Mobile { get; set; }

        [Display(Name = "تلفن ضروری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int EmergencyNumber { get; set; }

        [Display(Name = "وضعیت محل سکونت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string ResidentialSituation { get; set; }

        [Display(Name = "تعداد افراد تحت تکفل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Dependants { get; set; }

        [Display(Name = "محل سکونت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Address { get; set; }

        [Display(Name = "زبان های دیگر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string OtherLanguages { get; set; }

        [Display(Name = "مکالمه انگلیسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int EnglishSpeaking { get; set; }

        [Display(Name = "خواندن انگلیسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int EnglishReading { get; set; }

        [Display(Name = "نوشتن انگلیسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int EnglishWriting { get; set; }

        [Display(Name = "ویژگی و روحیات کاری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string WorkTraits { get; set; }

        [Display(Name = "دوره های آموزشی طی شده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string WorkProjects { get; set; }

        [Display(Name = "دوره های آموزشی طی شده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Interests { get; set; }

        [Display(Name = "هدف 5 ساله")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string LifeGoal { get; set; }

        [Display(Name = "میزان حقوق درخواستی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ExpectedSalary { get; set; }

        [Display(Name = "علاقه به کار دیگری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string OtherWork { get; set; }

        //[Display(Name = "کارهای سابق")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        //[MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        //public List<Job> Jobs { get; set; }

        [MaxLength(50)]
        public string UserImageName { get; set; }
    }
}
