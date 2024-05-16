namespace ClubInterV2.Models
{
    public class TipoComprobante
    {
        public byte TipoComprobanteId { get; set; }
        public string TipoComprobanteNombre { get; set; }
        public bool TipoComprobanteVisible { get; set; }
        public ComprobanteCabecera ComprCabecera { get; set; }
        public ComprobanteSerie ComprSerie { get; set; }
        public ComprobanteDeuda ComprDeuda { get; set; }
    }
}
