namespace ClubInterV2.Models
{
    public class TipoMoneda
    {
        public byte TipoMonedaId { get; set; }
        public string TipoMonedaNombre { get; set; }
        public string TipoMonedaSimbolo { get; set; }
        public int TipoMonedaNumero { get; set; }
        public string TipoMonedaCodigo { get; set; }
        public ICollection<Pago> Pagos { get; set; }
        public ICollection<ComprobanteDetalle> ComprobantesDetalle { get; set; }
        public ICollection<ComprobanteCabecera> ComprobantesCabecera { get; set; }
    }
}
