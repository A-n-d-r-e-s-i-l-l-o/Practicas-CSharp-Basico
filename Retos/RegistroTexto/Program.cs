using System;
class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese el nombre de su archivo: ");
        string? ruta = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(ruta))
        {   
            Registro registro = new Registro(ruta.Trim() + ".txt");
            bool exit = false;
            do
            {
                Console.Write("Ingrese el mensaje a guardar: ");
                string? mensaje = Console.ReadLine();

                if (mensaje?.ToUpper().Trim() == "EXIT")
                {
                    exit = true;
                }
                else
                {
                    try
                    {
                        registro.GuardarRegistro(mensaje);
                        Console.WriteLine("Se guardo correctamente");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Error: No se pudo escribir en el archivo. Intente de nuevo.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error inesperado: {ex.Message}");
                    }
                }
            
            } while (!exit);
        }
        else
        {
            Console.WriteLine("No puede dejar la ruta vacia");
        }
    }
}