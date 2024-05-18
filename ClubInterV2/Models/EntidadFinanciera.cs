namespace ClubInterV2.Models
{
    public class EntidadFinanciera
    {
        public byte EntidadFinancieraId { get; set; }
        public string EntidadFinancieraNombre { get; set; }
        public bool EntidadFinancieraVisible { get; set; }
        public string EntidadFinancieraNombreCorto { get; set; }
        public ICollection<MetodoPago> MetodosPago { get; set; }
    }
}
