using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeadCount.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HeadCount.Data.Department> Department { get; set; }
        public DbSet<HeadCount.Data.Employee> Employee { get; set; }
        public DbSet<HeadCount.Data.Audit> Audit { get; set; }
    }
}