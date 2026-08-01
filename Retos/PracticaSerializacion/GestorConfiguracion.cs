namespace practicaSerializacion;
using System.IO;
using System.Text.Json;
public class GestorConfiguracion
{
    public static void Guardar(Configuracion config,string ruta)
    {
        string configText = JsonSerializer.Serialize(config);
        File.WriteAllText(ruta,configText);
    }
    public static Configuracion? Cargar(string ruta)
    {
        if (!File.Exists(ruta))
        {
            return new Configuracion {Idioma = "Español", Volumen = 50, ModoOscuro = true};   
        }
        try
        {
            string TextJson = File.ReadAllText(ruta);
            Configuracion? CargarConfig = JsonSerializer.Deserialize<Configuracion>(TextJson);
            return CargarConfig?? new Configuracion {Idioma = "Español", Volumen = 50, ModoOscuro = true};
        }
        catch (JsonException)
        {
            Console.WriteLine("El archivo json esta corrupto... Devolviendo valores por defecto");
            return new Configuracion {Idioma = "Español", Volumen = 50, ModoOscuro = true};
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Ocurrio un error inesperado {ex.Message}");
            return new Configuracion {Idioma = "Español", Volumen = 50, ModoOscuro = true};
        }
    }
}