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
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobName { get; set; }

        [Display(Name = "شماره شرکت")]
        public int? JobNumber { get; set; } = 0;

        [Display(Name = "آدرس شرکت")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobAddress { get; set; }

        [Display(Name = "شروع کار")]
        public DateTime? StartYear { get; set; } = DateTime.Now;

        [Display(Name = "خاتمه کار")]
        public DateTime? EndYear { get; set; } = DateTime.Now;

        [Display(Name = "سمت و وظایف")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobDetails { get; set; }

        [Display(Name = "حقوق")]
        public int? JobSalary { get; set; } = 0;

        [Display(Name = "علت ترک کار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobEndReason { get; set; }
    }
}
