
namespace AdopcionPET.Models
{
    public class Mascota
    {
       
        public int MascotaId { get; set; }

      
        public string Nombre { get; set; }

        
        public int Edad { get; set; }

     
        public string Tipo { get; set; }

        
        public string EstadoAdopcion { get; set; }

        public Adopcion Adopcion { get; set; }
    }
}
