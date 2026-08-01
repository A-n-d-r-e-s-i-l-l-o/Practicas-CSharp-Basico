using System.Text.Json;
namespace GestorTareas;
class Program
{
    static async Task Main()
    {
        try
        {
            RepositorioTarea repositorioTarea = new RepositorioTarea("tareas.json");
            await repositorioTarea.AgregarTareaAsync(new Tarea{ID=1,Titulo = "Especializarme en C#", Completado = false});
            await repositorioTarea.AgregarTareaAsync(new Tarea{ID = 2, Titulo = "Hacer ejercicio", Completado = false});
            await repositorioTarea.AgregarTareaAsync(new Tarea{ID = 3, Titulo = "Estudiar calculo", Completado = true});
            List<Tarea> tareascompletadas = await  repositorioTarea.ObtenerTareasCompletadasAsync();
            Console.WriteLine("============== Tareas Completadas ==================");
            foreach (Tarea tarea in tareascompletadas)
            {
                Console.WriteLine($"{tarea.Titulo}");
            }
        }
        catch(JsonException)
        {
            Console.WriteLine("Error en el archivo... posiblemente corrupto");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error inesperado {ex.Message}");
        }
    }
}
