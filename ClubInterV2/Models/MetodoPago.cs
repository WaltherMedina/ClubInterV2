namespace ClubInterV2.Models
{
    public class MetodoPago
    {
        public byte MetodoPagoId { get; set; }
        public string MetodoPagoCodigo { get; set; }
        public string MetodoPagoDescripcion { get; set; }
        public string MetodoPagoCuenta { get; set; }
        public bool MetodoPagoVisible { get; set; }
        public int MedioPagoId { get; set; }
        public MedioPago MPago { get; set; }
        public byte EntidadFinancieraId { get; set; }
        public EntidadFinanciera EFinanciera { get; set; }
    }
}
