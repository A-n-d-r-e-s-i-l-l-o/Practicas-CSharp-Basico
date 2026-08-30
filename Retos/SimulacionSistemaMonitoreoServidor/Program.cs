namespace SimulacionSistemaMonitoreoServidores;
class Program
{
    static async Task Main()
    {
        var time = new CancellationTokenSource(3000);
        List<string> urls = new List<string>()
        {
            "https://servidor1.com",
            "https://servidor2.com",
            "https://servidor3.com",
            "https://servidor4.com",
            "https://servidor5.com"
        };
        List<Task<ServidorRespuesta>> tareas = urls.Select( url=> ServidorMonitor.VerificarServidorAsync(url,time.Token)).ToList();
        while (tareas.Count()>0)
        {
            Task<ServidorRespuesta> tareaCompletada = await Task.WhenAny(tareas);
            tareas.Remove(tareaCompletada);
            ServidorRespuesta resultado = await tareaCompletada;
            Console.WriteLine($"{resultado.Url} respondio en {resultado.LatenciaMs} resultado: {resultado.Exitoso}");
        }
    }
}