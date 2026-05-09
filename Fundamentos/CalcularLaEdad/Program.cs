using System;
class CalcularEdad
{
    static void Main()
    {
        Console.Write("Ingrese su año de nacimiento: ");
        int año = Convert.ToInt32(Console.ReadLine());
        int año_actual = DateTime.Now.Year;
        int edad = año_actual - año;
        Console.WriteLine($"En el {año_actual} usted cumplira {edad} años");
    }
}