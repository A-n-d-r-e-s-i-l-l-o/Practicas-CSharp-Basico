using System;
class Revisar
{
    static void Main()
    {
        int precio_base = 10;
        int distancia;
        double peso;
        Console.Write("Ingrese el peso del paquete: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Debe ingresar un peso...");
        }
        else if (double.TryParse(input, out peso))
        {
            if(peso<=30 && peso > 0)
            {
                Console.Write("Ingrese la distancia(km): ");
                string? input2 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input2))
                {
                    Console.WriteLine("Debe ingresar una distancia");
                }
                else if(int.TryParse(input2, out distancia))
                {
                    if (distancia > 500 && peso>=15 && peso<=30)
                        precio_base += 15;
                    
                    if(peso<=30 && peso >= 15)
                        precio_base += 8;
                    
                    Console.WriteLine($"El precio de envio es: {precio_base}");
                    
                    
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero entero...");
                }
            }
            else
            {
                Console.WriteLine("Envio rechazado por exceso de peso...");
            }
        }
        else
        {
            Console.WriteLine("Debe ingresar un numero");
        }
    }
}