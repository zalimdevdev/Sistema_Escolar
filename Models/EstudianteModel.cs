using System.ComponentModel.DataAnnotations.Schema;

namespace Sis_Escolar.Models;

public class Estudiante
{
    public int id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public DateTime Fecha_Nacimiento { get; set; }
    public string? Dirección { get; set; }
    public string? Grado { get; set; }
    public string? Tutor { get; set; }
}