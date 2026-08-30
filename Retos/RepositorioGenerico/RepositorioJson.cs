namespace RepositorioGenerico;
using System.Text.Json;
using System.IO;
public class RepositorioJsonAsync<T>:IRepositorioAsync<T> where T : class,IEntidad
{
    public string Ruta{get;set;}
    public RepositorioJsonAsync(string ruta)
    {
        this.Ruta = ruta;
    }
    public async Task<List<T>> ObtenerTodosAsync()
    {
        if (!File.Exists(Ruta))
        {
            return new List<T>();
        }
        string MisDatos = await File.ReadAllTextAsync(Ruta);
        List<T>? DatosGuardados = JsonSerializer.Deserialize<List<T>>(MisDatos);
        return DatosGuardados?? new List<T>();
    }
    public async Task GuardarAsync(T entidad)
    {
        List<T>? DatosCargados = await ObtenerTodosAsync();
        if(entidad.Id == 0)
        {
            int nuevoId = DatosCargados.Any()? DatosCargados.Max(x => x.Id)+1 : 1;
            entidad.Id = nuevoId;
            DatosCargados.Add(entidad);
        }
        else
        {
            int pos = DatosCargados.FindIndex(a => a.Id == entidad.Id);
            if (pos != -1)
            {
                DatosCargados[pos] = entidad;
            }
            else
            {
                DatosCargados.Add(entidad);
            }
        }
        string GuardarList = JsonSerializer.Serialize(DatosCargados, new JsonSerializerOptions{WriteIndented = true});
        await File.WriteAllTextAsync(Ruta,GuardarList);

    }
    public async Task<T?> ObtenerPorIdAsync(int id)
    {
        List<T> MisDatos = await ObtenerTodosAsync();
        var objetoEncontrado = MisDatos.FirstOrDefault(x => x.Id == id); 
        return objetoEncontrado;
    }
}