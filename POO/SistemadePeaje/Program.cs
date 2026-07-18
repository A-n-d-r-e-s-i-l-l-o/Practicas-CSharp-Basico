namespace SistemaPeaje;
public class Program
{
    static void Main()
    {
        CabinaPeaje cabinaPeaje = new CabinaPeaje();
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
        foreach(IVehiculo item in cabinaPeaje.MostrarLista())
        {
            Console.WriteLine($"El vehiculo de placa {item.Placa} pago {item.CalcularPeaje()}");
        }
        Console.WriteLine($"Total obtenido:{cabinaPeaje.MostrarReporte()}");
    }
}