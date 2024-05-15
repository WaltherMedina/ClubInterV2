namespace ClubInterV2.Models
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string ServicioDescripcion { get; set; }
        public string ServicioAbreviatura { get; set; }
        public bool ServicioAfectoIGV { get; set; }
        public string ServicioCuentaPasada { get; set; }
        public string ServicioCuentaActual { get; set; }
        public string ServicioCuentaFutura { get; set; }
        public string ServicioCuentaCosto { get; set; }
        public bool ServicioEstado { get; set; }
        public DateTime ServicioFechaInicio { get; set; }
        public DateTime ServicioFechaFin { get; set; }
        public bool ServicioVigenciaContinua { get; set; }
        public decimal ServicioTarifaVigente { get; set; }
        public bool ServicioRestringido { get; set; }
        public byte ServicioCantidadPaquete { get; set; }
        public bool ServicioDinamico { get; set; }
        public string ServicioMensaje { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte TipoAfectacionId { get; set; }
        public byte UndadMedidaId { get; set; }
        public byte ServicioTipoId { get; set; }

    }
}
