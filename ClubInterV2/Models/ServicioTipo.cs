namespace ClubInterV2.Models
{
    public class ServicioTipo
    {
        public byte ServicioTipoId { get; set; }
        public string ServicioTipoDescripcion { get; set; }
        public ICollection<Servicio> Servicios { get; set; }
    }
}
