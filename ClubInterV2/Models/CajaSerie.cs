namespace ClubInterV2.Models
{
    public class CajaSerie
    {
        public int CajaSerieId { get; set; }
        public bool CajaSerieEstado { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public byte CajaId { get; set; }
        public Caja CajaEnlace { get; set; }
        public byte ComprobanteSerieId { get; set; }
        public ComprobanteSerie ComprSerie { get; set; }
    }
}
