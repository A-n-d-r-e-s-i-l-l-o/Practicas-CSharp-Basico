using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Gasto> gastos = new List<Gasto>()
        {
            new Gasto("comida",200),
            new Gasto("Transporte",10),
            new Gasto("Entrenamiento",100),
            new Gasto("comida",30),
            new Gasto("Transporte",5)
        };
        var grupos = gastos.GroupBy(x => x.categorias.ToLower());
        foreach(var grupo in grupos)
        {
            Console.WriteLine($"--------------- {grupo.Key} ------------------");
            
            double total = grupo.Sum(x => x.Monto);
            double promedio = grupo.Average(x => x.Monto);
            Console.WriteLine($"Gasto: {total} Promedio: {promedio}");   
        }
    }
}