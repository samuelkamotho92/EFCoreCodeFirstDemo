using EFCoreCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstDemo.Services
{
    public interface IProfessor
    {
        Task<List<Professor>> GetProfessors();

        Task<Professor> GetProfessor();

        Task<Professor> AddProfessor();

        Task DeleteProfessor();

        Task UpdateProfessor();
    }
}
