using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyProject.Context
{
    public class DBContext:DbContext,IContext
    {        
        public DbSet<User> MyUsers { get ; set ; }
        public DbSet<Child> MyChildren { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShiffiDB;Trusted_Connection=True;");
        }
    }
}
