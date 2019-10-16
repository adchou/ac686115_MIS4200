using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ac686115_MIS4200.Models
{
    public class Patient
    {
        [Key]
        [Display(Name = "Patient ID")]
        public int patientID { get; set;}

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Patients first name is required")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Patients first name is required")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter your school email")]
        [StringLength(50)]
        public string email { get; set; }

        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "When was your last visit?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime patientSince { get; set; }


        
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

}
}