using System;
namespace Sistema_Pers;
public class Personajes
{
    public string nombre{get;set;}
    public Personajes(string nombre)
    {
        this.nombre = nombre;
    }
    public virtual void atacar()
    {
        Console.WriteLine($"{nombre} realiza un ataque basico");
    }
}