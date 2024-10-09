using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Periodo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }  // Ejemplo: "Primer Parcial", "Segundo Semestre"

        [Required]
        public DateTime FechaInicio { get; set; }  // Fecha de inicio del periodo

        [Required]
        public DateTime FechaFin { get; set; }  // Fecha de fin del periodo

        // Clave foránea del año escolar
        [Required]
        public int AñoEscolarId { get; set; }

        // Relación con Año Escolar
        public AñoEscolar AñoEscolar { get; set; }

        // Relación uno a muchos con BoletínDeCalificaciones
        public ICollection<BoletinDeCalificaciones> BoletinesDeCalificaciones { get; set; }

        // Constructor para inicializar las colecciones
        public Periodo()
        {
            BoletinesDeCalificaciones = new HashSet<BoletinDeCalificaciones>();
        }
    }
}
