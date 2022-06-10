using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Controllers
{
    [Authorize(Roles = "SuperAdministrador, Administrador")]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Usuarios.ToList());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioRegistroViewModel Uvm)
        {
            if (ModelState.IsValid)
            {
                var U = _context.Usuarios.FirstOrDefault(u => u.Username == Uvm.Username || u.Email == Uvm.Email);
                if (U == null)
                {
                    Usuario Us = new Usuario();
                    Us.Name = Uvm.Name;
                    Us.Email = Uvm.Email;
                    Us.Rol = Uvm.Rol;
                    Us.Username = Uvm.Username;

                    CreatePasswordHash(Uvm.Password, out byte[] Hash, out byte[] Salt);

                    Us.PasswordSalt = Salt;
                    Us.PasswordHash = Hash;

                    _context.Add(Us);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //Ya existe el mismo Username o Email
                    ModelState.AddModelError(String.Empty, "Username o Correo ya Existen!");
                    return View(Uvm);
                }
                
            }
            else
            {
                return View(Uvm);
            }
            
        }
        public async Task<IActionResult> Edit(Guid UserId)
        {
            var U = _context.Usuarios.FirstOrDefault(u => u.Id == UserId);
            if (U == null) return NotFound();
            UsuarioRegistroViewModel Uvm = new UsuarioRegistroViewModel()
            {
                Email = U.Email,
                Name = U.Name,
                Id = U.Id,
                Rol = U.Rol,
                Username = U.Username
            };
            return View(Uvm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UsuarioRegistroViewModel Uvm)
        {
            if (ModelState.IsValid)
            {
                var Usuarios = _context.Usuarios.Where(u => u.Username == Uvm.Username || u.Email == Uvm.Email).ToList();
                if (Usuarios.Count >= 1)
                {
                    var U = _context.Usuarios.FirstOrDefault(u => u.Id == Uvm.Id);
                    U.Name = Uvm.Name;
                    U.Email = Uvm.Email;
                    U.Rol = Uvm.Rol;
                    U.Username = Uvm.Username;
                    U.Id = Uvm.Id;

                    CreatePasswordHash(Uvm.Password, out byte[] Hash, out byte[] Salt);

                    U.PasswordSalt = Salt;
                    U.PasswordHash = Hash;

                    _context.Update(U);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //Ya existe el mismo Username o Email
                    ModelState.AddModelError(String.Empty, "Username o Correo ya Existen!");
                    return View(Uvm);
                }

            }
            else
            {
                return View(Uvm);
            }

        }

        public async Task<IActionResult> Delete(Guid UserId)
        {
            var U = _context.Usuarios.FirstOrDefault(u=> u.Id == UserId);
            if(U == null) return NotFound();
            _context.Remove(U);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
