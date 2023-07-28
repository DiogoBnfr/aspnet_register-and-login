using aspnet_register_and_login.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_register_and_login.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 

        }
    }
}