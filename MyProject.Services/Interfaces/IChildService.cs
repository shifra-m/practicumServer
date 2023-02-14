using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
   public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();
        Task<ChildDTO> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<ChildDTO> UpdateAsync(ChildDTO childDTO);
        Task<ChildDTO> AddAsync(ChildDTO childDTO);
    }
}
