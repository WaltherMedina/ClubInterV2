namespace ClubInterV2.Models
{
    public class ComprobanteSerie
    {
        public byte ComprobanteSerieId { get; set; }
        public byte TipoComprobanteId { get; set; }
        public string SerieNumero { get; set; }
        public string SerieNombre { get; set; }
        public bool Serieestado { get; set; }
    }
}
