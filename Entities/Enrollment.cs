using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Entities
{
    public class Enrollment
    {
        public int enrollmentId { get; set; }

       public int studentId { get; set; }

        public int courseId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string grading { get; set; }
    }
}
