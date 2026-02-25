using Microsoft.EntityFrameworkCore;
namespace LinkVault_Proyecto.Data
{
    public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        // Estos DbSets son los que te permiten consultar las tablas desde C#
        public DbSet<LinkVault_Proyecto.Models.Categoria> Categorias { get; set; }
        public DbSet<LinkVault_Proyecto.Models.Recurso> Recursos { get; set; }
        // Agrega este bloque para mapear correctamente con Oracle
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Forzamos a que el ORM busque las tablas en MAYÚSCULAS
            modelBuilder.Entity<LinkVault_Proyecto.Models.Categoria>()
                .ToTable("CATEGORIAS");

            modelBuilder.Entity<LinkVault_Proyecto.Models.Recurso>()
                .ToTable("RECURSOS");
        }
    }
}
