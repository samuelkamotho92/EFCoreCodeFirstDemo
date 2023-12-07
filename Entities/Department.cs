using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Entities
{
    public class Department
    {
        public int departmentId { get; set; }

        public ICollection<Professor> professors { get; set;}

        public string departmentName { get; set; }

    }
}
