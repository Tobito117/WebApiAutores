using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.Entidades;

namespace WebApiAutores
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AutorLibro>()
                .HasKey(al => new { al.AutorId, al.LibroId });
        }

        public virtual DbSet<Autor> Autores { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<AutorLibro> AutoresLibros { get; set; }

    }
}
