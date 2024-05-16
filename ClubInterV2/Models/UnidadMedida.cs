namespace ClubInterV2.Models
{
    public class UnidadMedida
    {
        public byte UnidadMedidaId { get; set; }
        public string UnidadMedidaDescripcion { get; set; }
        public string UnidadMedidaCodigo { get; set; }
        public bool UnidadMedidaVisible { get; set; }
        public ICollection<Servicio> Servicios { get; set; }
    }
}
