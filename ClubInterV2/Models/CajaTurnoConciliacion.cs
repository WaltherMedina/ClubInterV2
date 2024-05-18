namespace ClubInterV2.Models
{
    public class CajaTurnoConciliacion
    {
        public int CTurnoConciId { get; set; }
        public DateTime CTurnoConciApertura { get; set; }
        public decimal CTurnoConciMontoInicial { get; set; }
        public decimal CTurnoConciMontoFinal { get; set; }
        public decimal CTurnoConciDescuadre { get; set; }
        public bool CTurnoConciCerrado { get; set; }
        public DateTime CTurnoConciCierre { get; set; }
        public bool CTurnoConciEstado { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public byte CajaId { get; set; }
        public Caja CajaEnlace { get; set; }
        public int TurnoCajaId { get; set; }
        public TurnoCaja TCaja { get; set; }
        public int UsuarioId { get; set; }
        public Usuario User { get; set; }
        public byte TipoMoneda { get; set; }
        public TipoMoneda TMoneda { get; set; }
    }
}
