// See https://aka.ms/new-console-template for more information

/*App que reciba desde el usuario un numero de MAX 3 digitos
 * y lo descomponga en Centenas, Decenas y Unidades */
int num;
do
{
    Console.Clear();
    Console.Write("Ingresa un Numero de MAX 3 Digitos: ");
    num = Convert.ToInt32(Console.ReadLine());
} while (num.ToString().Length!= 3);

Console.WriteLine($"Numero de Centenas: {num/100}");
Console.WriteLine($"Numero de Decenas: {num%100/10}");
Console.WriteLine($"Numero de Unidades: {num%10}");
