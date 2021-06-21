using CV.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.DTOs
{
    public class JobViewModel
    {
        public int UserId { get; set; }

        [Display(Name = "نام شرکت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobName { get; set; }

        [Display(Name = "شماره شرکت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public int JobNumber { get; set; }

        [Display(Name = "آدرس شرکت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobAddress { get; set; }

        [Display(Name = "شروع کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime StartYear { get; set; }

        [Display(Name = "خاتمه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime EndYear { get; set; }

        [Display(Name = "سمت و وظایف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobDetails { get; set; }

        [Display(Name = "سمت و وظایف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public int JobSalary { get; set; }

        [Display(Name = "علت ترک کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobEndReason { get; set; }
    }
}
