class Temperaturas
{
    static void Main()
    {
        int contador = 0;
        double temp;
        double[] temperaturas = new double[7];
        for (int i = 0; i <= 6; i++)
        {
            Console.Write($"Ingrese la temperatura del dia {i+1}: ");
            temp = Convert.ToDouble(Console.ReadLine());
            temperaturas[i] = temp;
            if (temp > 25)
            {
                contador += 1;
            }
        }
        Console.WriteLine($"Hubo {contador} días con temperaturas mayores a 25°C");
    }
}