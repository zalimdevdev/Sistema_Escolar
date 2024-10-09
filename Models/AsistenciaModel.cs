using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sis_Escolar.Models
{
    public class Asistencia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }  // Fecha de la asistencia

        [Required]
        public bool EstaPresente { get; set; }  // Estado de asistencia (presente o ausente)

        // Clave foránea del estudiante
        [Required]
        public int EstudianteId { get; set; }  

        // Relación con Estudiante
        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }

        // Clave foránea de la clase
        [Required]
        public int ClaseId { get; set; }

        // Relación con Clase
        [ForeignKey("ClaseId")]
        public Clase Clase { get; set; }

        // Constructor
        public Asistencia()
        {
            // Aquí se pueden inicializar colecciones si es necesario
        }
    }
}
