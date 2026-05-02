using CompanySystem.Models;
using Microsoft.EntityFrameworkCore;
namespace CompanySystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        public DbSet<ContactFeedback> ContactFeedbacks { get; set; }
    }
}
