using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services
{
    public interface IDepartment
    {
        Task<List<Department>> GetDepartments();

        Task<Department> GetDepartment();

        Task<Department> AddDepartment();

        Task DeleteDepartment();


    }
}
