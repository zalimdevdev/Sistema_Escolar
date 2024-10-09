using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Clase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }  // Ejemplo: "Matemáticas", "Ciencias"

        // Clave foránea del grado
        [Required]
        public int GradoId { get; set; }

        // Relación con Grado
        public Grado Grado { get; set; }

        // Relación uno a muchos con Asistencia
        public ICollection<Asistencia> Asistencias { get; set; }

        // Relación uno a muchos con Nota
        public ICollection<Nota> Notas { get; set; }

        // Constructor para inicializar las colecciones
        public Clase()
        {
            Asistencias = new HashSet<Asistencia>();
            Notas = new HashSet<Nota>();
        }
    }
}
