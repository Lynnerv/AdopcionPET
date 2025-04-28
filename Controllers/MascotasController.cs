using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdopcionPET.Data;
using AdopcionPET.Models;
using System;

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
                try
                {
                    _context.Mascotas.Add(mascota);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "🐾 ¡Mascota registrada exitosamente!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error al guardar la mascota: {ex.Message}");
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al guardar la mascota. Inténtalo de nuevo.");
                }
            }
            else
            {
                _logger.LogWarning("⚠️ ModelState inválido al intentar registrar una mascota.");
            }

            return View(mascota);
        }

        // GET: Mascotas
        public IActionResult Index()
        {
            var mascotas = _context.Mascotas.ToList();
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            return View(mascotas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
