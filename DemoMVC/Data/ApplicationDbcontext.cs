using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<DemoMVC.Models.Employeee> Employeee { get; set; } = default!;

    }
}