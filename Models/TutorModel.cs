using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Tutor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }  // Nombre del tutor

        [Required]
        [StringLength(100)]
        public string? Apellido { get; set; }  // Apellido del tutor

        [Required]
        [StringLength(15)]
        public string? Telefono { get; set; }  // Número de teléfono

        [StringLength(100)]
        public string? Direccion { get; set; }  // Dirección del tutor

        // Relación uno a muchos con Estudiante
        public ICollection<Estudiante> Estudiantes { get; set; }

        // Constructor para inicializar las colecciones
        public Tutor()
        {
            Estudiantes = new HashSet<Estudiante>();
        }
    }
}
