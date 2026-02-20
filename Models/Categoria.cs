using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkVault_Proyecto.Models
{
    [Table("CATEGORIAS")] // Mapea a la tabla física en Oracle
    public class Categoria
{
        [Key]
        [Column("ID_CATEGORIA")]
        public int Id { get; set; }

        [Required]
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Column("DESCRIPCION")]
        [StringLength(200)]
        public string? Descripcion { get; set; }

        [Column("FECHA_REGISTRO")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        // Relación: Una categoría tiene muchos recursos
        public ICollection<Recurso> Recursos { get; set; } = new List<Recurso>();
    }
}
