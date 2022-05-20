using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly APIDbContext _context;

        public EmpleadoController(APIDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AddEmpleado")]
        public async Task<IActionResult> AddEmpleado(EmpleadoDTO EmpDto)
        {
            Empleado Emp = new Empleado();
            Emp.Apellido = EmpDto.Apellido;
            Emp.Rut = EmpDto.Rut;
            Emp.Correo = EmpDto.Correo;
            Emp.Nombre = EmpDto.Nombre;
            Emp.Telefono = EmpDto.Telefono;
            Emp.DepartamentoId = EmpDto.DepartamentoId;

            _context.Add(Emp);
            await _context.SaveChangesAsync();

            return Ok();

        }


    }
}
