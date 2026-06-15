using System;
class TablaMultiplicar
{
    static void Main()
    {
        int num1, num2;
        Console.WriteLine("-------------------- TABLA DE MULTIPLICAR -----------------------");
        Console.Write("Ingrese de que numero desea saber su tabla de multiplicar: ");
        string? input1 = Console.ReadLine();
        Console.Write("Ingrese hasta que numero desea su tabla: ");
        string? input2 = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2))
        {
            Console.WriteLine("Debe ingresar todos los datos");
        }
        else if(int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
        {
            for(int i = 1; i <= num2; i++)
            {
                Console.WriteLine($"{i} X {num1} = {i*num1}");
            }
        }
        else
        {
            Console.WriteLine("Revise que los datos ingresados sean numeros");
        }
    }
}
