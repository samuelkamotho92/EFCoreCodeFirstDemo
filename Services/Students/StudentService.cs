using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services.Students
{
    public class StudentService : IStudent
    {
        SMSCoreDbContext smsDbContext = new SMSCoreDbContext();

        public int userInput()
        {
           
            Console.WriteLine("Enter The User Id You want To View");
            string userInpt = Console.ReadLine();
            int num;
            bool stateInput = int.TryParse(userInpt,out num);
            if (stateInput)
            {
                List<Student> students = smsDbContext.Students.ToList();
                if(num <= students.Count)
                {
                return num;
                }
                else
                {
                    Console.WriteLine("User with Id does not exist yet");
                    userInput();
                }
            }
            else
            {
                Console.WriteLine("Enter a number please");
            }
            return num;
        }

        //Create Student
        public async Task<Student> AddStudent()
        {
            Console.WriteLine("Create Student");
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter What you are Majoring In");
            string Major = Console.ReadLine();
            Student student1 = new Student() { 
            FirstName = FirstName,
            LastName = LastName,
            Email =Email,
            Major = Major   
            };
            Console.WriteLine(smsDbContext.Students.Add(student1));
            smsDbContext.Students.Add(student1);
            smsDbContext.SaveChanges();
            Console.WriteLine("Student Successfully created");
            return student1;
        }
         //Get All Students
        public async Task<List<Student>> GetStudents()
        {
            //Get DbContext
            List<Student> students =  smsDbContext.Students.ToList();
            Console.WriteLine("The Registered Students are");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentId}: {student.FirstName} {student.LastName}");
            }

            return students;
        }
        //Get One Student
        public async Task<Student> GetStudent()
        {
            int stdId = userInput();
            Student student = smsDbContext.Students.Find(stdId);
            Console.WriteLine($"You selected");
            Console.WriteLine($"{student.StudentId}:{student.FirstName} {student.LastName}");
            return student;
        }

        //Delete Student
        public async Task DeleteStudent()
        {
            int stdId = userInput();
            var student = smsDbContext.Students.Find(stdId);
            smsDbContext.Students.Remove(student);
            smsDbContext.SaveChanges();
            Console.WriteLine("User deleted Successfully");
        }
        //Update Student
        public async Task<Student> updateStudent()
        {
            int stdId = userInput();
            Student student = smsDbContext.Students.Find(stdId);
            Console.WriteLine(student);
            if(student != null)
            {
                student.FirstName = "Samuel";
                student.LastName = "Kamotho";
                student.Email = "samuelkamotho92@gmail.com";
                smsDbContext.SaveChanges();
            }
 
            return student;
        }
    }
}
