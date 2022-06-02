using API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Free")]
    public class DepartamentoController : ControllerBase
    {
        private readonly APIDbContext _context;
        public DepartamentoController(APIDbContext context)
        {
            _context = context;
        }

        [Route("GetAllDepartments")]
        [HttpGet]
        [Authorize(Roles = "Pro")]
        public ActionResult<List<Departamento>> GetAllDepartments()
        {
            var AllDepartments = _context.Departamentos.ToList();
            return Ok(AllDepartments);
        }

        [Route("AddDepartment")]
        [HttpPost]
        public ActionResult AddDepartment(Departamento Dpto)
        {
            _context.Departamentos.Add(Dpto);
            _context.SaveChanges();
            return Ok();
        }

        [Route("UptDepartment")]
        [HttpPut]
        public ActionResult UptDepartment(Departamento Dpto)
        {
            _context.Departamentos.Update(Dpto);
            _context.SaveChanges();
            return Ok();
        }

        [Route("DelDepartment")]
        [HttpDelete]
        public ActionResult DelDepartment(int id)
        {
            var departamento = _context.Departamentos.Find(id);
            _context.Departamentos.Remove(departamento);
            _context.SaveChanges();
            return Ok();
        }

        [Route("FindDepartmentById")]
        [HttpGet]
        public ActionResult FinDepartmentById(int id)
        {
            var departamento = _context.Departamentos.Find(id);
            if (departamento == null) return BadRequest();
            return Ok(departamento);
        }


    }
}
