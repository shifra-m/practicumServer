using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
  public  class ChildRepository:IChildRepository
    {
        private readonly IContext _Context;
        public ChildRepository(IContext MyContext)
        {
            _Context = MyContext;
        }
        public async Task<Child> AddAsync(Child child)
        {
            var addChild = _Context.MyChildren.Add(child);
           await _Context.SaveChangesAsync();
           return addChild.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _Context.MyChildren.Remove(await GetByIdAsync(id));
           await _Context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _Context.MyChildren./*Include(u=>u.UserId)*/ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _Context.MyChildren.Include(u=>u.UserId).FirstOrDefaultAsync(u=>u.ChildId==id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var updateChild = _Context.MyChildren.Update(child);
           await _Context.SaveChangesAsync();
            return updateChild.Entity;
        }
    }
}

