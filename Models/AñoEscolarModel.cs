using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class AñoEscolar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AñoInicio { get; set; }  // Año de inicio (ej. 2023)

        [Required]
        public int AñoFin { get; set; }  // Año de fin (ej. 2024)

        [Required]
        [StringLength(10)]
        public string? Estado { get; set; }  // Estado del año escolar (Activo/Cerrado)

        // Relación uno a muchos con Periodo
        public ICollection<Periodo> Periodos { get; set; }

        // Relación uno a muchos con Grado
        public ICollection<Grado> Grados { get; set; }

        // Constructor para inicializar las colecciones
        public AñoEscolar()
        {
            Periodos = new HashSet<Periodo>();
            Grados = new HashSet<Grado>();
        }
    }
}
