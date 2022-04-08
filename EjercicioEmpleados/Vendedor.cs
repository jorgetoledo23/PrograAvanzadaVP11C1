using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    public class Vendedor : Empleado{
        public string Codigo { get; set; }

        public override string marcarIngreso()
        {
            return $"Vendedor marca su ingreso en la tarjeta a las: {DateTime.Now}";
        }

        public override string ToString()
        {
            return base.ToString() + $" Codigo Vendedor: {Codigo}";
        }
        

    }
    public class Reponedor : Empleado{
        public string Credencial { get; set; }

        public override string marcarIngreso()
        {
            //Marca en el reloj con su credencial
            return "";
        }

        public override string ToString()
        {
            return base.ToString() + $" N° Credencial: {Credencial}";
        }
    }
    public class Contratista : Empleado{
        public string Contrato { get; set; }

        public override string marcarIngreso()
        {
            //marca si ingreso firmando el libro
            return "";

        }
        public override string firmarContrato()
        {
            return "Acercarce a Sucursal a firmar Contrato";
        }

        public override string ToString()
        {
            return base.ToString() + $" N° Contrato: {Contrato}";
        }
    }
}
