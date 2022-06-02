using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LugarController : Controller
    {
        private readonly AppDbContext _context;
        public LugarController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Lugares = _context.tblLugares.ToList();
            return View(Lugares);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Lugar L)
        {
            if(L == null) return View();

            _context.Add(L);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int LugarId)
        {
            var L = _context.tblLugares.FirstOrDefault(l => l.Id == LugarId);
            if (L == null) return RedirectToAction(nameof(Index));

            return View(L);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Lugar L)
        {
            if (L == null) return RedirectToAction(nameof(Index));

            _context.Update(L);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



    }
}
