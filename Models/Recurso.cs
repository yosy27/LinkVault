using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkVault_Proyecto.Models
{
    [Table("RECURSOS")] // Mapea a la tabla física en Oracle
    public class Recurso
{
        [Key]
        [Column("ID_RECURSO")]
        public int Id { get; set; }

        [Required]
        [Column("TITULO")]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [Column("URL")]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;

        [Column("ID_CATEGORIA")]
        public int CategoriaId { get; set; }

        [Column("ACTIVO")]
        public int Activo { get; set; } = 1; // 1 para activo, 0 para inactivo

        // Propiedad de navegación para Entity Framework
        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}
