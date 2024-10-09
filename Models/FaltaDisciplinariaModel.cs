using System;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class FaltaDisciplinaria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }  // Descripción de la falta disciplinaria

        [Required]
        public DateTime Fecha { get; set; }  // Fecha en que se registró la falta

        // Clave foránea que se relaciona con el Estudiante
        [Required]
        public int EstudianteId { get; set; }

        // Relación con Estudiante
        public Estudiante Estudiante { get; set; }

        // Clave foránea que se relaciona con el Grado
        [Required]
        public int GradoId { get; set; }

        // Relación con Grado
        public Grado Grado { get; set; }
    }
}
