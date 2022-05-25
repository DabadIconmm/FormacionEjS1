using Ejercicio_Sesión_1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_Sesión_1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Libro>().HasKey(x => x.LibroId);
            modelBuilder.Entity<Libro>().Property(x => x.Titulo).HasMaxLength(150);
            modelBuilder.Entity<Libro>().Property(x => x.Paginas).HasMaxLength(10000);

            modelBuilder.Entity<Editorial>().HasKey(x => x.EditorialId);
            modelBuilder.Entity<Editorial>().Property(x => x.Nombre).HasMaxLength(50);

        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
    }
}
