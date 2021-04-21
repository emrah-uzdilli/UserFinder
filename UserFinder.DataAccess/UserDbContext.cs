using Microsoft.EntityFrameworkCore;
using System;
using UserFinder.Entities;

namespace UserFinder.DataAccess
{
    public class UserDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UserDb;Integrated Security=true;");
        }
        public DbSet<User> Users { get; set; }
    }

   
}
