namespace SimulacionSistemaMonitoreoServidores;
public class ServidorMonitor
{
    public static async Task<ServidorRespuesta> VerificarServidorAsync(string url, CancellationToken token)
    {
        int milisegundos = Random.Shared.Next(500,4000);
        try
        {
            await Task.Delay(milisegundos, token);
            return new ServidorRespuesta{Url = url, LatenciaMs = milisegundos, Exitoso = true};
        }
        catch (OperationCanceledException)
        {
            return new ServidorRespuesta{Url= url, LatenciaMs= milisegundos, Exitoso = false};
        }
    }  
}