using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    [Table("TPago")]
    public class Pago
    {
        public int PagoId { get; set; }
        public int ComprobanteCabeceraId { get; set; }
        public byte MetodoPagoId { get; set; }
        public byte CajaId { get; set; }
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
        public byte TipoMonedaId { get; set; }
        public TipoMoneda TMoneda { get; set; }
    }
}
