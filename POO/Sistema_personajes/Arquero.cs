using System;
namespace Sistema_Pers;

public class Arquero : Personajes
{
    public Arquero(string nombre):base(nombre){}
    public override void atacar()
    {
        Console.WriteLine($"{nombre} a lanzado una flecha certera");
    }
}