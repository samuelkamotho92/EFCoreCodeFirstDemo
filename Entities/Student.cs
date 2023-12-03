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
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Height { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public float Weight { get; set; }
        public virtual Standard? Standard { get; set; }

    }
}
