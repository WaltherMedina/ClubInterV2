using Microsoft.Identity.Client;

namespace ClubInterV2.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string PersonaDocumento { get; set; }
        public string UbigeoIdNacionalidad { get; set; }
        public string PersonaNombre1 { get; set; }
        public string PersonaNombre2 { get; set; }
        public string PersonaApellido1 { get; set; }
        public string PersonaApellido2 { get; set; }
        public string PersonaSexo { get; set; }
        public DateTime PersonaNacimiento { get; set; }
        public DateTime PersonaFallecimiento { get; set; }
        public bool PersonaEstado { get; set; }
        public byte EstadoCivilId { get; set; }
        public string PersonaFoto { get; set; }
        public bool PersonaActualizadoReniec {  get; set; }
        public DateTime PersonaFechaActualizacionReniec { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public ICollection<ComprobanteDeuda> ComprobantesDeuda { get; set; }
    }
}
