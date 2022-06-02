using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Lugar> tblLugares { get; set; }
        public DbSet<Categoria> tblCategorias { get; set; }
        public DbSet<Evento> tblEventos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var conString = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(conString);
        }
    }
}
