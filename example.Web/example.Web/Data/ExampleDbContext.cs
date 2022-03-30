using example.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace example.Web.Data
{
    public class ExampleDbContext:DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                 .HasIndex(t => t.Name)
                 .IsUnique();

          

        }

    }
}
