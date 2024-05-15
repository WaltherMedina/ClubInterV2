using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    public class ComprobanteDeuda
    {
        public int ComprobanteDeudaId { get; set; }
        
        public string ComprobanteDeudaSerie { get; set; }
        public int ComprobanteDeudaNumero { get; set; }
        public bool ComprobanteDeudaDebe { get; set; }
        public bool ComprobanteDeudaAnulado { get; set; }
        public int ComprobanteDeudaCantidad { get; set; }
        public string ComprobanteDeudaCuenta { get; set; }
        public string ComprobanteDeudaCentroCosto { get; set; }
        public string ComprobanteDeudaGlosa { get; set; }
        public DateTime ComprobanteDeudaPeriodo { get; set; }
        public DateTime ComprobanteDeudaVencimiento { get; set; }
        public decimal ComprobanteDeudaPrecio { get; set; }
        public byte MonedaId { get; set; }
        public decimal ComprobanteDeudaDescuento { get; set; }
        public decimal ComprobanteDeudaIGV { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
        public byte TipoComprobanteId { get; set; }
        public int PersonaId { get; set; }
        public Persona Perso { get; set; }
        public int ServicioId { get; set; }
        public Servicio Servi { get; set; }
        public ComprobanteDetalle comprobanteDetalle { get; set; }
        
    }
}
