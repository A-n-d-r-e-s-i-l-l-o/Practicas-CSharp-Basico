public class Program
{
    static void Main()
    {
        BaseDatosEnMemoria<string> baseDatosEnMemoriatextos = new BaseDatosEnMemoria<string>();
        BaseDatosEnMemoria<int> baseDatosEnMemoriaNumeros = new BaseDatosEnMemoria<int>();
        baseDatosEnMemoriaNumeros.Guardar(12);
        baseDatosEnMemoriaNumeros.Guardar(49);
        baseDatosEnMemoriaNumeros.Guardar(56);
        baseDatosEnMemoriaNumeros.Guardar(32);
        var Puntuaciones = baseDatosEnMemoriaNumeros.ObtenerTodos();
        baseDatosEnMemoriatextos.Guardar("Francia");
        baseDatosEnMemoriatextos.Guardar("Peru");
        baseDatosEnMemoriatextos.Guardar("Ecuador");
        baseDatosEnMemoriatextos.Guardar("Chile");
        var Paises = baseDatosEnMemoriatextos.ObtenerTodos();

        foreach(string baseDatos in Paises)
        {
            Console.WriteLine($"{baseDatos}");
        }

        
        foreach(int baseDatos in Puntuaciones)
        {
            Console.WriteLine($"{baseDatos}");
        }
    }
}