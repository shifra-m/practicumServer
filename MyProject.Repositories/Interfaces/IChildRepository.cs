using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IChildRepository
    {
        Task<List<Child>> GetAllAsync();
        Task<Child> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<Child> UpdateAsync(Child child);
        Task<Child> AddAsync(Child child);
    }
}
