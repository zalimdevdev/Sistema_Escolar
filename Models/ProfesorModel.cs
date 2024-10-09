using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }  // Nombre del profesor

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }  // Apellido del profesor

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }  // Número de teléfono del profesor

        [StringLength(100)]
        public string? Direccion { get; set; }  // Dirección del profesor (opcional)

        // Relación uno a muchos con Grado
        public ICollection<Grado> Grados { get; set; }

        // Relación uno a muchos con Clase
        public ICollection<Clase> Clases { get; set; }

        // Constructor para inicializar las colecciones
        public Profesor()
        {
            Grados = new HashSet<Grado>();
            Clases = new HashSet<Clase>();
        }
    }
}
