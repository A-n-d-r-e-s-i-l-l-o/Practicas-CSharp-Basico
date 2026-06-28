using System;
namespace Sistema_Pers;

public class Mago : Personajes
{
    public int mana{get;set;}
    public Mago(string nombre,int mana) : base(nombre)
    {
        if (mana>0)
            this.mana = mana;
    }
    public override void atacar()
    {
        if (mana >= 3)
        {
            Console.WriteLine($"{nombre} lanza una bola de fuego");
            mana -= 3;
        }
        else
        {
            Console.WriteLine("Mana insuficiente");
        }
    }
    public void VerMana()
    {
        Console.WriteLine($"Tienes {mana} de mana");
    }
}
