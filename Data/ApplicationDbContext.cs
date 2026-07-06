using EmployeeManagementSystemAI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystemAI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        protected ApplicationDbContext()
        {
        }
    }
}
