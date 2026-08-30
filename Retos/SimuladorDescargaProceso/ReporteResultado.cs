namespace SimuladorDescargaProceso;
public class ReporteResultado
{
    public string? Nombre{get;set;}
    public int FilasProcesadas{get;set;}
    public bool Exitoso{get;set;}
    public ReporteResultado(){}
    public ReporteResultado(string Nombre,bool Exitoso)
    {
        this.Nombre = Nombre;
        this.Exitoso = Exitoso;
        Random random = new Random();
        this.FilasProcesadas = random.Next(1,10);
    }
}