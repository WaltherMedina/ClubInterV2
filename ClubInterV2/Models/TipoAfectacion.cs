namespace ClubInterV2.Models
{
    public class TipoAfectacion
    {
        public byte TipoAfectacionId { get; set; }
        public string TipoAfectacionDescripcion { get; set; }
        public bool TipoAfectacionVisible { get; set; }
        public ICollection<Servicio> Servi { get; set; }
    }
}
