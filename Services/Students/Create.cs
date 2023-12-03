using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services.Students
{
    public class Create
    {
        public void createStudent()
        {
            try
            {
                EFCoreDbContext context = new EFCoreDbContext();
                Student student = new Student()
                {
                    FirstName = "Brian",
                    LastName = "Kush",
                    Height = 5.7M,
                    Weight = 63
                };
                //Add student into context object
                context.Students.Add(student);
                //save changes method 
                context.SaveChanges();
                Console.WriteLine($"User {student.FirstName} successfully created");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); ;
            }
           
        }
    }
}
