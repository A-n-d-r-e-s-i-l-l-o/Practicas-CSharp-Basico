using System.Collections.Generic;
public class Intercambiador<T>
{
    public void IntercambiarDatos(ref T Dato1,ref T Dato2)
    {
        T auxiliar = Dato1;
        Dato1 = Dato2;
        Dato2 = auxiliar;
    }
}