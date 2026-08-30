namespace SimuladorDescargaProceso;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
class Program
{
    static async Task Main()
    {
        ReporteServicio reporteServicio = new ReporteServicio();
        reporteServicio.MostrarMensajeInicial += (sender , mensaje) => Console.WriteLine($"Inicio : {mensaje}");
        reporteServicio.MostrarMensajeFinal += (sender, mensaje) => Console.WriteLine($"Final: {mensaje}");
        Task<ReporteResultado> tarea1 = reporteServicio.SimularDescargaYProcesamientoAsync("Reporte Ventas",1200);
        Task<ReporteResultado> tarea2 = reporteServicio.SimularDescargaYProcesamientoAsync("Reporte Usuarios",2000);
        Task<ReporteResultado> tarea3 = reporteServicio.SimularDescargaYProcesamientoAsync("Reporte Inventario",100);
        ReporteResultado[] resultados = await Task.WhenAll(tarea1,tarea2,tarea3);
        List<ReporteResultado> reporteResultados = resultados.ToList();
        var TotalFilasProcesadas = reporteResultados.Sum(p => p.FilasProcesadas);
        var ReportesExitosos = reporteResultados.Count(c=> c.Exitoso == true);
        Console.WriteLine($"Reportes exitoso : {ReportesExitosos}  Filas Procesadas: {TotalFilasProcesadas}");
    }
}