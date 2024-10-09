using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sis_Escolar.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required]
        public DateTime Fecha_Nacimiento { get; set; }

        [StringLength(200)]
        public string Dirección { get; set; }

        [Required]
        public int GradoId { get; set; }  // Clave foránea

        // Relación con Grado
        [ForeignKey("GradoId")]
        public Grado Grado { get; set; }

        // Relación uno a muchos con Matrícula
        public ICollection<Matricula> Matriculas { get; set; }

        // Relación uno a muchos con Asistencia
        public ICollection<Asistencia> Asistencias { get; set; }

        // Relación uno a muchos con Boletín de Calificaciones
        public ICollection<BoletinDeCalificaciones> Boletines { get; set; }

        // Relación uno a muchos con Nota
        public ICollection<Nota> Notas { get; set; }

        // Relación uno a muchos con Falta Disciplinaria
        public ICollection<FaltaDisciplinaria> FaltasDisciplinarias { get; set; }

        // Constructor para inicializar las colecciones
        public Estudiante()
        {
            Matriculas = new HashSet<Matricula>();
            Asistencias = new HashSet<Asistencia>();
            Boletines = new HashSet<BoletinDeCalificaciones>();
            Notas = new HashSet<Nota>();
            FaltasDisciplinarias = new HashSet<FaltaDisciplinaria>();
        }
    }
}
