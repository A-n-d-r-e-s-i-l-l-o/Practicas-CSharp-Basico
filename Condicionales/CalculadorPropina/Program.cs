using System;
class CalculadoraPropinas
{
    static void Main()
    {
        double monto,propina;
        Console.Write("Ingrese el monto a pagar: ");
        string? input1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input1))
        {
            Console.WriteLine("Debe ingresar un numero...");    
        }
        else if (double.TryParse(input1, out monto))
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto no puede ser 0 o negativo");
            }
            else
            {
                Console.Write("Ingrese la propina que dejara: ");
                string? input2 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input2))
                {
                    Console.WriteLine("Debe ingresar un numero...");
                }
                else if (double.TryParse(input2,out propina))
                {
                    if (propina < 0)
                    {
                        Console.WriteLine("La propina no puede ser negativa");
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------");
                        Console.Write("Total a pagar: ");
                        Console.Write(propina+monto);
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            }
        }
        else
        {
            Console.WriteLine("Debe ingresar un valor valido...");
        }
    }
}
