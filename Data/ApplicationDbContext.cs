using Microsoft.EntityFrameworkCore;
namespace LinkVault_Proyecto.Data
{
    public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<LinkVault_Proyecto.Models.Categoria> Categorias { get; set; }
        public DbSet<LinkVault_Proyecto.Models.Recurso> Recursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LinkVault_Proyecto.Models.Categoria>()
                .ToTable("CATEGORIAS");

            modelBuilder.Entity<LinkVault_Proyecto.Models.Recurso>()
                .ToTable("RECURSOS");
        }
    }
}
