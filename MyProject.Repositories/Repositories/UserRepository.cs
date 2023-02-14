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
    public class UserRepository : IUserRepository
    {
        private readonly IContext _Context;
        public UserRepository(IContext Context) 
        {
            _Context = Context;
        }
        public async Task<User> AddAsync(User user)
        {
            var addUser= _Context.MyUsers.Add(user);
           await _Context.SaveChangesAsync();
            return addUser.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _Context.MyUsers.Remove(await GetByIdAsync(id));
          await _Context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _Context.MyUsers.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _Context.MyUsers.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var update = _Context.MyUsers.Update(user);
            await _Context.SaveChangesAsync();
            return update.Entity;
        }
    }
}
