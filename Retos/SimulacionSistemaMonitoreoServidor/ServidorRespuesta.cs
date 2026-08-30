namespace SimulacionSistemaMonitoreoServidores;
public class ServidorRespuesta
{
    public string? Url{get;set;}
    public int LatenciaMs{get;set;}
    public bool Exitoso{get;set;}
    public ServidorRespuesta(){}
    public ServidorRespuesta(string Url, int LatenciaMs, bool Exitoso)
    {
        this.Url = Url;
        this.LatenciaMs = LatenciaMs;
        this.Exitoso = Exitoso;
    }
}