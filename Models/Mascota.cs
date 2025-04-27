using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        // 🔥 AGREGAR ESTA LÍNEA
        public Adopcion Adopcion { get; set; }
    }
}