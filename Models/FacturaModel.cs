using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sis_Escolar.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        // Clave foránea que se relaciona con el Concepto de Pago
        [Required]
        public int ConceptoPagoId { get; set; }

        // Relación con Concepto de Pago
        [ForeignKey("ConceptoPagoId")] // Asegúrate de usar el nombre correcto aquí
        public ConceptoDePago ConceptoPago { get; set; }

        [Required]
        public DateTime FechaEmision { get; set; }  // Fecha de emisión de la factura

        [Required]
        [Column(TypeName = "decimal(18,2)")]  // Define tipo de dato decimal
        public decimal MontoTotal { get; set; }  // Monto total de la factura

        [Required]
        [StringLength(10)]
        public string Estado { get; set; }  // Estado de la factura (Pagada/Pendiente)
    }
}
