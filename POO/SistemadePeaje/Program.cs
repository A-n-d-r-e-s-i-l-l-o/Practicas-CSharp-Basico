namespace SistemaPeaje;
public class Program
{
    static void Main()
    {
        CabinaPeaje cabinaPeaje = new CabinaPeaje();
        cabinaPeaje.MandarVehiculo += Mostrar;
        List<IVehiculo> vehiculos = new List<IVehiculo>()
        {
            new Camion("ALP123",4),
            new Auto("YUP352"),
            new Ambulancia("TYU712")
        };
        foreach(IVehiculo item in vehiculos)
        {
            cabinaPeaje.ProcesarVehiculo(item);
        }
        Console.WriteLine($"Total obtenido:{cabinaPeaje.MostrarReporte()}");
        static void Mostrar(IVehiculo vehiculo)
        {
            Console.WriteLine($"Se proceso el vehiculo con placa {vehiculo.Placa}  pago: {vehiculo.CalcularPeaje()}");
        }
    }
}