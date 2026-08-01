namespace GestorTareas;
using System.Collections.Generic;
using System.Text.Json;
public class RepositorioTarea
{
    public string RutaArchivo{get;set;}
    public RepositorioTarea(string RutaArchivo)
    {
        this.RutaArchivo = RutaArchivo;
    }
    public  async Task<List<Tarea>> ObtenerTodasAsync()
    {
        if(!File.Exists(RutaArchivo))
            return new List<Tarea>();
        
        string TextTarea = await File.ReadAllTextAsync(RutaArchivo);
        List<Tarea>? Tareas = JsonSerializer.Deserialize<List<Tarea>>(TextTarea);
        return Tareas?? new List<Tarea>();
    }
    public async Task AgregarTareaAsync(Tarea nuevaTarea)
    {
        List<Tarea> TareasActuales = await ObtenerTodasAsync();
        bool Existe = TareasActuales.Any(e => e.Titulo?.Equals(nuevaTarea.Titulo, StringComparison.OrdinalIgnoreCase) == true);
        if (!Existe)
        {
            TareasActuales.Add(nuevaTarea);
            await File.WriteAllTextAsync(RutaArchivo,JsonSerializer.Serialize<List<Tarea>>(TareasActuales,new JsonSerializerOptions{WriteIndented = true}));
        }
    }
    public async Task<List<Tarea>> ObtenerTareasCompletadasAsync()
    {
        List<Tarea> Tareas = await ObtenerTodasAsync();
        var TareasCompletadas = Tareas.Where(c=>c.Completado==true).ToList();
        return TareasCompletadas;
    }   
}