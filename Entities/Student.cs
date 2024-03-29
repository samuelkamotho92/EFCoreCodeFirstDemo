﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstDemo.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int StandardId { get; set; }

        public string Major { get; set; }

        //Virtual properties
        public virtual StudentAddress StudentAddress { get; set; }

        public virtual ICollection <Enrollment> Enrollments { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
