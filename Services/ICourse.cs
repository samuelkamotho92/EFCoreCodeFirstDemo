using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services
{
    public interface ICourse
    {
        Task<List<Course>> GetAllCourses();

        Task<Course> GetCourse();

        Task <Course> AddCourse();

        Task UpdateCourse();

        Task DeleteCourse();
    }
}
