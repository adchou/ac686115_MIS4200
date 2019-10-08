using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ac686115_MIS4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace ac686115_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
    }
}