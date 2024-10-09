using System;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Matricula
    {
        [Key]
        public int Id { get; set; }

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

        [Required]
        public DateTime FechaMatricula { get; set; }  // Fecha de matrícula

    }
}
