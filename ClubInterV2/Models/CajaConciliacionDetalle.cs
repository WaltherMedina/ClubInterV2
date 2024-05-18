namespace ClubInterV2.Models
{
    public class CajaConciliacionDetalle
    {
        public int CConciDetalleId { get; set; }
        public decimal CConciDetalleTotalDetalle { get; set; }
        public decimal CConciDetalleTotalCabecera { get; set; }
        public decimal CConciDetalleTotalRedondeo { get; set; }
        public decimal CconciDetalleTotalPago { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int CajaTurnoConciliacionId { get; set; }
        public CajaTurnoConciliacion CTurnoConci { get; set; }
        public byte TipoMonedaId { get; set; }
        public TipoMoneda TMoneda { get; set; }
        public int ComprobanteCabeceraId { get; set; }
        public ComprobanteCabecera ComprCabecera { get; set; }
    }
}
