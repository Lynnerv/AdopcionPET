using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdopcionPET.Data;
using AdopcionPET.Models;

namespace AdopcionPET.Controllers
{
    public class MascotasController : Controller
    {
        private readonly ILogger<MascotasController> _logger;
        private readonly ApplicationDbContext _context;

        public MascotasController(ILogger<MascotasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Mascotas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mascotas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                _context.Mascotas.Add(mascota);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(mascota);
        }

        // GET: Mascotas
        public IActionResult Index()
        {
            var mascotas = _context.Mascotas.ToList();
            return View(mascotas);
        }

        // (Opcional) Acción de Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
