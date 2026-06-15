using System;
using System.Diagnostics;

Console.Write("Ingrese el monto: ");
double monto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(@"-------------- Convertir monedas -----------------
1- Convertir Dolares A Euro
2- Convertir Euros A Dolares
3- Salir");
Console.Write("Ingresa una opcion: ");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 1:
        Console.WriteLine($"Su monto es igual a {ConvertirDolaresAEuro(monto):F2} euros");
        break;
    case 2:
        Console.WriteLine($"Su monto es igual a {ConvertirEurosADolares(monto):F2} dolares");
        break;
    case 3:
        Console.WriteLine("Fin del programa");
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}

double ConvertirDolaresAEuro(double monto)
{
    return monto*0.92;
}
double ConvertirEurosADolares(double monto)
{
    return monto*1.09;
}
