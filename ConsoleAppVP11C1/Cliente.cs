using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVP11C1
{
    public class Cliente
    {
        public string rutCliente { get; set; }
        public string nombreCliente { get; set; }


        //Sobreescribir Metodo ToString() Clase Object
        public override string ToString()
        {
            //String Interpolation
            return $"Nombre Cliente: {nombreCliente}, Rut: {rutCliente}";
            //Concatenar
            //return "Nombre Cliente: " + nombreCliente + ", Rut: " + rutCliente;
            //String Formatting
            //Console.WriteLine("Nombre Cliente: {0}, Rut: {1}", nombreCliente, rutCliente);
        }

    }
}
