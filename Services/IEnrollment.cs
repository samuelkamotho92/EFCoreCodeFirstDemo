using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services
{
    public interface IEnrollment
    {
        Task<List<Enrollment>> GetEnrollments();

        Task<Enrollment> GetEnrollment();

        Task<Enrollment> AddEnrollment();

        Task UpdateEnrollment();

        Task DeleteEnrollment();
    }
}
