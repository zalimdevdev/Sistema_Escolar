using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sis_Escolar.Models
{
    public class ConceptoDePago
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }  // Descripción del concepto de pago

        [Required]
        [Column(TypeName = "decimal(18,2)")]  // Define tipo de dato decimal
        public decimal Monto { get; set; }  // Monto asociado al concepto de pago

        // Relación uno a muchos con Factura
        public ICollection<Factura> Facturas { get; set; }

        // Constructor para inicializar la colección
        public ConceptoDePago()
        {
            Facturas = new HashSet<Factura>();
        }
    }
}
