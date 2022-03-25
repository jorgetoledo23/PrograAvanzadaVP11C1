using ConsoleAppVP11C1;

Console.WriteLine("Hello, World!");

// Variables
//tipoVariable nombreVariable;
//tipoVaribale nombreVariable = valorVariable;
//int float double string bool char
//Inferir Tipo de Variable (var)
var C1 = new Cliente();
ConsoleColor colorFondo = Console.BackgroundColor;  //Get a la Property
Console.BackgroundColor = colorFondo; // Set a la Property
C1.rutCliente = "17.172.172-3";
C1.nombreCliente = "Juanito";
var nombreCliente = C1.nombreCliente;
Console.WriteLine(C1.ToString());

/* Operadores Matematicos 
 * + Suma
 * - Resta
 * * Multiplicacion 
 * / Division
 * % Mod (Resto de la Division)
 */

/* Operadores Logicos
 * && Operador Logico Y/AND
 * || Operador Logico OR
 * ! Operador Logico NOT */

//Array
string[] arrayCadena;

// Listas // Colecciones
List<string> listaPaises;
listaPaises = new List<string>();
listaPaises.Add("Chile");
string primerPais = listaPaises[0];

List<Cliente> clientes = new List<Cliente>();

foreach (var a in clientes)
{
    Console.WriteLine(a.ToString());
}

clientes.ForEach(a => Console.WriteLine(a.ToString()));

clientes.Add(new Cliente());
//clientes.Remove();
Cliente? clienteBuscado = clientes.Find(c => c.rutCliente == "17.172.927-1");





