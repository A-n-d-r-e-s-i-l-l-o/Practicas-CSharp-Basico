using System;
class AdivinaNumero
{
    static void Main()
    {
        Random random = new Random();
        int NumeroAleatorio = random.Next(1,100);
        int Contador = 0;
        int Numero = 0;
        Console.WriteLine("Adivina el numero del 1 al 100");
        do
        {
            Console.Write("Ingrese un numero: ");
            string? Input = Console.ReadLine();
            Contador ++;
            if (string.IsNullOrWhiteSpace(Input))
            {
                Console.WriteLine("Debe escribir un numero...");
            }
            else if (int.TryParse(Input, out Numero))
            {
                if (Numero > NumeroAleatorio)
                {
                    Console.WriteLine("EL numero es mas bajo");
                }
                else if (Numero < NumeroAleatorio)
                {
                    Console.WriteLine("El numero es mas alto");
                }
                else
                {
                    Console.WriteLine($"Felicidades por completar el juego en {Contador} intentos");
                }
            }
            else
            {
                Console.WriteLine("Debe escribir un numero...");
            }
        }
        while(Numero != NumeroAleatorio);
    }
}