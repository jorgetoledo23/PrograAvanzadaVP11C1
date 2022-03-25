// If
if (true)
{
    Console.WriteLine("If");
}
else if (true)
{
    if (true)
    {
        //Hacer Algo
    }
}
else
{
    Console.WriteLine("");
}

int horaDia = 10;
if (horaDia < 12) Console.WriteLine("Buenos Dias");
string resultado = (horaDia < 12) ? "Buenos Dias":"Buenas Tardes";

bool flag = true;
while (true)
{
    //Da la posibilidad segun la condicion que este bloque
    //se ejecute nunca
    //Hacer Algo
    flag = false;   
    if (true)
    {
        break;
    }
}

do
{
    //Se ejecuta simpre como minimo 1 vez
} while (true);

string mes = "aaaa";
switch (mes)
{
    case "Enero":
        Console.WriteLine("Vacaciones!");
        break;
    case "Febrero":
        Console.WriteLine("Se viene Marzo!!");
    case "Marzo":
        Console.WriteLine("Vuelta a Clases!!");
    default:
        Console.WriteLine("No pasa nada!");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

