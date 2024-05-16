using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    [Table("TPago")]
    public class Pago
    {
        [Key]
        public int PagoId { get; set; }
        [Required]
        public int ComprobanteCabeceraId { get; set; }
        [Required]
        public byte MetodoPagoId { get; set; }
        [Required]
        public byte CajaId { get; set; }
        [Required]
        public byte MonedaId { get; set; }
        public string PagoCuenta { get; set; }
        public decimal ComprobanteCabeceraMontoTotal { get; set; }
        public decimal PagoMontoRedondeo { get; set; }
        public decimal PagoMontoRecibido { get; set; }
        public decimal PagoMontoVuelto { get; set; }
        public decimal PagoMontoPagado { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
