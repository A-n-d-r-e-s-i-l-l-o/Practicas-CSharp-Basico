namespace practicaSerializacion;
class Program
{
    static void Main()
    {
        Configuracion configuracion = new Configuracion{Idioma = "Ingles",Volumen = 40, ModoOscuro = true};
        GestorConfiguracion.Guardar(configuracion,"config.json");
        Configuracion? Config = GestorConfiguracion.Cargar("config.json");
        Console.WriteLine($@"Idioma: {Config?.Idioma}
Volumen: {Config?.Volumen}
Modo Oscuro: {Config?.ModoOscuro}");
    }
}