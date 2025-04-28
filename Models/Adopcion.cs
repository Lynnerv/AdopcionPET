
namespace AdopcionPET.Models
{
    public class Adopcion
    {
        public int AdopcionId { get; set; }

        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }

        public int AdoptanteId { get; set; }
        public Adoptante Adoptante { get; set; }
        public string Estado { get; set; } // Finalizada o Pendiente
    }
}
