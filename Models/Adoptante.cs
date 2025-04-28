using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdopcionPET.Models
{
    public class Adoptante
    {
        public int AdoptanteId { get; set; }

        
        public string Nombre { get; set; }

        
        public string CorreoElectronico { get; set; }

        // 🔥 Inicializado correctamente
        public ICollection<Adopcion> Adopciones { get; set; } = new List<Adopcion>();
    }
}
