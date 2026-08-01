using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>()
        {
          new Producto(1,"Cebolla",3),
          new Producto(2,"Mandarina",4),
          new Producto(3,"Gaseosa",0),
          new Producto(4,"Arroz",0)
        };
        foreach(Producto item in productos)
        {
            Console.WriteLine($"id: {item.ID} Nombre: {item.Nombre} Stock: {item.Stock}");
        }
        Console.Write("Ingrese el id del producto: ");
        int ObtenerId = Convert.ToInt32(Console.ReadLine());

        Producto? encontrar = productos.FirstOrDefault(p => p.ID == ObtenerId);
        if (encontrar != null)
        {
            Console.WriteLine($"Nombre: {encontrar.Nombre} Stock: {encontrar.Stock}");
        }
        else
        {
            Console.WriteLine("Producto no existe");
        }
        //Primer elemento
        Producto? StockAcabado = productos.FirstOrDefault(p => p.Stock == 0);
        if(StockAcabado != null)
        {
            Console.WriteLine($"{StockAcabado.Nombre} agotado");
        }
        //Toda la lista agotada
        var ProductosAgotados = productos.Where(p => p.Stock == 0).ToList();
        foreach(Producto agotados in ProductosAgotados)
        {
            Console.WriteLine($"{agotados.Nombre} agotado");
        }
    }
}
