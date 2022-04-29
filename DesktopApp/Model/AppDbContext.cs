using Microsoft.EntityFrameworkCore;

namespace DesktopApp.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DesktopAppVP11C1;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //API FLUENT
            //modelBuilder.Entity<Empleado>().HasKey(emp => emp.Rut);
        }
    }
}
