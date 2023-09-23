using Microsoft.EntityFrameworkCore;

namespace InmobiliariaBlazorApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Inmueble> Inmuebles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<UsuarioFavorito> UsuariosFavoritos { get; set; }
        public DbSet<UsuarioInmueble> UsuarioInmuebles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioInmueble>().HasKey(ui => new { ui.UsuarioId, ui.InmuebleId });
            modelBuilder.Entity<UsuarioFavorito>().HasKey(uf => new { uf.UsuarioId, uf.InmuebleId });
        }



        // Aquí defines los DbSet para cada entidad que quieras almacenar en la base de datos.
        // Por ejemplo:
        // public DbSet<Propiedad> Propiedades { get; set; }
    }
}
