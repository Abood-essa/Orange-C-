using Microsoft.EntityFrameworkCore;
using Validation.Models;

namespace Validation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
