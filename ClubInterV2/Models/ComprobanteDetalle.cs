using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    public class ComprobanteDetalle
    {
        public int ComprobanteDetalleId { get; set; }
        public int ComprobanteDetalleItem { get; set; }
        public int ComprobanteDetalleCantidad { get; set; }
        public string ComprobanteDetalleCuenta { get; set; }
        public string ComprobanteDetalleCentroCosto { get; set; }
        public string ComprobanteDetalleGlosa { get; set; }
        public DateTime ComprobanteDetalleVencimiento { get; set; }
        public decimal ComprobanteDetallePrecio { get; set; }
        public decimal ComprobanteDetalleDescuento { get; set; }
        public decimal ComprobanteDetalleIGV { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
        public byte TipoMonedaId { get; set; }
        public TipoMoneda TMoneda { get; set; }
        public int ComprobanteDeudaId { get; set; }
        public ComprobanteDeuda ComprDeuda { get; set; }
        public int ComprobanteCabeceraId { get; set; }
        public ComprobanteCabecera ComprCabecera { get; set; }
    }
}
