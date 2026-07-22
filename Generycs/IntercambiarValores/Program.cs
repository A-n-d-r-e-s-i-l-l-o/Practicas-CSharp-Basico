public class Program
{
    static void Main()
    {
        Intercambiador<string> intercambiadorText = new Intercambiador<string>();
        string a = "a";
        string b = "b";
        Console.WriteLine(a);
        Console.WriteLine(b);
        intercambiadorText.IntercambiarDatos(ref a,ref b);
        Console.WriteLine(a);
        Console.WriteLine(b);

        Intercambiador<int> intercambiadorInt = new Intercambiador<int>();
        int num1 = 321;
        int num2 = 123;
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        intercambiadorInt.IntercambiarDatos(ref num1,ref num2);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}