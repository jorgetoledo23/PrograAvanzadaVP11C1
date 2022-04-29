using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Model
{
    public class Empleado
    {
        public int Id { get; set; }
        //[Key]
        public string Rut { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }
        //public DateTime FechaNacimiento { get; set; }
    }
}
