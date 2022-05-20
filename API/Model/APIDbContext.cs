using Microsoft.EntityFrameworkCore;

namespace API.Model
{
    public class APIDbContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<User> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var conString = Configuration.GetConnectionString("Conexion");
            optionsBuilder.UseSqlServer(conString);
        }
    }
}
