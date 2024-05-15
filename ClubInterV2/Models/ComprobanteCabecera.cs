using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    public class ComprobanteCabecera
    {
        public int ComprobanteCabeceraId { get; set; }
        public byte TipoComprobanteId { get; set; }
        public string ComprobanteCabeceraSerie { get; set; }
        public int ComprobanteCabeceraNumero {  get; set; }
        public byte ComprobanteCabeceraFormaPago { get; set; }
        public string ComprobanteCabeceraNumeroSocio { get; set; }
        public int PersonaId { get; set; }
        public string ComprobanteCabeceraCuenta { get; set; }
        public decimal ComprobanteCabeceraDescuentoGlobal { get; set; }
        public bool ComprobanteCabeceraAnulado { get; set; }
        public byte MonedaId { get; set; }
        public decimal ComprobanteCabeceraMontoTotal { get; set; }
        public decimal ComprobanteCabeceraIGVTotal { get; set; }
        public decimal ComprobanteCabeceraDetraccion { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
