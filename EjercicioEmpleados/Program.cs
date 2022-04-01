/* Crear una APP en la que se puedan ingresar x cantidad de Empleados de una Empresa,
 * de los cuales se pide Rut, Nombre, Apellido y Sueldo
 * Hay 3 Tipos de Empleados Vendores, Contratistas y Reponedores
 * La diferencia esta en que: 
 * Los Vendedores tienen un Codigo de Vendedor
 * Los Contratistas tienen un N° de Contrato
 * Y los Reponedores tienen un N° de Credencial
 * Una vez ingresados se debe mostrar el listado de todos ellos de manera clara.
 * 
 */
using EjercicioEmpleados;

List<Empleado> listaEmpleados = new List<Empleado>();
string opcion;

do
{
    MostrarMenu();
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            //Ingreso de Empleados
            Console.WriteLine("Ingresa los Datos Solicitados: ");
            
            Console.Write("Rut: ");
            string rut = Console.ReadLine();

            Console.Write("Nombre: ");
            string nom = Console.ReadLine();

            Console.Write("Apellido: ");
            string ape = Console.ReadLine();

            Console.Write("Correo: ");
            string correo = Console.ReadLine();

            Console.Write("Telefono: ");
            string tel = Console.ReadLine();

            string opcionTipo = MostrarMenuTipo();
            string codigo;
            switch (opcionTipo)
            {
                case "1":
                    //Vendedor
                    Console.WriteLine("Ingrese Codigo de Vendedor: ");
                    codigo = Console.ReadLine();
                    Vendedor V = new Vendedor()
                    {
                        Rut = rut,
                        Nombre = nom,
                        Apellido = ape,
                        Correo = correo,
                        Telefono = tel,
                        Codigo = codigo
                    };
                    listaEmpleados.Add(V);
                    break;

                case "2":
                    //Reponedor
                    Console.WriteLine("Ingrese N° Credencial: ");
                    codigo = Console.ReadLine();
                    Reponedor R = new Reponedor()
                    {
                        Rut = rut,
                        Nombre = nom,
                        Apellido = ape,
                        Correo = correo,
                        Telefono = tel,
                        Credencial = codigo
                    };
                    listaEmpleados.Add(R);
                    break;
                case "3":
                    //Contratista
                    Console.WriteLine("Ingrese N° Contrato: ");
                    codigo = Console.ReadLine();
                    Contratista C = new Contratista()
                    {
                        Rut = rut,
                        Nombre = nom,
                        Apellido = ape,
                        Correo = correo,
                        Telefono = tel,
                        Contrato = codigo
                    };
                    listaEmpleados.Add(C);
                    break;
            }



            Console.WriteLine
                ("Empleado agregado con Exito! Presione una Tecla para Continuar...");
            Console.ReadLine();
            break;

        case "2":
            //Mostrar Empleados
            opcion = MostrarMenuTipo2();

            switch (opcion)
            {
                case "1":
                    //Mostrar Vendedores
                    foreach (var E in listaEmpleados)
                    {
                        if (E.GetType().ToString().Equals("EjercicioEmpleados.Vendedor"))
                        {
                            Console.WriteLine(E.ToString());
                        }  
                    }
                    break;
                case "2":
                    //Mostrar Reponedores
                    foreach (var E in listaEmpleados)
                    {
                        if (E.GetType().ToString().Equals("EjercicioEmpleados.Reponedor"))
                        {
                            Console.WriteLine(E.ToString());
                        }
                    }
                    break;
                case "3":
                    //Mostrar Contratistas
                    foreach (var E in listaEmpleados)
                    {
                        if (E.GetType().ToString().Equals("EjercicioEmpleados.Contratista"))
                        {
                            Console.WriteLine(E.ToString());
                        }
                    }
                    break;
                case "4":
                    //Mostrar Todos Empleados
                    foreach (var E in listaEmpleados)
                    {

                        Console.WriteLine(E.ToString());

                    }
                    break;
                
            }
            Console.WriteLine("Empleados Listados. Presione Enter para Continuar...");
            Console.ReadLine();
            break;
    }



} while (opcion != "0");









void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("Seleccione una Opcion: ");
    Console.WriteLine("1-Ingreso de Empleados ");
    Console.WriteLine("2-Listar Empleados ");
    Console.WriteLine("0-Salir del Sistema ");
}

string MostrarMenuTipo()
{
    string opcionTipo;
    do
    {
        Console.Clear();
        Console.WriteLine("Seleccione un Tipo de Empleado: ");
        Console.WriteLine("1-Vendedor ");
        Console.WriteLine("2-Reponedor ");
        Console.WriteLine("3-Contratista");
        opcionTipo = Console.ReadLine();    
    } while (opcionTipo != "1" && opcionTipo != "2" && opcionTipo!="3" );
    return opcionTipo;
}

string MostrarMenuTipo2()
{
    string opcionTipo;
    do
    {
        Console.Clear();
        Console.WriteLine("Seleccione un Tipo de Empleado: ");
        Console.WriteLine("1-Mostrar Vendedores ");
        Console.WriteLine("2-Mostrar Reponedores ");
        Console.WriteLine("3-Mostrar Contratistas");
        Console.WriteLine("4-Mostrar Todos");

        opcionTipo = Console.ReadLine();
    } while (opcionTipo != "1" && opcionTipo != "2" && opcionTipo != "3" && opcionTipo != "4");
    return opcionTipo;
}






