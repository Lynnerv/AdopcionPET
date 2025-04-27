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

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; }

    [Range(0, 100, ErrorMessage = "La edad debe ser positiva.")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "El tipo de mascota es obligatorio.")]
    public string Tipo { get; set; }

    [Required]
    public string EstadoAdopcion { get; set; } // Disponible o Adoptada

    public Adopcion Adopcion { get; set; } // Relación 1 a 1
    }
}