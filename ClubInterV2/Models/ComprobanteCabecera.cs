using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    public class ComprobanteCabecera
    {
        public int ComprobanteCabeceraId { get; set; }
        public string ComprobanteCabeceraSerie { get; set; }
        public int ComprobanteCabeceraNumero { get; set; }
        public byte ComprobanteCabeceraFormaPago { get; set; }
        public string ComprobanteCabeceraNumeroSocio { get; set; }
        public string ComprobanteCabeceraCuenta { get; set; }
        public decimal ComprobanteCabeceraDescuentoGlobal { get; set; }
        public bool ComprobanteCabeceraAnulado { get; set; }
        public decimal ComprobanteCabeceraMontoTotal { get; set; }
        public decimal ComprobanteCabeceraIGVTotal { get; set; }
        public decimal ComprobanteCabeceraDetraccion { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public byte TipoComprobanteId { get; set; }
        public TipoComprobante TComprobante { get; set; }
        public int PersonaId { get; set; }
        public Persona Perso { get; set; }
        public byte TipoMonedaId { get; set; }
        public TipoMoneda TMoneda { get; set; }
        public ICollection<ComprobanteDetalle> ComprobantesDetalle { get; set; }
    }
}
