class Filtro
{
    static void Main()
    {
        string mensaje1 = System.String.Empty;
        string mensaje2 = System.String.Empty;
        string mensaje3 = System.String.Empty;
        string mensaje4 = System.String.Empty;
        Console.Write("Ingrese la cantidad de productos a registrar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        string[] Productos = new string[cantidad];
        int[] Stock = new int[cantidad];
        for(int i = 0; i<cantidad; i++) 
        {
            Console.Write($"Ingrese el nombre del producto {i+1}: ");
            Productos[i] = Console.ReadLine();
            Console.Write("Ingrese la cantidad en stock: ");
            Stock[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int j = 0;j<cantidad; j++)
        {
            if (Stock[j] <= 5)
            {
                mensaje2 = $"Nombre : {Productos[j]}\tStock: {Stock[j]} \n";
                mensaje1 = mensaje1 + mensaje2;
            }
            else
            {
                mensaje3 = $"Nombre : {Productos[j]}\tStock: {Stock[j]} \n";
                mensaje4 = mensaje4 + mensaje3;
            }
        }
        Console.WriteLine("----------- Productos con stock menores iguales a 5 ---------------");
        Console.WriteLine(mensaje1);
        Console.WriteLine("----------- Productos con stock mayores a 5 ---------------");
        Console.WriteLine(mensaje4);
    }
}