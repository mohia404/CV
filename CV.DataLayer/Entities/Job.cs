using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.DataLayer.Entities
{
    public class Job
    {
        public Job()
        {

        }

        [Key]
        public int JobId { get; set; }

        [Display(Name = "نام شرکت")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobName { get; set; }

        [Display(Name = "شماره شرکت")]
        public int? JobNumber { get; set; }

        [Display(Name = "آدرس شرکت")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobAddress { get; set; }

        [Display(Name = "شروع کار")]
        [DataType(DataType.Date)]
        public DateTime? StartYear { get; set; }

        [Display(Name = "خاتمه کار")]
        [DataType(DataType.Date)]
        public DateTime? EndYear { get; set; }

        [Display(Name = "سمت و وظایف")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobDetails { get; set; }

        [Display(Name = "حقوق")]
        public int? JobSalary { get; set; }

        [Display(Name = "علت ترک کار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string JobEndReason { get; set; }

        #region Relations

        public virtual User User { get; set; }

        #endregion
    }
}
