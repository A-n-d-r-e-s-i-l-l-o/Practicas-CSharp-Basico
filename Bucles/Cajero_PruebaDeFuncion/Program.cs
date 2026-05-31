using System;
class Cajero
{
    static void Main()
    {
        double saldo = 100;
        double retiro;
        bool verificar = false;
        while (verificar == false)
        {
            Console.Clear();
            Console.WriteLine($"Su saldo actual es: {(saldo):C2}");
            Console.Write("Ingrese el monto a retirar: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No puede dejar las casillas en blanco");
                Console.WriteLine("Ingrese una tecla para continuar...");
                Console.ReadKey();
            }
            else if(double.TryParse(input, out retiro))
            {
                if(retiro<=saldo && retiro > 0)
                {
                    Console.WriteLine("Proceso exitoso");
                    saldo -= retiro;
                    Console.WriteLine($"Su saldo restante es: {(saldo):C2}");
                    verificar = true;
                }
                else
                {
                    Console.WriteLine("El monto a retirar no debe ser mayor a su saldo ni negativo");
                    Console.WriteLine("Ingrese una tecla para continuar...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero");
                Console.WriteLine("Ingrese una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}