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
        SMSCoreDbContext smsDbContext = new SMSCoreDbContext();

        public int userInput()
        {

            Console.WriteLine("Enter The Department Id You want To View");
            string userInpt = Console.ReadLine();
            int num;
            bool stateInput = int.TryParse(userInpt, out num);
            if (stateInput)
            {
               List<Department> departmentList = new List<Department>();
                if (num <= departmentList.Count)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Department with Id does not exist yet");
                    userInput();
                }
            }
            else
            {
                Console.WriteLine("Enter a number please");
            }
            return num;
        }
        public async Task<Department> AddDepartment()
        {
            Department department = new Department();
            Console.WriteLine("Entert Department Name");
            string departmentName = Console.ReadLine();
            department.departmentName = departmentName;
            smsDbContext.Add(department);
            smsDbContext.SaveChanges();
           

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
