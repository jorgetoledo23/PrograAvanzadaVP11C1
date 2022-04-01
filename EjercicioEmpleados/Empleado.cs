using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    public abstract class Empleado
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"Rut: {Rut}, Nombre: {Nombre} {Apellido}";
        }
        public abstract void marcarIngreso();
        public virtual string firmarContrato()
        {
            return "Firma contrato DIGITAL";
        }
    }
}
