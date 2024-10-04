
namespace Sis_Escolar.Models;

public class Calificacion
{
    public int id { get; set; }
    public string? Estudiante { get; set; }
    public string? Asignatura { get; set; }
    public DateTime Fecha_Not { get; set; }
    public int? Nota { get; set; }

}