using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = null!;
    }
}