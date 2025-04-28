using System.ComponentModel.DataAnnotations;

namespace AdopcionPET.Models
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El estado de adopción es obligatorio.")]
        public string EstadoAdopcion { get; set; }

        public Adopcion? Adopcion { get; set; } // <-- CORREGIDO
    }
}
