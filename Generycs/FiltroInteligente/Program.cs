using System.Data;

public class Program
{
    static void Main()
    {
        List<Videojuegos> videojuegos = new List<Videojuegos>()
        {
          new Videojuegos("Mortal Kombat 11",31m),
          new Videojuegos("Mortal Kombat XL",13.99m),
          new Videojuegos("The Invencible",10.9m)  
        };
        List<Comida> comidas = new List<Comida>()
        {
            new Comida("Chaufa",10m),
            new Comida("Ceviche",12.5m),
            new Comida("Chicharron de pescado",31m)
        };
        Console.WriteLine("------------- Lista Filtrada (Comidas) ----------------");
        foreach(Comida comida in Filtrador.filtrar(comidas, 15m))
        {
            Console.WriteLine($"{comida.nombre} : {comida.Precio}");
        }

        Console.WriteLine("----------- Lista Filtrada (VideoJuegos) --------------");
        foreach(Videojuegos videojuegos1 in Filtrador.filtrar(videojuegos, 12.5m))
        {
            Console.WriteLine($"{videojuegos1.Titulo} : {videojuegos1.Precio}");
        }
    }
}