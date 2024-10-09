using System;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }

        // Clave foránea que se relaciona con el Estudiante
        [Required]
        public int EstudianteId { get; set; }

        // Relación con Estudiante
        public Estudiante Estudiante { get; set; }

        // Clave foránea que se relaciona con la Materia
        [Required]
        public int MateriaId { get; set; }

        // Relación con Materia
        public Materia Materia { get; set; }

        [Required]
        [Range(0, 100)] // Se asume que la nota es un valor entre 0 y 100
        public decimal Valor { get; set; }  // Valor de la nota

        // Clave foránea que se relaciona con el Periodo
        [Required]
        public int PeriodoId { get; set; }

        // Relación con Periodo
        public Periodo Periodo { get; set; }
    }
}
