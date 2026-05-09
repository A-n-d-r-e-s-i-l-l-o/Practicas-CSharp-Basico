class FormateadorNombres
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine().ToUpper();
        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine().ToUpper();
        Console.WriteLine($"Bienvenido {nombre.Trim()} {apellido.Trim()}");
    }
}