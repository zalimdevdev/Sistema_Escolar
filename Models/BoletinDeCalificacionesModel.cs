using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class BoletinDeCalificaciones
    {
        [Key]
        public int Id { get; set; }

        public DateTime FechaEmision { get; set; }  // Fecha de emisión del boletín

        // Clave foránea del estudiante
        [Required]
        public int EstudianteId { get; set; }

        // Relación con Estudiante
        public Estudiante? Estudiante { get; set; }

        // Relación uno a muchos con Nota
        public ICollection<Nota> Notas { get; set; }

        // Constructor para inicializar las colecciones
        public BoletinDeCalificaciones()
        {
            Notas = new HashSet<Nota>();
        }
    }
}
