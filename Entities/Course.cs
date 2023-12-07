using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Entities
{
    public class Course
    {
        public int courseId {  get; set; }

        public string courseName { get; set; }

        public virtual Professor Professor { get; set; }

        public int professorId { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
