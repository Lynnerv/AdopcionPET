using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdopcionPET.Models
{
    public class Adoptante
    {
        [Key]
        public int AdoptanteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido.")]
        public string CorreoElectronico { get; set; }

        // 🔥 Inicializado correctamente
        public ICollection<Adopcion> Adopciones { get; set; } = new List<Adopcion>();
    }
}
