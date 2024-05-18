namespace ClubInterV2.Models
{
    public class Caja
    {
        public byte CajaId { get; set; }
        public string CajaHost { get; set; }
        public string CajaIP { get; set; }
        public string CajaMAC { get; set; }
        public bool CajaEstado { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public ICollection<CajaTurnoConciliacion> CTrunoConcis { get; set; }
        public ICollection<CajaSerie> CSeries { get; set; }

    }
}
