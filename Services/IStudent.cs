using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services
{
    public interface IStudent
    {
        //Get All
        Task<List<Student>> GetStudents();

        //Get single student
        Task<Student> GetStudent();

        //Add a student
        Task<Student>  AddStudent();

        //Delete student
        Task DeleteStudent();

        Task<Student> updateStudent();

    }
}
