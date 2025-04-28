using System.ComponentModel.DataAnnotations;

namespace AdopcionPET.Models
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string EstadoAdopcion { get; set; }

        public Adopcion Adopcion { get; set; }
    }
}
