class Comparar_num
{
    static void Main()
    {
        double max = 0;
        double min = 0;
        Console.Write("Ingrese la cantidad de notas: ");
        int cant_notas = Convert.ToInt32(Console.ReadLine());
        double[] notas = new double[cant_notas];
        for(int i=0;i < cant_notas; i++)
        {
            Console.Write($"Ingrese la nota {i+1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            if (i==0)
            {
                max = notas[i];
                min = notas[i];
                continue;
            }
            if (notas[i] >= max)
                max = notas[i];
        
            if (notas[i] <= min)
                min = notas[i];
        }
        Console.WriteLine($"La nota maxima es: {max}");
        Console.WriteLine($"La nota minima es: {min}");
    }
}