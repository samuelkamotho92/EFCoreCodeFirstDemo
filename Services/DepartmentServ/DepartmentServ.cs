using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services.DepartmentServ
{
    public class DepartmentServ : IDepartment
    {
        public async Task<Department> AddDepartment()
        {
           // Console.WriteLine("Enter Department");
            throw new NotImplementedException();

        }

        public Task DeleteDepartment()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartment()
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetDepartments()
        {
            throw new NotImplementedException();
        }
    }
}
