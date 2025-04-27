using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdopcionPET.Data;
using AdopcionPET.Models;

namespace AdopcionPET.Controllers
{
    public class AdopcionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdopcionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Adopciones/Assign
        public IActionResult Assign()
        {
            ViewBag.Mascotas = _context.Mascotas
                .Where(m => m.EstadoAdopcion == "Disponible")
                .ToList();
            ViewBag.Adoptantes = _context.Adoptantes.ToList();
            return View();
        }

        // POST: Adopciones/Assign
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Assign(int mascotaId, int adoptanteId)
        {
            var mascota = _context.Mascotas.Find(mascotaId);
            if (mascota != null && mascota.EstadoAdopcion == "Disponible")
            {
                var adopcion = new Adopcion
                {
                    MascotaId = mascotaId,
                    AdoptanteId = adoptanteId,
                    Estado = "Finalizada"
                };
                mascota.EstadoAdopcion = "Adoptada";

                _context.Adopciones.Add(adopcion);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(List));
        }

        // GET: Adopciones/List
        public IActionResult List()
        {
            var adopciones = _context.Adopciones
                .Include(a => a.Mascota)
                .Include(a => a.Adoptante)
                .ToList();
            return View(adopciones);
        }
    }
}
