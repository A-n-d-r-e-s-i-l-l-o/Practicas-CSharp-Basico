using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> correos = new List<string>()
        {
            "ana@gmail.com", 
            "carlos@hotmail.com", 
            "beatriz@gmail.com", 
            "daniel@yahoo.com", 
            "elena@gmail.com"
        };

        var nombres = correos
        .Where(n => n.EndsWith("@gmail.com") || n.EndsWith("@yahoo.com") || n.EndsWith("@hotmail.com"))
        .Select(x => x.Split('@')[0].ToUpper())
        .ToList();

        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}