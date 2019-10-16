using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ac686115_MIS4200.Models
{
    public class Doctor
    {
        
        [Key] 
        [Display(Name = "Doctor ID")]
        

        public int doctorID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Doctors first name is required")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Doctors last name is required")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter your school email")]
        [StringLength(50)]
        public string email { get; set; }

        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        public int patientId {get; set; }

        

        public ICollection<Patient> Patient { get; set; }

       

       


    }
}