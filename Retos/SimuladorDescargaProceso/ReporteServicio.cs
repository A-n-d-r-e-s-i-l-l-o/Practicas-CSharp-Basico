namespace SimuladorDescargaProceso;
using System;
using System.Threading.Tasks;
public class ReporteServicio
{
    public event EventHandler<string>? MostrarMensajeInicial;
    public event EventHandler<string>? MostrarMensajeFinal;
    public async Task<ReporteResultado> SimularDescargaYProcesamientoAsync(string nombreReporte, int milisegundosRetardo)
    {
        Random random = new Random();
        MostrarMensajeInicial?.Invoke(this, $"La descarga {nombreReporte} a iniciado");
        await Task.Delay(milisegundosRetardo);
        MostrarMensajeFinal?.Invoke(this, $"La descarga a finalizado");
        return new ReporteResultado{Nombre = nombreReporte, FilasProcesadas = random.Next(1,10), Exitoso = true};
    }
}