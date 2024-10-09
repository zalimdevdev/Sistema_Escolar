using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class Grado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }  // Ejemplo: "Primero", "Segundo"

        [Required]
        public string Seccion { get; set; }  // Ejemplo: "A", "B"

        // Clave foránea del profesor guía
        [Required]
        public int ProfesorId { get; set; }  

        // Relación con Profesor
        public Profesor Profesor { get; set; }

        // Relación uno a muchos con Estudiante
        public ICollection<Estudiante> Estudiantes { get; set; }

        // Relación uno a muchos con Aula
        public ICollection<Aula> Aulas { get; set; }

        // Constructor para inicializar las colecciones
        public Grado()
        {
            Estudiantes = new HashSet<Estudiante>();
            Aulas = new HashSet<Aula>();
        }
    }
}
