using Microsoft.EntityFrameworkCore;
using WebAppemployees.Models;

namespace WebAppemployees.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {


        }

        public DbSet<Employee> Employees{  get; set; }

    }
}
