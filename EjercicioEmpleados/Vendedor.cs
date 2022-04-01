using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    public class Vendedor : Empleado{
        public string Codigo { get; set; }

        public override void marcarIngreso()
        {
            //Marca entrada con su codigo de vendedor
        }

        public override string ToString()
        {
            return base.ToString() + $" Codigo Vendedor: {Codigo}";
        }
        

    }
    public class Reponedor : Empleado{
        public string Credencial { get; set; }

        public override void marcarIngreso()
        {
            //Marca en el reloj con su credencial
        }

        public override string ToString()
        {
            return base.ToString() + $" N° Credencial: {Credencial}";
        }
    }
    public class Contratista : Empleado{
        public string Contrato { get; set; }

        public override void marcarIngreso()
        {
           //marca si ingreso firmando el libro
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
