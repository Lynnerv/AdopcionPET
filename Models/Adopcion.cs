using System.ComponentModel.DataAnnotations;

namespace AdopcionPET.Models
{
    public class Adopcion
    {
        [Key]
        public int AdopcionId { get; set; }

        [Required]
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }

        [Required]
        public int AdoptanteId { get; set; }
        public Adoptante Adoptante { get; set; }

        [Required]
        public string Estado { get; set; } // Finalizada o Pendiente
    }
}
