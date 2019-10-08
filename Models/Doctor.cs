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
        public int doctorID { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public ICollection<Patient> Patient { get; set; }

        public int patiendID { get; set; }

       


    }
}