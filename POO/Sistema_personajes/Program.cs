using System;
using System.Collections.Generic;
namespace Sistema_Pers;
class Program
{
    static void Main()
    {
        Mago mago = new Mago("El mago",4);
        Arquero arquero = new Arquero("El arquero");
        List<Personajes> personajes = new List<Personajes>(){mago,arquero};
        foreach(Personajes item in personajes)
        {
            item.atacar();
        }
        mago.VerMana();
    }
}