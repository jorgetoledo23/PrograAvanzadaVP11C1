using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EventosController : Controller
    {
        private readonly AppDbContext _context;
        public EventosController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Eventos = _context.tblEventos
                .Include(e => e.Categoria)
                .Include(e => e.Lugar)
                .ToList();
            return View(Eventos);
        }

        public async Task<IActionResult> Create()
        {
            ViewData["Lug"] = new SelectList(_context.tblLugares.ToList(), "Id", "Name");
            ViewData["Cat"] = new SelectList(_context.tblCategorias.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Evento E)
        {
            if (ModelState.IsValid)
            {
                E.Estado = "Creado Pendiente";
                _context.Add(E);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(E);
            }
        }


        public async Task<IActionResult> Edit(Guid EventoId)
        {
            ViewData["Lug"] = new SelectList(_context.tblLugares.ToList(), "Id", "Name");
            ViewData["Cat"] = new SelectList(_context.tblCategorias.ToList(), "Id", "Name");
            var Evento = _context.tblEventos.FirstOrDefault(e => e.Id == EventoId);
            if (Evento == null) return NotFound();
            return View(Evento);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Evento E)
        {
            if (ModelState.IsValid)
            {
                _context.Update(E);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(E);
            }
        }
    }
}
