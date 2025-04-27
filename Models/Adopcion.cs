using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdopcionPET.Models
{
    public class Adopcion
    {
        [Key]
        public int AdopcionId { get; set; }

        [ForeignKey("Mascota")]
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }

        [ForeignKey("Adoptante")]
        public int AdoptanteId { get; set; }
        public Adoptante Adoptante { get; set; }

        [Required]
        public string Estado { get; set; } // Finalizada o Pendiente
    }
}