namespace ClubInterV2.Models
{
    public class MedioPago
    {
        public int MedioPagoId { get; set; }
        public string MedioPagoNombre { get; set; }
        public bool MedioPagoVisible { get; set; }
        public string MedioPagoNombreCorto { get; set; }
        public ICollection<MetodoPago> MetodosPago { get; set; }
    }
}
