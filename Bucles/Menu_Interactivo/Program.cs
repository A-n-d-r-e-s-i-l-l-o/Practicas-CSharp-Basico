using System;
class MenuInteractivo
{
    static void Main()
    {
        Console.Write("Ingrese su nombre de usuario: ");
        string? nombre = Console.ReadLine();
        string? opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("------------------ MENU INTERACTIVO ------------------");
            Console.WriteLine($"Usuario: {nombre}");
            Console.Write(@"1. Saludar
2. Mostrar la hora
3. Salir
Ingrese una opcion: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Hola {nombre}");
                    Continuar();
                    break;
                case "2":
                    Console.WriteLine($"La fecha y hora es : {DateTime.Now}");
                    Continuar();
                    break;
                case "3":
                    Console.WriteLine("Programa finalizado...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    Continuar();  
                    break;
            }
        }while(opcion != "3");
    }
    static void Continuar()
    {
        Console.WriteLine("Ingrese una tecla para continuar...");
        Console.ReadKey();
    }
}
