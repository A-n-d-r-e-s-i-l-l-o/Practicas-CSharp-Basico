using System;
class Clasificar
{
    static void Main()
    {
        double a,b,c;
        Console.WriteLine("------------- Clasificador de triangulos -------------");
        Console.Write("Ingrese el primer lado: ");
        string? input1 = Console.ReadLine();
        Console.Write("Ingrese el segundo lado: ");
        string? input2 = Console.ReadLine();
        Console.Write("Ingrese el tercer lado: ");
        string? input3 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2) || string.IsNullOrWhiteSpace(input3))
        {
            Console.WriteLine("Revise que ningun dato quede vacio...");
        }
        else if(double.TryParse(input1, out a) && double.TryParse(input2, out b) && double.TryParse(input3, out c))
        {
            if (a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a)
            {
                if (a==b && b==c)
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
                else if(a==b || b==c || a == c)
                {
                    Console.WriteLine("El triangulo es isosceles");
                }
                else
                {
                    Console.WriteLine("El triangulo es escaleno");
                }
            }
            else
            {
                Console.WriteLine("Los numeros deben ser positivos o de caso contrario no cumplieron con el teorema de existencia de triangulos...");
            }
        }
        else
        {
            Console.WriteLine("Los datos ingresados deben ser numeros positivos...");
        }
    }
}
