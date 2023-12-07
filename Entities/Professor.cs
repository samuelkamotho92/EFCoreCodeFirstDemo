using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Entities
{
    public class Professor
    {
        public int professorId { get; set; }

        public string professorName { get; set; }

        public int departmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
